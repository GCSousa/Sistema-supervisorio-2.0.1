using System;
using System.Windows.Forms;
using System.IO;

namespace SupervisorioDana
{
    // A palavra 'partial' significa que esta classe está dividida
    // com o ficheiro FrmAvisoManutencao.Designer.cs
    public partial class FrmAvisoManutencao : Form
    {
        // Variável para guardar o nível de aviso atual
        private int nivelAvisoAtual;

        // NOVO: Adicionamos um botão "Não" que será usado nos níveis 2 e 3
        private System.Windows.Forms.Button btnNao;

        public FrmAvisoManutencao()
        {
            // Este método é definido no ficheiro .Designer.cs
            InitializeComponent();

            // Guardamos o nível atual para usar em outros métodos
            this.nivelAvisoAtual = GestorManutencao.UltimoNivelAviso;

            // Chamamos o método que configura a aparência do formulário
            ConfigurarFormularioPorNivel(this.nivelAvisoAtual);
        }

        /// <summary>
        /// NOVO: Este método configura os textos e botões
        /// do formulário com base no nível do aviso.
        /// </summary>
        /// <summary>
        /// NOVO: Este método configura os textos e botões
        /// do formulário com base no nível do aviso.
        /// </summary>
        private void ConfigurarFormularioPorNivel(int nivel)
        {
            switch (nivel)
            {
                case 1:
                    // Nível 1 (08:00)
                    this.Text = "1º AVISO: Análise dos banhos da linha de pintura";
                    this.labelAviso.Text = "Por favor solicitar a análise dos banhos da linha de pintura.";
                    this.btnConfirmar.Text = "Confirmar Manutenção Agora";
                    // Posição centralizada (temos só um botão)
                    this.btnConfirmar.Location = new System.Drawing.Point(128, 105);
                    this.btnConfirmar.Size = new System.Drawing.Size(226, 40);
                    break;

                case 2:
                    // Nível 2 (09:00)
                    this.Text = "2º AVISO: Análise dos banhos da linha de pintura";
                    this.labelAviso.Text = "As análises foram registadas?";
                    this.btnConfirmar.Text = "Sim"; // Botão "Sim"
                    AdicionarBotaoNao(); // Adiciona o botão "Não"
                    break;

                case 3:
                    // Nível 3 (09:30)
                    this.Text = "3º AVISO: Análise dos banhos da linha de pintura";
                    this.labelAviso.Text = "As análises foram registadas?";
                    this.btnConfirmar.Text = "Sim"; // Botão "Sim"
                    AdicionarBotaoNao(); // Adiciona o botão "Não"
                    break;

                case 4:
                    // Nível 4 (10:00) - Desligamento
                    this.Text = "AVISO URGENTE: Linha Desligada";
                    this.labelAviso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
                    this.labelAviso.ForeColor = System.Drawing.Color.Red; // Destaca a cor
                    this.labelAviso.Text = "Linha desligada por falta de análise.";

                    // --- MUDANÇA PRINCIPAL AQUI ---
                    // Agora o botão "Confirmar" continua visível
                    this.btnConfirmar.Visible = true;
                    this.btnConfirmar.Text = "Confirmar Manutenção Agora";

                    // Centralizamos o botão "Confirmar"
                    this.btnConfirmar.Location = new System.Drawing.Point(128, 105);
                    this.btnConfirmar.Size = new System.Drawing.Size(226, 40); // Tamanho original

                    // NÃO criamos mais o botão "OK" que só fechava
                    break;

                default:
                    this.Text = "Aviso de Manutenção";
                    this.labelAviso.Text = "Manutenção necessária.";
                    break;
            }
        }
        /// <summary>
        /// NOVO: Método para criar e adicionar o botão "Não"
        /// </summary>
        private void AdicionarBotaoNao()
        {
            this.btnNao = new System.Windows.Forms.Button();

            // Configurações do botão "Não"
            this.btnNao.Text = "Não";
            this.btnNao.Size = new System.Drawing.Size(110, 40);
            this.btnNao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79))))); // Cor vermelha
            this.btnNao.ForeColor = System.Drawing.Color.White;
            this.btnNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // Posição: Alinhado com o "Sim", mas à esquerda
            // O botão "Sim" (btnConfirmar) está em X=128, Y=105
            this.btnConfirmar.Location = new System.Drawing.Point(242, 105); // Move o "Sim" para a direita
            this.btnConfirmar.Size = new System.Drawing.Size(110, 40); // Diminui o "Sim"

            this.btnNao.Location = new System.Drawing.Point(128, 105); // Põe o "Não" à esquerda

            // Define o evento de clique para o "Não"
            this.btnNao.Click += new System.EventHandler(this.btnNao_Click);

            // Adiciona o botão ao formulário
            this.Controls.Add(this.btnNao);
        }

        /// <summary>
        /// NOVO: Evento de clique para o botão "Não"
        /// </summary>
        private void btnNao_Click(object sender, EventArgs e)
        {
            // Ação "Não": simplesmente fecha o formulário.
            // O aviso deverá aparecer novamente mais tarde.
            this.Close();
        }


        /// <summary>
        /// Evento disparado pelo clique no botão "Confirmar" (agora "Sim")
        /// </summary>
        /// <summary>
        /// Evento disparado pelo clique no botão "Confirmar" (ou "Sim")
        /// </summary>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica o nível do aviso (já guardado no construtor)
                // int nivelAtual = GestorManutencao.UltimoNivelAviso; // Já temos em this.nivelAvisoAtual

                string usuario = "Desconhecido";

                if (this.nivelAvisoAtual < 2)
                {
                    // Nível 1 → qualquer usuário pode confirmar
                    string cofgsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "cofgs.txt");
                    if (File.Exists(cofgsPath))
                    {
                        string[] linhas = File.ReadAllLines(cofgsPath);
                        if (linhas.Length > 0)
                            usuario = linhas[0].Trim();
                    }
                }
                else
                {
                    // Nível 2, 3 ou 4 → exige autenticação nível 3 (Admin)
                    // Isto cobre o "sim" (com login) ou "dispensado (só admin)"
                    FrmLoginManutencao frmLogin = new FrmLoginManutencao();
                    var resultado = frmLogin.ShowDialog();

                    if (resultado == DialogResult.OK && !string.IsNullOrEmpty(frmLogin.UsuarioConfirmado))
                    {
                        usuario = frmLogin.UsuarioConfirmado;
                    }
                    else
                    {
                        MessageBox.Show("Confirmação de manutenção cancelada ou inválida.",
                                        "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Sai sem salvar
                    }
                }

                // Salva manutenção com nome do usuário que confirmou
                // O GestorManutencao vai registar a nota e resetar os avisos.
                GestorManutencao.SalvarManutencaoAgora(usuario);

                MessageBox.Show($"Manutenção confirmada por '{usuario}'.",
                                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao confirmar manutenção: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }