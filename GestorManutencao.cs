using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic; // Necessário para Dicionário
using System.Linq; // Necessário para manipular as linhas do log

namespace SupervisorioDana
{
    public static class GestorManutencao
    {
        // --- Caminhos dos Arquivos ---
        private static string caminhoArquivo = Path.Combine(Environment.CurrentDirectory, "manutencao.txt");
        private static string caminhoArquivoConfig = Path.Combine(Environment.CurrentDirectory, "manutencao_config.txt");

        // NOVO: Caminho único para TODAS as notas
        private static string caminhoArquivoNotas = Path.Combine(Environment.CurrentDirectory, "notas_manutencao_geral.txt");

        private static string caminhoArquivoEstado = Path.Combine(Environment.CurrentDirectory, "manutencao_estado.txt");
        public static DateTime? HoraNivel4Disparou { get; private set; } = null;

        // --- Variáveis de Configuração (com valores padrão) ---
        private static TimeSpan horarioNivel1 = new TimeSpan(8, 0, 0);  // 08:00
        private static TimeSpan horarioNivel2 = new TimeSpan(9, 0, 0);  // 09:00
        private static TimeSpan horarioNivel3 = new TimeSpan(9, 30, 0); // 09:30
        private static TimeSpan horarioNivel4 = new TimeSpan(10, 0, 0); // 10:00

        // --- Variáveis de Estado Interno ---
        private static bool configCarregada = false;
        private static int nivelAvisoMostrado = 0;
        public static int UltimoNivelAviso { get; private set; }


        /// <summary>
        /// Carrega as configurações (sem alterações)
        /// </summary>
        private static void CarregarConfiguracao()
        {
            if (configCarregada) return;

            if (!File.Exists(caminhoArquivoConfig))
            {
                try
                {
                    string[] defaultConfig = {
                        "# Horários dos 4 níveis de aviso (formato HH:mm)",
                        "aviso_nivel_1:08:00",
                        "aviso_nivel_2:09:00",
                        "aviso_nivel_3:09:30",
                        "aviso_nivel_4:10:00"
                    };
                    File.WriteAllLines(caminhoArquivoConfig, defaultConfig);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar 'manutencao_config.txt': " + ex.Message + "\nUsando valores padrão.", "Erro de Configuração", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    var configDict = new Dictionary<string, string>();
                    string[] linhas = File.ReadAllLines(caminhoArquivoConfig);

                    foreach (string linha in linhas)
                    {
                        if (string.IsNullOrWhiteSpace(linha) || linha.Trim().StartsWith("#")) continue;
                        string[] partes = linha.Split(new[] { ':' }, 2);
                        if (partes.Length == 2) configDict[partes[0].Trim()] = partes[1].Trim();
                    }

                    if (configDict.ContainsKey("aviso_nivel_1")) horarioNivel1 = TimeSpan.Parse(configDict["aviso_nivel_1"]);
                    if (configDict.ContainsKey("aviso_nivel_2")) horarioNivel2 = TimeSpan.Parse(configDict["aviso_nivel_2"]);
                    if (configDict.ContainsKey("aviso_nivel_3")) horarioNivel3 = TimeSpan.Parse(configDict["aviso_nivel_3"]);
                    if (configDict.ContainsKey("aviso_nivel_4")) horarioNivel4 = TimeSpan.Parse(configDict["aviso_nivel_4"]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao ler 'manutencao_config.txt': " + ex.Message + "\nUsando valores padrão.", "Erro de Configuração", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    horarioNivel1 = new TimeSpan(8, 0, 0);
                    horarioNivel2 = new TimeSpan(9, 0, 0);
                    horarioNivel3 = new TimeSpan(9, 30, 0);
                    horarioNivel4 = new TimeSpan(10, 0, 0);
                }
            }
            try
            {
                if (File.Exists(caminhoArquivoEstado))
                {
                    string[] estado = File.ReadAllLines(caminhoArquivoEstado);
                    if (estado.Length >= 2)
                    {
                        nivelAvisoMostrado = int.Parse(estado[0]);
                        UltimoNivelAviso = nivelAvisoMostrado;

                        // Se o nível salvo for 4, carregue o timestamp de início
                        if (nivelAvisoMostrado == 4 && !string.IsNullOrEmpty(estado[1]))
                        {
                            HoraNivel4Disparou = DateTime.Parse(estado[1]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                /* Ignora erros de leitura do estado, começa do zero */
                Console.WriteLine("Erro ao ler estado: " + ex.Message);
            }
            configCarregada = true;
        }


        /// <summary>
        /// Lê a data e hora da última manutenção (sem alterações)
        /// </summary>
        public static DateTime LerUltimaManutencao()
        {
            if (!File.Exists(caminhoArquivo)) return DateTime.MinValue;
            try
            {
                string conteudo = File.ReadAllText(caminhoArquivo);
                string[] partes = conteudo.Split('|');
                return DateTime.Parse(partes[0]);
            }
            catch { return DateTime.MinValue; }
        }

        // -----------------------------------------------------------------
        // --- MÉTODO DE LOG (NOTAS) ATUALIZADO ---
        // -----------------------------------------------------------------

        /// <summary>
        /// ATUALIZADO: Regista um evento no ficheiro de notas GERAL.
        /// Este método coloca o "bloco" do dia atual sempre no topo do ficheiro.
        /// </summary>
        public static void RegistrarNota(int nivel, int codigoResposta, string usuario = "")
        {
            try
            {
                // NOVO: Define o separador do bloco de hoje
                string separadorHoje = $"--- {DateTime.Now:yyyy-MM-dd} ---";

                List<string> linhasHoje = new List<string>();
                List<string> linhasAntigas = new List<string>();

                // 1. Lê o ficheiro de notas atual, se existir
                if (File.Exists(caminhoArquivoNotas))
                {
                    List<string> linhasTotais = File.ReadAllLines(caminhoArquivoNotas).ToList();

                    // 2. Procura o separador de hoje
                    int indiceSeparador = linhasTotais.FindIndex(l => l.Contains(separadorHoje));

                    if (indiceSeparador != -1)
                    {
                        // Achou o bloco de hoje.
                        // Antigas = tudo ANTES do separador
                        linhasAntigas = linhasTotais.GetRange(0, indiceSeparador);
                        // Hoje = tudo DEPOIS do separador
                        linhasHoje = linhasTotais.GetRange(indiceSeparador + 1, linhasTotais.Count - (indiceSeparador + 1));
                    }
                    else
                    {
                        // Não achou o bloco de hoje. O ficheiro todo é antigo.
                        linhasAntigas = linhasTotais;
                        // linhasHoje continua vazia
                    }
                }

                // 3. Prepara a nova linha (Lógica IDÊNTICA à versão anterior)
                string horaAtual = DateTime.Now.ToString("HH:mm");
                string novaLinha = "";
                string prefixoLinha = $"{nivel} AVISO";

                if (nivel == 0) // Nível 0 é "manutenção feita"
                {
                    novaLinha = $"{horaAtual} - manutenção feita. (1 - Confirmado por: {usuario})";
                    linhasHoje.Add(novaLinha); // Adiciona ao bloco de HOJE
                }
                else
                {
                    novaLinha = $"{horaAtual} - {prefixoLinha} resposta ({codigoResposta})";
                    if (codigoResposta == 1) novaLinha += $" (User: {usuario})";

                    // Procura se já existe um log para este NÍVEL (só no bloco de hoje)
                    int indiceLinhaExistente = linhasHoje.FindIndex(l => l.Contains(prefixoLinha));

                    if (indiceLinhaExistente != -1)
                    {
                        // ATUALIZA a linha existente no bloco de HOJE
                        linhasHoje[indiceLinhaExistente] = novaLinha;
                    }
                    else
                    {
                        // ADICIONA a nova linha ao bloco de HOJE
                        linhasHoje.Add(novaLinha);
                    }
                }

                // 4. Reconstrói o ficheiro completo
                List<string> linhasFinais = new List<string>();
                linhasFinais.Add(separadorHoje); // O mais novo (bloco de hoje) no topo
                linhasFinais.AddRange(linhasHoje);      // O conteúdo do bloco de hoje
                linhasFinais.AddRange(linhasAntigas);   // Os blocos antigos em baixo

                // 5. Salva o ficheiro
                File.WriteAllLines(caminhoArquivoNotas, linhasFinais);
            }
            catch (Exception ex)
            {
                // Não podemos parar o programa por um erro de log
                Console.WriteLine("Erro ao salvar notas: " + ex.Message);
            }
        }

        // -----------------------------------------------------------------
        // --- MÉTODOS PRINCIPAIS (Sem alterações) ---
        // (SalvarManutencaoAgora e VerificarManutencaoPendente
        //  continuam iguais, pois eles apenas chamam o 
        //  RegistrarNota, que agora tem a nova lógica)
        // -----------------------------------------------------------------

        /// <summary>
        /// Salva a data e hora ATUAL no ficheiro 'manutencao.txt' e RESETA o nível de aviso.
        /// (Sem alterações aqui)
        /// </summary>
        public static void SalvarManutencaoAgora(string usuario = "Desconhecido")
        {
            DateTime agora = DateTime.Now;
            try
            {
                // 1. Atualiza a nota do nível atual para "resposta (1)"
                RegistrarNota(UltimoNivelAviso, 1, usuario);

                // 2. Adiciona a linha "manutenção feita"
                RegistrarNota(0, 1, usuario); // Nível 0 = código para "manutenção feita"

                string conteudo = $"{agora:O}|{usuario}"; // Formato ISO 8601 (O)
                File.WriteAllText(caminhoArquivo, conteudo);

                nivelAvisoMostrado = 0;
                UltimoNivelAviso = 0;

                HoraNivel4Disparou = null;
                try
                {
                    // Reseta o arquivo de estado salvo
                    File.WriteAllText(caminhoArquivoEstado, "0\n");
                }
                catch (Exception ex) { Console.WriteLine("Erro ao resetar estado: " + ex.Message); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar arquivo de manutenção: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// O CÉREBRO: Verifica o status da manutenção e retorna o nível de aviso necessário.
        /// (Sem alterações aqui)
        /// </summary>
        public static int VerificarManutencaoPendente()
        {
            if (!configCarregada)
                CarregarConfiguracao();

            DateTime agora = DateTime.Now;
            DateTime ultimaManutencao = LerUltimaManutencao();

            DateTime alarmeNivel1 = DateTime.Today.Add(horarioNivel1);
            DateTime alarmeNivel2 = DateTime.Today.Add(horarioNivel2);
            DateTime alarmeNivel3 = DateTime.Today.Add(horarioNivel3);
            DateTime alarmeNivel4 = DateTime.Today.Add(horarioNivel4);

            // 1. VERIFICA SE A MANUTENÇÃO JÁ FOI FEITA HOJE
            bool manutencaoFeitaHoje = (ultimaManutencao.Date == DateTime.Today && ultimaManutencao >= alarmeNivel1);

            if (agora < alarmeNivel1 || manutencaoFeitaHoje)
            {
                nivelAvisoMostrado = 0;
                UltimoNivelAviso = 0;
                return 0; // 0 = OK, não fazer nada
            }

            // --- MANUTENÇÃO NECESSÁRIA ---

            // 2. CALCULA QUAL NÍVEL *DEVERIA* ESTAR ATIVO AGORA
            int nivelAtualRequerido = 0;
            if (agora >= alarmeNivel4) nivelAtualRequerido = 4;
            else if (agora >= alarmeNivel3) nivelAtualRequerido = 3;
            else if (agora >= alarmeNivel2) nivelAtualRequerido = 2;
            else if (agora >= alarmeNivel1) nivelAtualRequerido = 1;

            // 3. COMPARA COM O NÍVEL QUE JÁ MOSTRAMOS (A "TRAVA")
            
            if (nivelAtualRequerido > nivelAvisoMostrado)
            {
                string estadoParaSalvar = "";

                // Se o Nível 4 acabou de disparar...
                if (nivelAtualRequerido == 4)
                {
                    HoraNivel4Disparou = DateTime.Now;
                    // Salva Nível e Data ISO
                    estadoParaSalvar = $"{nivelAtualRequerido}\n{HoraNivel4Disparou.Value:O}";
                }
                else
                {
                    // Se for nível 1, 2, ou 3, só salva o nível
                    estadoParaSalvar = $"{nivelAtualRequerido}\n";
                }

                // Atualiza as variáveis de memória
                nivelAvisoMostrado = nivelAtualRequerido;
                UltimoNivelAviso = nivelAtualRequerido;

                // Salva o novo estado no disco
                try { File.WriteAllText(caminhoArquivoEstado, estadoParaSalvar); }
                catch (Exception ex) { Console.WriteLine("Erro ao salvar estado: " + ex.Message); }

                // Regista o disparo do aviso no ficheiro de notas (seu código original)
                if (nivelAtualRequerido == 4)
                {
                    RegistrarNota(4, 2);
                }
                else if (nivelAtualRequerido > 0)
                {
                    RegistrarNota(nivelAtualRequerido, 0);
                }

                return nivelAtualRequerido;
            }

            return 0; // 0 = OK, não fazer nada
        }
    }
}