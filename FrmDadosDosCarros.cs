using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Sharp7;
using System.Diagnostics;

namespace SupervisorioDana
{
	// Token: 0x0200000E RID: 14
	public partial class FrmDadosDosCarros : Form
	{
		// Token: 0x06000149 RID: 329 RVA: 0x00025EEC File Offset: 0x000240EC
		public FrmDadosDosCarros()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00025F95 File Offset: 0x00024195
		private void Form1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00025F98 File Offset: 0x00024198
		private void FrmDadosDosCarros_Shown(object sender, EventArgs e)
		{
			base.Hide();
			Carregando telatemp = new Carregando();
			telatemp.Show();
			this.leusuario();
			this.conexao();
			bool flag = this.conectado;
			if (flag)
			{
				this.metodosDeIncializacaodoForm();
			}
			telatemp.Hide();
			base.Show();
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00025FE4 File Offset: 0x000241E4
		private void metodosDeIncializacaodoForm()
		{
			this.leusuario();
			this.ListaIDAlarmes();
			this.LeNomeAlarmes();
			this.conexao();
			this.atualizaLista();
			this.VerificaStatus();
			this.ColetaAlarmesCLP();
			this.ConfereAlarmesAtivos();
			this.notificaalarmecarro();
			this.PreencheAtivos();
			this.AtualizaModo();
			this.AtualizaCarro();
			this.tempo = 0;
			this.tempo2 = 1000;
			this.timer1.Start();
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00026064 File Offset: 0x00024264
		private void leusuario()
		{
			string nacess = "ERRO"; // Valor padrão em caso de falha
			string caminhoDoArquivo = this.caminho + "/cofgs.txt";

			try
			{
				using (StreamReader sr = new StreamReader(caminhoDoArquivo))
				{
					sr.ReadLine(); // Lê a primeira linha (usuário)
					nacess = sr.ReadLine(); // Lê a SEGUNDA linha (nível)
					sr.Close();
				}

				int niveldeacess = int.Parse(nacess);
				this.niveldeacesso = niveldeacess;
				switch (niveldeacess)
				{
					case 1:
						this.nivelum();
						break;
					case 2:
						this.niveldois();
						break;
					case 3:
						this.niveltres();
						break;
					default:
						MessageBox.Show("Ocorreu um erro grave\n com relação a acessos\n por favor reinicie o sistema.");
						break;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Falha ao ler o 'cofgs.txt': {ex.Message}\nCaminho: {caminhoDoArquivo}", "ERRO FATAL DE LEITURA");
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00026110 File Offset: 0x00024310
		private void nivelum()
		{
			this.button2.Enabled = false;
			this.TBoxCodigoBarras.Enabled = false;
			this.TBoxCodigoPecas.Enabled = false;
			this.BtnConfiguracoes.Enabled = false;
            this.BtnConfiguracoes.BackColor = Color.FromArgb(9, 37, 60);
			this.btnEditarConfig.Enabled = false;
			this.btnEditarConfig.BackColor = Color.FromArgb(9, 37, 60);
			this.btnVerNotas.Enabled = false;
			this.btnVerNotas.BackColor = Color.FromArgb(9, 37, 60);
		}

        // Token: 0x0600014F RID: 335 RVA: 0x0002616C File Offset: 0x0002436C
        private void niveldois()
		{
			this.button2.Enabled = true;
			this.button2.BackColor = Color.FromArgb(68, 180, 74);
			this.TBoxCodigoBarras.Enabled = true;
			this.TBoxCodigoPecas.Enabled = true;
			this.BtnConfiguracoes.Enabled = false;
            this.BtnConfiguracoes.BackColor = Color.FromArgb(9, 37, 60);
			this.btnEditarConfig.Enabled = false;
			this.btnEditarConfig.BackColor = Color.FromArgb(9, 37, 60);
			this.btnVerNotas.Enabled = false;
			this.btnVerNotas.BackColor = Color.FromArgb(9, 37, 60);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000261E0 File Offset: 0x000243E0
		// Token: 0x06000150 RID: 336 RVA: 0x000261E0 File Offset: 0x000243E0

		private void niveltres()
		{


			this.button2.Enabled = true;
			this.button2.BackColor = Color.FromArgb(68, 180, 74);
			this.TBoxCodigoBarras.Enabled = true;
			this.TBoxCodigoPecas.Enabled = true;
			this.BtnConfiguracoes.Enabled = true;
			this.BtnConfiguracoes.BackColor = Color.FromArgb(68, 180, 74);
			this.BtnAtualizarCarro.BackColor = Color.FromArgb(68, 180, 74);
			this.BtnAtualizarCarro.Enabled = true;
			this.TBoxAtualizaCarro.Enabled = true;

			// --- ESTE É O CÓDIGO QUE ATIVA TUDO ---
			// Ativa o "Recarregar"
			this.button1.Enabled = true;
			this.button1.BackColor = Color.FromArgb(68, 180, 74);

			// Ativa o "Editar Horários"
			this.btnEditarConfig.Enabled = true;
			this.btnEditarConfig.BackColor = Color.FromArgb(68, 180, 74);

			// Ativa o "Ver Notas Manut."
			this.btnVerNotas.Enabled = true;
			this.btnVerNotas.BackColor = Color.FromArgb(68, 180, 74);
		}
		// Token: 0x06000151 RID: 337 RVA: 0x0002628C File Offset: 0x0002448C
		private void ListaIDAlarmes()
		{
			for (int i = 0; i < 48; i++)
			{
				this.AlarmesAtivos[i].id = i;
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000262C0 File Offset: 0x000244C0
		private void LeNomeAlarmes()
		{
			int contador = 0;
			string arquivo = this.caminho + "/Alarmes.txt";
			bool flag = File.Exists(arquivo);
			if (flag)
			{
				try
				{
					using (StreamReader sr = new StreamReader(arquivo))
					{
						string linha;
						while ((linha = sr.ReadLine()) != null)
						{
							this.AlarmesAtivos[contador].nalarme = linha;
							this.AlarmesAtivos[contador].LigadoA = false;
							contador++;
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			else
			{
				this.NomeAlarmeNEncontrado();
				this.LeNomeAlarmes();
				MessageBox.Show("Nome dos alarmes não encontrado");
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00026394 File Offset: 0x00024594
		private void NomeAlarmeNEncontrado()
		{
			StreamWriter x = File.CreateText(this.caminho + "/Alarmes.txt");
			x.Close();
			using (StreamWriter y = new StreamWriter(this.caminho + "/Alarmes.txt"))
			{
				y.WriteLine("SEGURANÇA GERAL");
				y.WriteLine("SEGURANÇA TRANSPORTADOR");
				y.WriteLine("FALHA M1 INVERSOR TRANSPORTADOR");
				y.WriteLine("FALHA M2 SOFT STARTER");
				y.WriteLine("FALHA M3 SOFT STARTER");
				y.WriteLine("FALHA M4 DISJUNTOR MOTOR");
				y.WriteLine("FALHA M5 DISJUNTOR MOTOR");
				y.WriteLine("FALHA M6 SOFT STARTER");
				y.WriteLine("FALHA M7 SOFT STARTER");
				y.WriteLine("FALHA M8 SOFT STARTER");
				y.WriteLine("FALHA M9 DISJUNTOR MOTOR");
				y.WriteLine("FALHA M10 SOFT STARTER");
				y.WriteLine("FALHA M11 DISJUNTOR MOTOR");
				y.WriteLine("FALHA M12 DISJUNTOR MOTOR");
				y.WriteLine("FALHA M13 DISJUNTOR MOTOR");
				y.WriteLine("FALHA M14 DISJUNTOR MOTOR");
				y.WriteLine("FALHA M15 DISJUNTOR MOTOR");
				y.WriteLine("FALHA M16 DISJUNTOR MOTOR");
				y.WriteLine("FALHA M17 DISJUNTOR MOTOR");
				y.WriteLine("FALHA M18 DISJUNTOR MOTOR");
				y.WriteLine("FALHA M19 SOFT STARTER");
				y.WriteLine("FALHA M20 SOFT STARTER");
				y.WriteLine("FALHA M21 DISJUNTOR MOTOR");
				y.WriteLine("FALHA M22 DISJUNTOR MOTOR");
				y.WriteLine("FALHA M23 INVERSOR GIRADOR");
				y.WriteLine("FALHA M24 DISJUNTOR MOTOR");
				y.WriteLine("FALHA M25 DISJUNTOR MOTOR");
				y.WriteLine("FALHA M26 DISJUNTOR MOTOR");
				y.WriteLine("FALHA M27 DISJUNTOR MOTOR");
				y.WriteLine("FALHA M28 DISJUNTOR MOTOR");
				y.WriteLine("FALHA M29 DISJUNTOR MOTOR");
				y.WriteLine("FALHA M30 DISJUNTOR MOTOR");
				y.WriteLine("FALHA M31 DISJUNTOR MOTOR");
				y.WriteLine("FALHA M32 DISJUNTOR MOTOR");
				y.WriteLine("FALHA M33 DISJUNTOR MOTOR");
				y.WriteLine("FALHA M34 DISJUNTOR MOTOR");
				y.WriteLine("PARADA");
				y.WriteLine("ALARME CARRO ERRADO");
				y.WriteLine("ALARME TIMEOUT DOS SENSORES");
				y.WriteLine("CARRO NÃO IDENTIFICADO");
				y.WriteLine("SENSORES OBSTRUÍDOS");
				y.WriteLine("RESERVA_6");
				y.WriteLine("TEMPERATURA BAIXA");
				y.WriteLine("RESERVA_8");
				y.WriteLine("RESERVA_9");
				y.WriteLine("RESERVA_10");
				y.WriteLine("RESERVA_11");
				y.WriteLine("RESERVA_12");
				y.Close();
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00026648 File Offset: 0x00024848
		public void conexao()
		{
			int chamado_limite = 0;
			int verifica_conexao;
			do
			{
				verifica_conexao = this.plc.ConnectTo("192.168.0.1", 0, 1);
				chamado_limite++;
			}
			while (verifica_conexao != 0 && chamado_limite != 2);
			bool flag = verifica_conexao == 0;
			if (flag)
			{
				this.Comunicacao.Text = "Comunicação: OK";
				this.conectado = true;
			}
			else
			{
				bool flag2 = chamado_limite == 2;
				if (flag2)
				{
					this.Comunicacao.Text = "Comunicação: Desconectado (1)";
					this.conectado = false;
				}
				else
				{
					this.Comunicacao.Text = "Comunicação: Desconectado (2)";
					this.conectado = false;
				}
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000266E8 File Offset: 0x000248E8
		public void atualizaLista()
		{
			string[] coluna = new string[7];
			byte[] bufferRead = new byte[3102];
			this.plc.DBRead(20, 0, bufferRead.Length, bufferRead);
			for (int i = 0; i < 33; i++)
			{
				int nDadoDBcorrente = i * 94;
				this.carro[i].IdCarro = bufferRead.GetIntAt(nDadoDBcorrente);
				this.carro[i].PosicaoCarro = (double)bufferRead.GetRealAt(2 + nDadoDBcorrente);
				this.carro[i].QuantidadeCarro = bufferRead.GetIntAt(8 + nDadoDBcorrente);
				this.carro[i].DescricaoProduto = bufferRead.GetStringAt(10 + nDadoDBcorrente);
				this.carro[i].CodigoModeloProduto = bufferRead.GetStringAt(38 + nDadoDBcorrente);
				this.carro[i].NomeDaReceita = bufferRead.GetStringAt(60 + nDadoDBcorrente);
			}
			this.limpaformulario();
			for (int j = 0; j < 33; j++)
			{
				coluna[0] = Convert.ToString(this.carro[j].IdCarro);
				double v = this.carro[j].PosicaoCarro;
				v = Math.Round(v, 1);
				coluna[1] = Convert.ToString(v);
				coluna[2] = this.selecionasetor(v);
				coluna[3] = Convert.ToString(this.carro[j].DescricaoProduto);
				coluna[5] = Convert.ToString(this.carro[j].CodigoModeloProduto);
				coluna[6] = Convert.ToString(this.carro[j].QuantidadeCarro);
				coluna[4] = Convert.ToString(this.carro[j].NomeDaReceita);
				bool flag = v <= 6.0 || v >= 95.0;
				if (flag)
				{
					this.carro[j].carregavel = true;
				}
				else
				{
					this.carro[j].carregavel = false;
				}
				ListViewItem I = new ListViewItem(coluna);
				this.ListaDadosCarros.Items.Add(I);
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00026924 File Offset: 0x00024B24
		private void VerificaStatus()
		{
			this.conexao();
			byte[] bufferRead = new byte[4];
			this.plc.DBRead(19, 0, bufferRead.Length, bufferRead);
			int nDadoDBcorrente = 0;
			this.Status.ultCarRef = bufferRead.GetIntAt(nDadoDBcorrente);
			this.Status.AutoOn = bufferRead.GetBitAt(2, 0);
			this.Status.ModoDesligado = bufferRead.GetBitAt(2, 1);
			this.Status.ModoManual = bufferRead.GetBitAt(2, 2);
			this.Status.ModoAutomatico = bufferRead.GetBitAt(2, 3);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000269B4 File Offset: 0x00024BB4
		private void ColetaAlarmesCLP()
		{
			this.conexao();
			int nDadoDBcorrente = 0;
			int contadordebit = 0;
			byte[] bufferRead = new byte[6];
			this.plc.DBRead(1, 0, bufferRead.Length, bufferRead);
			for (int i = 0; i < 48; i++)
			{
				this.AlarmesAtivos[i].estado = bufferRead.GetBitAt(nDadoDBcorrente, contadordebit);
				bool flag = contadordebit < 7;
				if (flag)
				{
					contadordebit++;
				}
				else
				{
					contadordebit = 0;
					nDadoDBcorrente++;
				}
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00026A30 File Offset: 0x00024C30
		private void ConfereAlarmesAtivos()
		{
			for (int i = 0; i < 48; i++)
			{
				bool estado = this.AlarmesAtivos[i].estado;
				if (estado)
				{
					bool flag = !this.AlarmesAtivos[i].LigadoA;
					if (flag)
					{
						this.AlarmesAtivos[i].LigadoA = true;
						this.AlarmesAtivos[i].data = Convert.ToString(DateTime.Now);
					}
				}
				else
				{
					bool flag2 = !this.AlarmesAtivos[i].estado;
					if (flag2)
					{
						this.AlarmesAtivos[i].LigadoA = false;
					}
				}
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00026AE8 File Offset: 0x00024CE8
		private void notificaalarmecarro()
		{
			bool flag = this.AlarmesAtivos[36].estado || this.AlarmesAtivos[37].estado || this.AlarmesAtivos[38].estado || this.AlarmesAtivos[40].estado;
			if (flag)
			{
				bool flag2 = this.tempo2 > 1000;
				if (flag2)
				{
					bool estado = this.AlarmesAtivos[36].estado;
					if (estado)
					{
					}
					bool flag3 = this.AlarmesAtivos[37].estado || this.AlarmesAtivos[38].estado || this.AlarmesAtivos[40].estado;
					if (flag3)
					{
					}
					this.tempo2 = 0;
				}
			}
			bool flag4 = this.AlarmesAtivos[37].estado || this.AlarmesAtivos[38].estado || this.AlarmesAtivos[40].estado;
			if (flag4)
			{
				this.AlarmeCarroErrado = true;
			}
			else
			{
				this.AlarmeCarroErrado = false;
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00026C1C File Offset: 0x00024E1C
		private void AtualizaCarro()
		{
			bool flag = !this.AlarmeCarroErrado;
			if (flag)
			{
				this.LabelUltCarro.Text = "último carro: " + Convert.ToString(this.Status.ultCarRef);
				this.CarroCerto();
			}
			else
			{
				bool alarmeCarroErrado = this.AlarmeCarroErrado;
				if (alarmeCarroErrado)
				{
					this.LabelUltCarro.Text = "Carro Incorreto, Corrija para o carro correto";
					this.CarroErrado();
				}
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00026C8C File Offset: 0x00024E8C
		private void CarroCerto()
		{
			bool flag = this.niveldeacesso < 2;
			if (flag)
			{
				this.TBoxAtualizaCarro.Enabled = false;
				this.BtnAtualizarCarro.Enabled = false;
				this.TBoxAtualizaCarro.Text = "";
				this.BtnAtualizarCarro.ForeColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				this.TBoxAtualizaCarro.Enabled = true;
				this.BtnAtualizarCarro.Enabled = true;
				this.BtnAtualizarCarro.BackColor = Color.FromArgb(68, 180, 74);
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00026D24 File Offset: 0x00024F24
		private void CarroErrado()
		{
			bool flag = this.niveldeacesso > 1;
			if (flag)
			{
				this.TBoxAtualizaCarro.Enabled = true;
				this.BtnAtualizarCarro.Enabled = true;
				this.BtnAtualizarCarro.BackColor = Color.FromArgb(68, 180, 74);
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00026D78 File Offset: 0x00024F78
		private void BtnAtualizarCarro_Click(object sender, EventArgs e)
		{
			this.conexao();
			short carrocerto = short.Parse(this.TBoxAtualizaCarro.Text);
			byte[] bufferRead = new byte[4];
			this.plc.DBRead(19, 0, bufferRead.Length, bufferRead);
			bufferRead.SetIntAt(0, carrocerto);
			this.plc.DBWrite(19, 0, bufferRead.Length, bufferRead);
			this.pedeparaclpatualizarcarro();
			this.VerificaStatus();
			this.AtualizaCarro();
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00026DEC File Offset: 0x00024FEC
		private void pedeparaclpatualizarcarro()
		{
			this.conexao();
			bool ligabitcarro = true;
			byte[] bufferRead = new byte[2];
			this.plc.DBRead(26, 0, bufferRead.Length, bufferRead);
			bufferRead.SetBitAt(0, 3, ligabitcarro);
			this.plc.DBWrite(26, 0, bufferRead.Length, bufferRead);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00026E3C File Offset: 0x0002503C

		// Token: 0x06000088 RID: 136 RVA: 0x0000BD5C File Offset: 0x00009F5C
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.tempo++;
			bool flag = this.tempo >= 200;
			if (flag)
			{
				this.tempo2++;
				this.tempo = 0;

				try
				{
					this.metodosciclicos();
				}
				catch (Exception ex)
				{
					this.conectado = false;
					this.Comunicacao.Text = "Comunicação: Falha (TICK)";
				}

				// --- LÓGICA DE MANUTENÇÃO FINAL ---

				// Pede ao "cérebro" o status
				int nivelDisparo = GestorManutencao.VerificarManutencaoPendente();
				int nivelAtual = GestorManutencao.UltimoNivelAviso;

				// Atualiza o Label (assumindo que LblStatusManutencao existe em ambos)
				if (nivelAtual > 0)
				{
					this.LblStatusManutencao.Text = "Manutenção: PENDENTE";
					this.LblStatusManutencao.ForeColor = Color.Tomato;
				}
				else
				{
					this.LblStatusManutencao.Text = "Manutenção: OK";
					this.LblStatusManutencao.ForeColor = Color.FromArgb(68, 180, 74);
				}

				// Lógica de Alarme e Desligamento
				if (nivelAtual == 4)
				{
					// Nível 4 está ativo
					this.AcionarAlarmeAudivelManutencao(true);

					// Pegue o timestamp de início do "cérebro" (GestorManutencao)
					DateTime? inicioAlarme = GestorManutencao.HoraNivel4Disparou;

					// VERIFIQUE A CARÊNCIA DE 10 MINUTOS
					if (inicioAlarme.HasValue && DateTime.Now > inicioAlarme.Value.AddMinutes(10))
					{
						// Tempo esgotado, desliga a máquina
						this.EscreveCLPMADesligado();
					}
				}
				else
				{
					// ESTADO 0-3: Garanta que o alarme sonoro esteja DESLIGADO
					this.AcionarAlarmeAudivelManutencao(false);
				}

				// Lógica de Pop-up (só dispara no *momento* da transição)
				if (nivelDisparo > 0)
				{
					if (frmAvisoAtual != null && !frmAvisoAtual.IsDisposed)
					{
						frmAvisoAtual.Close();
					}
					frmAvisoAtual = new FrmAvisoManutencao();
					frmAvisoAtual.Show(this);
				}
				// --- FIM DA LÓGICA ---
			}
		}
		// Token: 0x06000160 RID: 352 RVA: 0x00026E8C File Offset: 0x0002508C
		private void metodosciclicos()
		{
			this.conexao();
			this.atualizaLista();
			this.VerificaStatus();
			this.ColetaAlarmesCLP();
			this.ConfereAlarmesAtivos();
			this.notificaalarmecarro();
			this.PreencheAtivos();
			this.AtualizaModo();
			this.AtualizaCarro();
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00026EDC File Offset: 0x000250DC
		private void BtnCadastro_Click(object sender, EventArgs e)
		{
			this.timer1.Stop();
			base.Hide();
			FrmCadastro frmCadastro = new FrmCadastro();
			frmCadastro.ShowDialog();
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00026F0C File Offset: 0x0002510C
		private void BtnAlarme_Click(object sender, EventArgs e)
		{
			this.timer1.Stop();
			base.Hide();
			FrmAlarmes frmAlarmes = new FrmAlarmes();
			frmAlarmes.ShowDialog();
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00026F3C File Offset: 0x0002513C
		private void button2_Click(object sender, EventArgs e)
		{
			bool flag = this.TBoxCodigoBarras.Text == "" || this.TBoxCodigoBarras.Text == null || this.TBoxCodigoPecas.Text == "" || this.TBoxCodigoPecas.Text == null;
			if (flag)
			{
				MessageBox.Show("Texto do Codigo de Barras ou da Quantidade Vazio");
			}
			else
			{
				string st = this.TBoxCodigoPecas.Text;
				bool valido = true;
				for (int i = 0; i < st.Length; i++)
				{
					int v = Convert.ToInt32(st[i]);
					bool flag2 = v >= 48 && v <= 57;
					if (!flag2)
					{
						valido = false;
					}
				}
				bool flag3 = !valido;
				if (flag3)
				{
					MessageBox.Show("Texto da Quantidade Invalido");
				}
				else
				{
					this.Verificapermicao();
				}
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00027024 File Offset: 0x00025224
		private void Verificapermicao()
		{
			bool flag = !this.Carrobuffer.carregavel;
			if (flag)
			{
				bool flag2 = this.niveldeacesso < 3;
				if (flag2)
				{
					bool flag3 = !this.permissao;
					if (flag3)
					{
						MessageBox.Show("Carro selecionado fora da área de carga.\nCarga habilitada somente para supervisor.");
						this.permissao = false;
					}
					else
					{
						this.AtualizaCLPCarroCarregado();
					}
				}
				else
				{
					this.AtualizaCLPCarroCarregado();
				}
			}
			else
			{
				this.AtualizaCLPCarroCarregado();
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00027098 File Offset: 0x00025298
		private void AtualizaCLPCarroCarregado()
		{
			this.conexao();
			int nDadoDBcorrente = 0;
			byte[] bufferRead = new byte[106];
			string codigoBarras = this.TBoxCodigoBarras.Text;
			codigoBarras = codigoBarras.ToUpper();
			short pecas = short.Parse(this.TBoxCodigoPecas.Text);
			int bufferindice = int.Parse(this.Carrobuffer.indice);
			short bufferid = short.Parse(this.Carrobuffer.id);
			this.plc.DBRead(23, 0, bufferRead.Length, bufferRead);
			bufferRead.SetIntAt(nDadoDBcorrente, bufferid);
			bufferRead.SetIntAt(nDadoDBcorrente + 2, pecas);
			bufferRead.SetStringAt(nDadoDBcorrente + 4, 15, codigoBarras);
			this.plc.DBWrite(23, 0, bufferRead.Length, bufferRead);
			int carregadook = this.confereCLPCArregado();
			bool flag = carregadook == 0;
			if (flag)
			{
				this.atualizaLista();
				this.atualizacarregado();
			}
			else
			{
				bool flag2 = carregadook == 1;
				if (flag2)
				{
					MessageBox.Show("O Carro não foi carregado corretamente");
				}
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0002718C File Offset: 0x0002538C
		private int confereCLPCArregado()
		{
			int carregadook = 1;
			this.conexao();
			byte[] bufferRead = new byte[106];
			this.plc.DBRead(23, 0, bufferRead.Length, bufferRead);
			bool scarregado = bufferRead.GetBitAt(21, 0);
			bool flag = scarregado;
			if (flag)
			{
				carregadook = 1;
			}
			else
			{
				bool flag2 = !scarregado;
				if (flag2)
				{
					carregadook = 0;
				}
			}
			return carregadook;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000271E8 File Offset: 0x000253E8
		private void button3_Click(object sender, EventArgs e)
		{
			this.metodosciclicos();
			this.timer1.Start();
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000271FE File Offset: 0x000253FE
		private void ListaDadosCarros_MouseEnter(object sender, EventArgs e)
		{
			this.timer1.Stop();
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0002720D File Offset: 0x0002540D
		private void ListaDadosCarros_MouseLeave(object sender, EventArgs e)
		{
			this.timer1.Start();
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0002721C File Offset: 0x0002541C
		private string selecionasetor(double v)
		{
			string setor = "";
			bool flag = v <= 43.0;
			if (flag)
			{
				bool flag2 = v >= 0.0 && v <= 5.0;
				if (flag2)
				{
					setor = "Carga";
				}
				else
				{
					bool flag3 = v > 5.0 && v <= 12.0;
					if (flag3)
					{
						setor = "Desengraxante";
					}
					else
					{
						bool flag4 = v > 12.0 && v <= 17.0;
						if (flag4)
						{
							setor = "Enxágue";
						}
						else
						{
							bool flag5 = v > 17.0 && v <= 20.0;
							if (flag5)
							{
								setor = "Fosfatizante";
							}
							else
							{
								bool flag6 = v > 20.0 && v <= 26.0;
								if (flag6)
								{
									setor = "Enxágue";
								}
								else
								{
									bool flag7 = v > 26.0 && v <= 34.0;
									if (flag7)
									{
										setor = "Soprador";
									}
									else
									{
										bool flag8 = v > 34.0 && v <= 43.0;
										if (flag8)
										{
											setor = "Estufa de secagem";
										}
									}
								}
							}
						}
					}
				}
			}
			else
			{
				bool flag9 = v > 43.0 && v <= 47.0;
				if (flag9)
				{
					setor = "Mascaramento";
				}
				else
				{
					bool flag10 = v > 47.0 && v <= 55.0;
					if (flag10)
					{
						setor = "Pintura";
					}
					else
					{
						bool flag11 = v > 55.0 && v <= 58.0;
						if (flag11)
						{
							setor = "Flash-off";
						}
						else
						{
							bool flag12 = v > 58.0 && v <= 74.0;
							if (flag12)
							{
								setor = "Estufa de cura";
							}
							else
							{
								bool flag13 = v > 74.0 && v <= 78.0;
								if (flag13)
								{
									setor = "Resfriador";
								}
								else
								{
									bool flag14 = v > 78.0 && v <= 95.0;
									if (flag14)
									{
										setor = "Descarga";
									}
									else
									{
										bool flag15 = v > 95.0 && v <= 123.0;
										if (flag15)
										{
											setor = "Carga";
										}
									}
								}
							}
						}
					}
				}
			}
			return setor;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000274F0 File Offset: 0x000256F0
		private void ListaDadosCarros_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.ListaDadosCarros.SelectedItems.Count > 0;
			if (flag)
			{
				this.Carrobuffer.indice = this.ListaDadosCarros.SelectedIndices[0].ToString();
				this.Carrobuffer.id = this.ListaDadosCarros.SelectedItems[0].SubItems[0].Text;
				this.Carrobuffer.posicao = this.ListaDadosCarros.SelectedItems[0].SubItems[1].Text;
				this.Carrobuffer.setor = this.ListaDadosCarros.SelectedItems[0].SubItems[2].Text;
				this.Carrobuffer.produto = this.ListaDadosCarros.SelectedItems[0].SubItems[3].Text;
				this.Carrobuffer.NomeDaReceita = this.ListaDadosCarros.SelectedItems[0].SubItems[4].Text;
				this.Carrobuffer.codigo = this.ListaDadosCarros.SelectedItems[0].SubItems[5].Text;
				this.Carrobuffer.quantidade = this.ListaDadosCarros.SelectedItems[0].SubItems[6].Text;
				this.Carrobuffer.carregavel = this.carro[int.Parse(this.Carrobuffer.indice)].carregavel;
			}
			bool flag2 = this.niveldeacesso > 1;
			if (flag2)
			{
				this.LabBufferID.Text = "ID: " + this.Carrobuffer.id;
				this.LabBufferPosicao.Text = "Posição: " + this.Carrobuffer.posicao;
				this.LabBufferSetor.Text = "Setor: " + this.Carrobuffer.setor;
				this.LabBufferProduto.Text = "Produto: " + this.Carrobuffer.produto;
				this.LabBufferReceita.Text = "Receita: " + this.Carrobuffer.NomeDaReceita;
				this.LabBufferCodigo.Text = "Codigo: " + this.Carrobuffer.codigo;
				this.LabBufferQuantidade.Text = "Quantidade: " + this.Carrobuffer.quantidade;
				bool flag3 = this.niveldeacesso < 3 && !this.Carrobuffer.carregavel;
				if (flag3)
				{
					this.LabAviso.Text = "Carro fora da área de carga";
				}
				else
				{
					this.LabAviso.Text = "";
				}
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000277DC File Offset: 0x000259DC
		public void limpaformulario()
		{
			this.ListaDadosCarros.Items.Clear();
		}

		// Token: 0x0600016D RID: 365 RVA: 0x000277F0 File Offset: 0x000259F0
		private void atualizacarregado()
		{
			int indice = int.Parse(this.Carrobuffer.indice);
			this.LabCBufferID.Text = "ID: " + this.ListaDadosCarros.Items[indice].SubItems[0].Text;
			this.LabCBufferPosicao.Text = "Posição: " + this.ListaDadosCarros.Items[indice].SubItems[1].Text;
			this.LabCBufferSetor.Text = "Setor: " + this.ListaDadosCarros.Items[indice].SubItems[2].Text;
			this.LabCBufferProduto.Text = "Produto: " + this.ListaDadosCarros.Items[indice].SubItems[3].Text;
			this.LabCBufferReceita.Text = "Receita: " + this.ListaDadosCarros.Items[indice].SubItems[4].Text;
			this.LabCBufferCodigo.Text = "Codigo: " + this.ListaDadosCarros.Items[indice].SubItems[5].Text;
			this.LabCBufferQuantidade.Text = "Quantidade: " + this.ListaDadosCarros.Items[indice].SubItems[6].Text;
			this.correcaodepontoevirgula();
			this.GerenciaRegistroCarregados();
			this.GerenciaContadordeProducao();
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000279A8 File Offset: 0x00025BA8
		private void correcaodepontoevirgula()
		{
			string copia = "";
			int indice = int.Parse(this.Carrobuffer.indice);
			this.correcaocodigo = this.ListaDadosCarros.Items[indice].SubItems[5].Text;
			this.correcaocodigo = this.correcaocodigo.ToUpper();
			for (int i = 0; i < this.correcaocodigo.Length; i++)
			{
				char a = this.correcaocodigo[i];
				bool flag = a == ';';
				if (flag)
				{
					a = '/';
				}
				copia += a.ToString();
			}
			this.correcaocodigo = copia;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00027A58 File Offset: 0x00025C58
		private void GerenciaRegistroCarregados()
		{
			string arquivo = this.caminho + "/Registros.txt";
			int indice = int.Parse(this.Carrobuffer.indice);
			bool flag = File.Exists(arquivo);
			if (flag)
			{
				try
				{
					StringBuilder container = new StringBuilder();
					using (StreamReader re = File.OpenText(arquivo))
					{
						container.Append(re.ReadToEnd());
					}
					bool flag2 = File.Exists(arquivo);
					if (flag2)
					{
						File.Delete(arquivo);
					}
					FileInfo t = new FileInfo(arquivo);
					using (StreamWriter Tex = t.CreateText())
					{
						DateTime data = DateTime.Now;
						this.Carrobuffer.ano = Convert.ToString(data.Year);
						this.Carrobuffer.mes = Convert.ToString(data.Month);
						this.Carrobuffer.dia = Convert.ToString(data.Day);
						this.Carrobuffer.hora = Convert.ToString(data.Hour);
						this.Carrobuffer.minuto = Convert.ToString(data.Minute);
						this.Carrobuffer.segundo = Convert.ToString(data.Second);
						this.Carrobuffer.data = string.Concat(new string[]
						{
							this.Carrobuffer.ano,
							":",
							this.Carrobuffer.mes,
							":",
							this.Carrobuffer.dia
						});
						this.Carrobuffer.horario = string.Concat(new string[]
						{
							this.Carrobuffer.hora,
							":",
							this.Carrobuffer.minuto,
							":",
							this.Carrobuffer.segundo
						});
						Tex.Write(Convert.ToString(this.Carrobuffer.data) + ";");
						Tex.Write(Convert.ToString(this.Carrobuffer.horario) + ";");
						Tex.Write(this.ListaDadosCarros.Items[indice].SubItems[0].Text + ";");
						Tex.Write(this.ListaDadosCarros.Items[indice].SubItems[3].Text + ";");
						Tex.Write(this.correcaocodigo + ";");
						Tex.WriteLine(this.ListaDadosCarros.Items[indice].SubItems[6].Text + ";");
						Tex.WriteLine(container.ToString());
						Tex.Write(Tex.NewLine);
					}
				}
				catch (Exception ex)
				{
				}
			}
			else
			{
				this.CriaRegistro();
				this.GerenciaRegistroCarregados();
				MessageBox.Show("Arquivo de Registro, não encontrado.\nArquivo Criado com sucesso");
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00027DB0 File Offset: 0x00025FB0
		private void CriaRegistro()
		{
			StreamWriter x = File.CreateText(this.caminho + "/Registros.txt");
			x.Close();
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00027DDC File Offset: 0x00025FDC
		private void GerenciaContadordeProducao()
		{
			string arquivo = this.caminho + "/Contadores.txt";
			int count = 0;
			int contador = 0;
			bool flag = false;
			string v = "";
			string v2 = "";
			string v3 = "";
			bool flag2 = File.Exists(arquivo);
			if (flag2)
			{
				try
				{
					using (StreamReader sr = new StreamReader(arquivo))
					{
						string linha;
						while ((linha = sr.ReadLine()) != null)
						{
							while (!flag)
							{
								bool flag3 = linha[count] == ';';
								if (flag3)
								{
									flag = true;
								}
								else
								{
									v += linha[count].ToString();
								}
								count++;
							}
							this.Contadores[contador].DescricaoDoProduto = v;
							flag = false;
							while (!flag)
							{
								bool flag4 = linha[count] == ';';
								if (flag4)
								{
									flag = true;
								}
								else
								{
									v2 += linha[count].ToString();
								}
								count++;
							}
							this.Contadores[contador].CodigoDoProduto = v2;
							flag = false;
							while (!flag)
							{
								bool flag5 = linha[count] == ';';
								if (flag5)
								{
									flag = true;
								}
								else
								{
									v3 += linha[count].ToString();
								}
								count++;
							}
							this.Contadores[contador].QuantidadeAcumulada = int.Parse(v3);
							contador++;
							v = "";
							v2 = "";
							v3 = "";
							flag = false;
							count = 0;
						}
						bool flag6 = contador > 1000;
						if (flag6)
						{
							MessageBox.Show("limite maximo de Contadores estourado,\n por favor mova os Contadores de lugar,\n e reinicie o sistema");
						}
						sr.Close();
					}
				}
				catch (Exception ex)
				{
				}
			}
			else
			{
				this.CriaContador();
				this.GerenciaContadordeProducao();
				MessageBox.Show("Arquivo de Contadores, não encontrado.\nArquivo Criado com sucesso");
			}
			this.lecontadoresproducao(contador);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00028018 File Offset: 0x00026218
		private void lecontadoresproducao(int contador)
		{
			int indice = int.Parse(this.Carrobuffer.indice);
			bool produtoencontrado = false;
			for (int i = 0; i < contador; i++)
			{
				bool flag = this.Contadores[i].CodigoDoProduto == this.correcaocodigo;
				if (flag)
				{
					this.Contadores[i].QuantidadeAcumulada = this.Contadores[i].QuantidadeAcumulada + int.Parse(this.ListaDadosCarros.Items[indice].SubItems[6].Text);
					produtoencontrado = true;
				}
			}
			bool flag2 = !produtoencontrado;
			if (flag2)
			{
				string arquivo = this.caminho;
				bool flag3 = !File.Exists(arquivo + "/Contadores.txt");
				if (flag3)
				{
					throw new FileNotFoundException("Arquivo " + arquivo + "/Contadores.txt não encontrado");
				}
				StringBuilder container = new StringBuilder();
				using (StreamReader re = File.OpenText(arquivo + "/Contadores.txt"))
				{
					container.Append(re.ReadToEnd());
				}
				bool flag4 = File.Exists(arquivo + "/Contadores.txt");
				if (flag4)
				{
					File.Delete(arquivo + "/Contadores.txt");
				}
				string decricao = this.ListaDadosCarros.Items[indice].SubItems[3].Text;
				string codigo = this.correcaocodigo;
				string quantidade = this.ListaDadosCarros.Items[indice].SubItems[6].Text;
				FileInfo t = new FileInfo(arquivo + "/Contadores.txt");
				using (StreamWriter Tex = t.CreateText())
				{
					Tex.Write(decricao + ";");
					Tex.Write(codigo + ";");
					Tex.WriteLine(quantidade + ";");
					bool flag5 = contador > 0;
					if (flag5)
					{
						Tex.WriteLine(container.ToString());
						Tex.Write(Tex.NewLine);
					}
				}
			}
			else
			{
				string arquivo2 = this.caminho;
				bool flag6 = File.Exists(arquivo2 + "/Contadores.txt");
				if (flag6)
				{
					File.Delete(arquivo2 + "/Contadores.txt");
				}
				FileInfo t2 = new FileInfo(arquivo2 + "/Contadores.txt");
				using (StreamWriter Tex2 = t2.CreateText())
				{
					string decricao = this.ListaDadosCarros.Items[indice].SubItems[3].Text;
					string codigo = this.correcaocodigo;
					string quantidade = this.ListaDadosCarros.Items[indice].SubItems[6].Text;
					for (int j = 0; j < contador; j++)
					{
						Tex2.Write(this.Contadores[j].DescricaoDoProduto + ";");
						Tex2.Write(this.Contadores[j].CodigoDoProduto + ";");
						Tex2.WriteLine(this.Contadores[j].QuantidadeAcumulada.ToString() + ";");
					}
					Tex2.Write(Tex2.NewLine);
				}
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000283C4 File Offset: 0x000265C4
		private void CriaContador()
		{
			StreamWriter x = File.CreateText(this.caminho + "/Contadores.txt");
			x.Close();
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000283F0 File Offset: 0x000265F0
		public void AtualizaModo()
		{
			bool flag = !this.Status.ModoDesligado && !this.Status.ModoManual && this.Status.ModoAutomatico;
			if (flag)
			{
				this.ModoAutomatico();
			}
			else
			{
				bool flag2 = this.Status.ModoDesligado && !this.Status.ModoManual && !this.Status.ModoAutomatico;
				if (flag2)
				{
					this.ModoDesligado();
				}
				else
				{
					bool flag3 = !this.Status.ModoDesligado && this.Status.ModoManual && !this.Status.ModoAutomatico;
					if (flag3)
					{
						this.ModoManual();
					}
					else
					{
						this.TxtModo.Text = "Modo de operação: Erro";
						this.BtnAutoDesligado.Enabled = false;
						this.BtnAutoLigado.Enabled = false;
						this.BtnAutoDesligado.BackColor = Color.FromArgb(56, 79, 97);
						this.BtnAutoLigado.BackColor = Color.FromArgb(56, 79, 97);
					}
				}
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0002850C File Offset: 0x0002670C
		private void ModoDesligado()
		{
			this.TxtModo.Text = "Modo de operação: Desligado";
			this.BtnAutoDesligado.Enabled = false;
			this.BtnAutoLigado.Enabled = false;
			this.BtnAutoDesligado.BackColor = Color.FromArgb(56, 79, 97);
			this.BtnAutoLigado.BackColor = Color.FromArgb(56, 79, 97);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00028574 File Offset: 0x00026774
		private void ModoManual()
		{
			this.TxtModo.Text = "Modo de operação: Manual";
			this.BtnAutoDesligado.Enabled = false;
			this.BtnAutoLigado.Enabled = false;
			this.BtnAutoDesligado.BackColor = Color.FromArgb(56, 79, 97);
			this.BtnAutoLigado.BackColor = Color.FromArgb(56, 79, 97);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000285DC File Offset: 0x000267DC
		private void ModoAutomatico()
		{
			bool autoOn = this.Status.AutoOn;
			if (autoOn)
			{
				this.MALiagado();
			}
			else
			{
				bool flag = !this.Status.AutoOn;
				if (flag)
				{
					this.MADesligado();
				}
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00028620 File Offset: 0x00026820
		private void MALiagado()
		{
			this.TxtModo.Text = "Modo de operação: Automático Ligado";
			bool flag = this.niveldeacesso > 1;
			if (flag)
			{
				this.BtnAutoDesligado.Enabled = true;
				this.BtnAutoLigado.Enabled = false;
				this.BtnAutoDesligado.BackColor = Color.FromArgb(68, 180, 74);
				this.BtnAutoLigado.BackColor = Color.FromArgb(56, 79, 97);
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0002869C File Offset: 0x0002689C
		private void MADesligado()
		{
			this.TxtModo.Text = "Modo de operação: Automático Desligado";
			bool flag = this.niveldeacesso > 1;
			if (flag)
			{
				this.BtnAutoDesligado.Enabled = false;
				this.BtnAutoLigado.Enabled = true;
				this.BtnAutoLigado.BackColor = Color.FromArgb(68, 180, 74);
				this.BtnAutoDesligado.BackColor = Color.FromArgb(56, 79, 97);
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00028718 File Offset: 0x00026918
		private void EscreveCLPMALigado()
		{
			bool fimlaco = false;
			do
			{
				this.RedundaciaEscreveCLPMALigado();
				this.conexao();
				byte[] bufferRead = new byte[2];
				this.plc.DBRead(26, 0, bufferRead.Length, bufferRead);
				bool Auto_Ligado = bufferRead.GetBitAt(0, 0);
				bool flag = Auto_Ligado;
				if (flag)
				{
					fimlaco = true;
				}
			}
			while (!fimlaco);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00028770 File Offset: 0x00026970
		private void EscreveCLPMADesligado()
	{
		// 1. Tenta escrever o comando
		this.RedundaciaEscreveCLPMADesligado();

		// 2. Se a escrita falhou (Redundancia vai setar conectado=false), não tenta nem ler.
		if (!this.conectado) return;

		// 3. Tenta verificar se o comando foi aceito (com limite de tentativas)
		bool fimlaco = false;
		int tentativas = 0;
		do
		{
			// Se perdeu a conexão no meio do loop, desiste.
			if (!this.conectado) break; 

			try
			{
				byte[] bufferRead = new byte[2];
				this.plc.DBRead(26, 0, bufferRead.Length, bufferRead);
				bool Auto_Desligado = bufferRead.GetBitAt(0, 1);
				if (Auto_Desligado)
				{
					fimlaco = true;
				}
			}
			catch (Exception ex)
			{
				// Se der erro na leitura, marca como desconectado e sai do loop
				this.conectado = false; 
				this.Comunicacao.Text = "Comunicação: Falha (R)";
				break; 
			}

			tentativas++;
			System.Threading.Thread.Sleep(50); // Pequena pausa para o CLP processar
		}
		while (!fimlaco && tentativas < 10); // Limita a 10 tentativas
	}
		// Token: 0x0600017C RID: 380 RVA: 0x000287C8 File Offset: 0x000269C8

		/// <summary>
		/// Escreve no bit de alarme audível (DB19, Offset 2.5)
		/// usado para o Nível 4 de manutenção.
		/// </summary>
		/// <param name="ligar">True para ligar, False para desligar</param>
		private void AcionarAlarmeAudivelManutencao(bool ligar)
		{
			// Este método escreve no DB19 ("Status_sistema"), 
			// no bit "Alarme_carro_nao_identificado" (Offset 2.5) 
			//

			this.conexao();
			if (!this.conectado) return; // Se a conexão falhar, aborta

			try
			{
				// O método VerificaStatus() já lê DB19, 
				// que tem 4 bytes (como visto em VerificaStatus)
				byte[] bufferRead = new byte[2];
				this.plc.DBRead(26, 0, bufferRead.Length, bufferRead);

				// Offset 2.5 = Byte 2, Bit 5
				bufferRead.SetBitAt(0, 4, ligar);

				this.plc.DBWrite(26, 0, bufferRead.Length, bufferRead);
			}
			catch (Exception ex)
			{
				// Se der erro ao escrever, marca como desconectado
				this.conectado = false;
				this.Comunicacao.Text = "Comunicação: Falha (W19)";
			}
		}

		private void RedundaciaEscreveCLPMALigado()
		{
			this.conexao();
			bool Auto_Ligado = true;
			bool Auto_Desligado = false;
			byte[] bufferRead = new byte[2];
			this.plc.DBRead(26, 0, bufferRead.Length, bufferRead);
			bufferRead.SetBitAt(0, 0, Auto_Ligado);
			bufferRead.SetBitAt(0, 1, Auto_Desligado);
			this.plc.DBWrite(26, 0, bufferRead.Length, bufferRead);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00028824 File Offset: 0x00026A24
		private void RedundaciaEscreveCLPMADesligado()
		{
			this.conexao(); // Tenta conectar

			// VERIFICAÇÃO: Se a conexão falhou, ABORTA antes de tentar escrever.
			if (!this.conectado) return;

			try
			{
				bool Auto_Ligado = false;
				bool Auto_Desligado = true;
				byte[] bufferRead = new byte[2];
				this.plc.DBRead(26, 0, bufferRead.Length, bufferRead);
				bufferRead.SetBitAt(0, 0, Auto_Ligado);
				bufferRead.SetBitAt(0, 1, Auto_Desligado);
				this.plc.DBWrite(26, 0, bufferRead.Length, bufferRead);
			}
			catch (Exception ex)
			{
				// Se der erro ao escrever, marca como desconectado
				this.conectado = false;
				this.Comunicacao.Text = "Comunicação: Falha (W)";
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0002887E File Offset: 0x00026A7E
		private void FrmDadosDosCarros_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00028888 File Offset: 0x00026A88
		private void PreencheAtivos()
		{
			int contador = 0;
			string[] coluna = new string[3];
			this.LimpaListaAtivos();
			while (contador < 48)
			{
				bool estado = this.AlarmesAtivos[contador].estado;
				if (estado)
				{
					coluna[0] = Convert.ToString(this.AlarmesAtivos[contador].id);
					coluna[1] = this.AlarmesAtivos[contador].nalarme;
					coluna[2] = this.AlarmesAtivos[contador].data;
					ListViewItem I = new ListViewItem(coluna);
					this.ListaAlarmesAtivos.Items.Add(I);
				}
				contador++;
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0002892D File Offset: 0x00026B2D
		private void LimpaListaAtivos()
		{
			this.ListaAlarmesAtivos.Items.Clear();
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00028944 File Offset: 0x00026B44
		private void BtnConfiguracoes_Click(object sender, EventArgs e)
		{
			this.timer1.Stop();
			FrmConfiguracoes frmAlarmes = new FrmConfiguracoes();
			frmAlarmes.ShowDialog();
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0002896B File Offset: 0x00026B6B
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
        }

        // Token: 0x06000183 RID: 387 RVA: 0x00028978 File Offset: 0x00026B78
        private void BtnAutoDesligado_Click_1(object sender, EventArgs e)
        {
            bool flag = DialogResult.Yes == MessageBox.Show("Tem certeza que deseja alterar o modo de operação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (flag)
            {
                this.EscreveCLPMADesligado();
                this.VerificaStatus();
                this.AtualizaModo();
                MessageBox.Show("Modo de operação alterado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnEditarConfig_Click(object sender, EventArgs e)
        {
            try
            {
                // A sua variável 'caminho' já existe nesta classe
                string caminhoArquivoConfig = Path.Combine(this.caminho, "manutencao_config.txt");

                if (File.Exists(caminhoArquivoConfig))
                {
                    // Abre o ficheiro de configuração no Bloco de Notas
                    Process.Start("notepad.exe", caminhoArquivoConfig);
                }
                else
                {
                    MessageBox.Show("Arquivo 'manutencao_config.txt' não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o editor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void btnVerNotas_Click(object sender, EventArgs e)
		{
			// Abre o nosso novo formulário de visualização
			// (Usamos ShowDialog aqui porque este formulário 
			// não interfere com o timer1_Tick e é apenas um leitor)
			FrmVisualizarNotas frmNotas = new FrmVisualizarNotas();
			frmNotas.ShowDialog(this);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000289D0 File Offset: 0x00026BD0
		private void BtnAutoLigado_Click_1(object sender, EventArgs e)
		{
			bool flag = DialogResult.Yes == MessageBox.Show("Tem certeza que deseja alterar o modo de operação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
			if (flag)
			{
				this.EscreveCLPMALigado();
				this.VerificaStatus();
				this.AtualizaModo();
				MessageBox.Show("Modo de operação alterado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00028A28 File Offset: 0x00026C28
		private void Visual_Click(object sender, EventArgs e)
		{
			this.timer1.Stop();
			base.Hide();
			visual carrovisual = new visual();
			carrovisual.ShowDialog();
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00028A56 File Offset: 0x00026C56
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00028A61 File Offset: 0x00026C61
		private void button1_Click(object sender, EventArgs e)
		{
			this.conexao();
			this.metodosDeIncializacaodoForm();
		}

		// Token: 0x0400023D RID: 573
		public const int NALARME = 48;

		// Token: 0x0400023E RID: 574
		public const int TAMCONTADORES = 1000;

		// Token: 0x0400023F RID: 575
		public const int Tempo2Max = 1000;

		// Token: 0x04000240 RID: 576
		public const int NCARROS = 33;

		// Token: 0x04000241 RID: 577
		public const int NBY19 = 4;

		// Token: 0x04000242 RID: 578
		public const int NBY20 = 94;

		// Token: 0x04000243 RID: 579
		public const int NBY23 = 106;

		// Token: 0x04000244 RID: 580
		public const int NBY26 = 2;

		// Token: 0x04000245 RID: 581
		public const string IPCLP = "192.168.0.1";

		// Token: 0x04000246 RID: 582
		public string caminho = Environment.CurrentDirectory;

		// Token: 0x04000247 RID: 583
		private S7Client plc = new S7Client();

		// Token: 0x04000248 RID: 584
		public FrmDadosDosCarros.contadores[] Contadores = new FrmDadosDosCarros.contadores[1000];

		// Token: 0x04000249 RID: 585
		public FrmDadosDosCarros.carros[] carro = new FrmDadosDosCarros.carros[33];

		// Token: 0x0400024A RID: 586
		public FrmDadosDosCarros.carrobuffer Carrobuffer = default(FrmDadosDosCarros.carrobuffer);

		// Token: 0x0400024B RID: 587
		public FrmDadosDosCarros.status Status = default(FrmDadosDosCarros.status);

		// Token: 0x0400024C RID: 588
		public FrmDadosDosCarros.AlarmeAtivos[] AlarmesAtivos = new FrmDadosDosCarros.AlarmeAtivos[48];

        private FrmAvisoManutencao frmAvisoAtual = null;

        // Token: 0x0400024D RID: 589
        public int tempo;

		// Token: 0x0400024E RID: 590
		public int tempo2;

		// Token: 0x0400024F RID: 591
		public bool conectado = false;

		// Token: 0x04000250 RID: 592
		public bool AlarmeCarroErrado = false;

		// Token: 0x04000251 RID: 593
		public int niveldeacesso = 0;

		// Token: 0x04000252 RID: 594
		public bool permissao = false;

		// Token: 0x04000253 RID: 595
		public bool contcriado = false;

		// Token: 0x04000254 RID: 596
		public string correcaocodigo = "";

		// Token: 0x0200002C RID: 44
		public struct carros
		{
			// Token: 0x040003BB RID: 955
			public int IdCarro;

			// Token: 0x040003BC RID: 956
			public double PosicaoCarro;

			// Token: 0x040003BD RID: 957
			public int Status;

			// Token: 0x040003BE RID: 958
			public int QuantidadeCarro;

			// Token: 0x040003BF RID: 959
			public string DescricaoProduto;

			// Token: 0x040003C0 RID: 960
			public string CodigoModeloProduto;

			// Token: 0x040003C1 RID: 961
			public int NumeroDaReceita;

			// Token: 0x040003C2 RID: 962
			public int IdReceita;

			// Token: 0x040003C3 RID: 963
			public string NomeDaReceita;

			// Token: 0x040003C4 RID: 964
			public int TMin;

			// Token: 0x040003C5 RID: 965
			public int TMax;

			// Token: 0x040003C6 RID: 966
			public bool carregavel;

			// Token: 0x040003C7 RID: 967
			public string setor;
		}

		// Token: 0x0200002D RID: 45
		public struct carrobuffer
		{
			// Token: 0x040003C8 RID: 968
			public string indice;

			// Token: 0x040003C9 RID: 969
			public string id;

			// Token: 0x040003CA RID: 970
			public string posicao;

			// Token: 0x040003CB RID: 971
			public string produto;

			// Token: 0x040003CC RID: 972
			public string NomeDaReceita;

			// Token: 0x040003CD RID: 973
			public string codigo;

			// Token: 0x040003CE RID: 974
			public string quantidade;

			// Token: 0x040003CF RID: 975
			public string status;

			// Token: 0x040003D0 RID: 976
			public bool carregavel;

			// Token: 0x040003D1 RID: 977
			public string setor;

			// Token: 0x040003D2 RID: 978
			public string ano;

			// Token: 0x040003D3 RID: 979
			public string mes;

			// Token: 0x040003D4 RID: 980
			public string dia;

			// Token: 0x040003D5 RID: 981
			public string data;

			// Token: 0x040003D6 RID: 982
			public string hora;

			// Token: 0x040003D7 RID: 983
			public string minuto;

			// Token: 0x040003D8 RID: 984
			public string segundo;

			// Token: 0x040003D9 RID: 985
			public string horario;
		}

		// Token: 0x0200002E RID: 46
		public struct status
		{
			// Token: 0x040003DA RID: 986
			public int ultCarRef;

			// Token: 0x040003DB RID: 987
			public bool AutoOn;

			// Token: 0x040003DC RID: 988
			public bool ModoDesligado;

			// Token: 0x040003DD RID: 989
			public bool ModoManual;

			// Token: 0x040003DE RID: 990
			public bool ModoAutomatico;
		}

		// Token: 0x0200002F RID: 47
		public struct contadores
		{
			// Token: 0x040003DF RID: 991
			public string DescricaoDoProduto;

			// Token: 0x040003E0 RID: 992
			public string CodigoDoProduto;

			// Token: 0x040003E1 RID: 993
			public int QuantidadeAcumulada;
		}

		// Token: 0x02000030 RID: 48
		public struct AlarmeAtivos
		{
			// Token: 0x040003E2 RID: 994
			public int id;

			// Token: 0x040003E3 RID: 995
			public string nalarme;

			// Token: 0x040003E4 RID: 996
			public bool estado;

			// Token: 0x040003E5 RID: 997
			public string data;

			// Token: 0x040003E6 RID: 998
			public bool LigadoA;
		}

		private void BtnConfirmarManutencao_Click(object sender, EventArgs e)
		{
			int nivelAtual = GestorManutencao.UltimoNivelAviso;

			if (nivelAtual > 0)
			{
				// --- LÓGICA CORRIGIDA (SEM ShowDialog) ---
				// Verifica se o aviso (frmAvisoAtual) já está visível
				if (frmAvisoAtual != null && !frmAvisoAtual.IsDisposed)
				{
					// Se já estiver aberto, apenas o traz para a frente
					frmAvisoAtual.BringToFront();
				}
				else
				{
					// Se não estiver aberto, cria um novo (sem congelar)
					frmAvisoAtual = new FrmAvisoManutencao();
					frmAvisoAtual.Show(this);
				}
			}
			else
			{
				MessageBox.Show("A manutenção está em dia. Nenhum aviso ativo.",
								"Manutenção OK",
								MessageBoxButtons.OK,
								MessageBoxIcon.Information);
			}
		}
	}
}
