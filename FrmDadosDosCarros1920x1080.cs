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
	// Token: 0x02000007 RID: 7
	public partial class FrmDadosDosCarros1920x1080 : Form
	{
		// Token: 0x06000072 RID: 114 RVA: 0x0000AE0C File Offset: 0x0000900C
		public FrmDadosDosCarros1920x1080()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000AEB5 File Offset: 0x000090B5
		private void Form1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000AEB8 File Offset: 0x000090B8
		// COLE ISTO EM: FrmDadosDosCarros1920x1080.cs
		private void FrmDadosDosCarros_Shown(object sender, EventArgs e)
		{
			base.Hide();
			Carregando1920x1080 telatemp = new Carregando1920x1080();
			telatemp.Show();

			// --- CORREÇÃO ---
			this.leusuario(); // 1. Leia o usuário primeiro (instantâneo)
			this.conexao();   // 2. Conecte no CLP (lento)
							  // --- FIM DA CORREÇÃO ---

			bool flag = this.conectado;
			if (flag)
			{
				// NOTA: metodosDeIncializacaodoForm ainda vai chamar leusuario() de novo, 
				// mas isso é redundante e não causa problema.
				this.metodosDeIncializacaodoForm();
			}
			telatemp.Hide();
			base.Show();
		}
		// Token: 0x06000075 RID: 117 RVA: 0x0000AF04 File Offset: 0x00009104
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

		// Token: 0x06000076 RID: 118 RVA: 0x0000AF84 File Offset: 0x00009184
		private void leusuario()
		{
			string nacess;
			using (StreamReader sr = new StreamReader(this.caminho + "/cofgs.txt"))
			{
				sr.ReadLine();
				nacess = sr.ReadLine();
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

		private void nivelum()
		{
			this.button2.Enabled = false;
			this.TBoxCodigoBarras.Enabled = false;
			this.TBoxCodigoPecas.Enabled = false;
			this.BtnConfiguracoes.Enabled = false;
			this.BtnConfiguracoes.BackColor = Color.FromArgb(9, 37, 60);

			// --- ADICIONAR ESTAS LINHAS ---
			// (Assumindo que os botões se chamam btnEditarConfig e btnVerNotas no seu Designer 1920x1080)
			this.btnEditarConfig.Enabled = false;
			this.btnEditarConfig.BackColor = Color.FromArgb(9, 37, 60);
		}

		private void niveldois()
		{
			this.button2.Enabled = true;
			this.button2.BackColor = Color.FromArgb(68, 180, 74);
			this.TBoxCodigoBarras.Enabled = true;
			this.TBoxCodigoPecas.Enabled = true;
			this.BtnConfiguracoes.Enabled = false;
			this.BtnConfiguracoes.BackColor = Color.FromArgb(9, 37, 60);

			// --- ADICIONAR ESTAS LINHAS ---
			this.btnEditarConfig.Enabled = false;
			this.btnEditarConfig.BackColor = Color.FromArgb(9, 37, 60);
		}

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

			// --- ADICIONAR ESTAS LINHAS ---
			this.btnEditarConfig.Enabled = true;
			this.btnEditarConfig.BackColor = Color.FromArgb(68, 180, 74);
			// (Se o botão "Recarregar" (button1) também precisar de Nível 3, adicione-o aqui)
			// this.button1.Enabled = true;
			// this.button1.BackColor = Color.FromArgb(68, 180, 74);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000B1AC File Offset: 0x000093AC
		private void ListaIDAlarmes()
		{
			for (int i = 0; i < 48; i++)
			{
				this.AlarmesAtivos[i].id = i;
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000B1E0 File Offset: 0x000093E0
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

		// Token: 0x0600007C RID: 124 RVA: 0x0000B2B4 File Offset: 0x000094B4
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

		// Token: 0x0600007D RID: 125 RVA: 0x0000B568 File Offset: 0x00009768
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

		// Token: 0x0600007E RID: 126 RVA: 0x0000B608 File Offset: 0x00009808
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

		// Token: 0x0600007F RID: 127 RVA: 0x0000B844 File Offset: 0x00009A44
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

		// Token: 0x06000080 RID: 128 RVA: 0x0000B8D4 File Offset: 0x00009AD4
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

		// Token: 0x06000081 RID: 129 RVA: 0x0000B950 File Offset: 0x00009B50
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

		// Token: 0x06000082 RID: 130 RVA: 0x0000BA08 File Offset: 0x00009C08
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

		// Token: 0x06000083 RID: 131 RVA: 0x0000BB3C File Offset: 0x00009D3C
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

		// Token: 0x06000084 RID: 132 RVA: 0x0000BBAC File Offset: 0x00009DAC
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

		// Token: 0x06000085 RID: 133 RVA: 0x0000BC44 File Offset: 0x00009E44
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

		// Token: 0x06000086 RID: 134 RVA: 0x0000BC98 File Offset: 0x00009E98
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

		// Token: 0x06000087 RID: 135 RVA: 0x0000BD0C File Offset: 0x00009F0C
		private void pedeparaclpatualizarcarro()
		{
			this.conexao();
			bool ligabitcarro = true;
			byte[] bufferRead = new byte[2];
			this.plc.DBRead(26, 0, bufferRead.Length, bufferRead);
			bufferRead.SetBitAt(0, 3, ligabitcarro);
			this.plc.DBWrite(26, 0, bufferRead.Length, bufferRead);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000BD5C File Offset: 0x00009F5C
		// COLE ISTO EM: FrmDadosDosCarros1920x1080.cs
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
					this.LblStatusManutencao.Text = "Análise: PENDENTE";
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
		}       // Token: 0x06000089 RID: 137 RVA: 0x0000BDAC File Offset: 0x00009FAC
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

        // Método para o alarme Nível 4
        private void AcionarAlarmeAudivelManutencao(bool ligar)
        {
            this.conexao();
            if (!this.conectado) return;
            try
            {
                byte[] bufferRead = new byte[2];
                this.plc.DBRead(26, 0, bufferRead.Length, bufferRead);
                //bufferRead.SetBitAt(0, 4, ligar); // DB19, Byte 2, Bit 5
				bufferRead.SetBitAt(0, 4, ligar);
				this.plc.DBWrite(26, 0, bufferRead.Length, bufferRead);
            }
            catch (Exception ex)
            {
                this.conectado = false;
                this.Comunicacao.Text = "Comunicação: Falha (W19)";
            }

		}

        // Clique do botão Editar Horários
        private void btnEditarConfig_Click(object sender, EventArgs e)
		{
			try
			{
				string caminhoArquivoConfig = Path.Combine(this.caminho, "manutencao_config.txt");
				if (File.Exists(caminhoArquivoConfig))
				{
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

		// Clique do botão Ver Notas
		private void btnVerNotas_Click(object sender, EventArgs e)
		{
			FrmVisualizarNotas frmNotas = new FrmVisualizarNotas();
			frmNotas.ShowDialog(this);
		}

		// Clique do botão Confirmar Manutenção (Manual)
		// ** IMPORTANTE: Ligue este método ao seu botão de manutenção no Designer 1920x1080 **
		private void BtnConfirmarManutencao_Click(object sender, EventArgs e)
		{
			int nivelAtual = GestorManutencao.UltimoNivelAviso;
			if (nivelAtual > 0)
			{
				if (frmAvisoAtual != null && !frmAvisoAtual.IsDisposed)
				{
					frmAvisoAtual.BringToFront();
				}
				else
				{
					frmAvisoAtual = new FrmAvisoManutencao();
					frmAvisoAtual.Show(this); // Sem congelar
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

		// Token: 0x0600008A RID: 138 RVA: 0x0000BDFC File Offset: 0x00009FFC


		private void BtnCadastro_Click(object sender, EventArgs e)
		{
			this.timer1.Stop();
			base.Hide();
			FrmCadastro1920x1080 frmCadastro = new FrmCadastro1920x1080();
			frmCadastro.ShowDialog();
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000BE2C File Offset: 0x0000A02C
		private void BtnAlarme_Click(object sender, EventArgs e)
		{
			this.timer1.Stop();
			base.Hide();
			FrmAlarmes1920x1080 frmAlarmes = new FrmAlarmes1920x1080();
			frmAlarmes.ShowDialog();
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000BE5C File Offset: 0x0000A05C
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

		// Token: 0x0600008D RID: 141 RVA: 0x0000BF44 File Offset: 0x0000A144
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

		// Token: 0x0600008E RID: 142 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
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

		// Token: 0x0600008F RID: 143 RVA: 0x0000C0AC File Offset: 0x0000A2AC
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

		// Token: 0x06000090 RID: 144 RVA: 0x0000C108 File Offset: 0x0000A308
		private void button3_Click(object sender, EventArgs e)
		{
			this.metodosciclicos();
			this.timer1.Start();
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000C11E File Offset: 0x0000A31E
		private void ListaDadosCarros_MouseEnter(object sender, EventArgs e)
		{
			this.timer1.Stop();
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000C12D File Offset: 0x0000A32D
		private void ListaDadosCarros_MouseLeave(object sender, EventArgs e)
		{
			this.timer1.Start();
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000C13C File Offset: 0x0000A33C
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

		// Token: 0x06000094 RID: 148 RVA: 0x0000C410 File Offset: 0x0000A610
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

		// Token: 0x06000095 RID: 149 RVA: 0x0000C6FC File Offset: 0x0000A8FC
		public void limpaformulario()
		{
			this.ListaDadosCarros.Items.Clear();
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000C710 File Offset: 0x0000A910
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

		// Token: 0x06000097 RID: 151 RVA: 0x0000C8C8 File Offset: 0x0000AAC8
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

		// Token: 0x06000098 RID: 152 RVA: 0x0000C978 File Offset: 0x0000AB78
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

		// Token: 0x06000099 RID: 153 RVA: 0x0000CCD0 File Offset: 0x0000AED0
		private void CriaRegistro()
		{
			StreamWriter x = File.CreateText(this.caminho + "/Registros.txt");
			x.Close();
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000CCFC File Offset: 0x0000AEFC
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

		// Token: 0x0600009B RID: 155 RVA: 0x0000CF38 File Offset: 0x0000B138
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

		// Token: 0x0600009C RID: 156 RVA: 0x0000D2E4 File Offset: 0x0000B4E4
		private void CriaContador()
		{
			StreamWriter x = File.CreateText(this.caminho + "/Contadores.txt");
			x.Close();
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000D310 File Offset: 0x0000B510
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

		// Token: 0x0600009E RID: 158 RVA: 0x0000D42C File Offset: 0x0000B62C
		private void ModoDesligado()
		{
			this.TxtModo.Text = "Modo de operação: Desligado";
			this.BtnAutoDesligado.Enabled = false;
			this.BtnAutoLigado.Enabled = false;
			this.BtnAutoDesligado.BackColor = Color.FromArgb(56, 79, 97);
			this.BtnAutoLigado.BackColor = Color.FromArgb(56, 79, 97);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000D494 File Offset: 0x0000B694
		private void ModoManual()
		{
			this.TxtModo.Text = "Modo de operação: Manual";
			this.BtnAutoDesligado.Enabled = false;
			this.BtnAutoLigado.Enabled = false;
			this.BtnAutoDesligado.BackColor = Color.FromArgb(56, 79, 97);
			this.BtnAutoLigado.BackColor = Color.FromArgb(56, 79, 97);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000D4FC File Offset: 0x0000B6FC
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

		// Token: 0x060000A1 RID: 161 RVA: 0x0000D540 File Offset: 0x0000B740
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

		// Token: 0x060000A2 RID: 162 RVA: 0x0000D5BC File Offset: 0x0000B7BC
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

		// Token: 0x060000A3 RID: 163 RVA: 0x0000D638 File Offset: 0x0000B838
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

		// Token: 0x060000A4 RID: 164 RVA: 0x0000D690 File Offset: 0x0000B890
		private void EscreveCLPMADesligado()
		{
			bool fimlaco = false;
			do
			{
				this.RedundaciaEscreveCLPMADesligado();
				this.conexao();
				byte[] bufferRead = new byte[2];
				this.plc.DBRead(26, 0, bufferRead.Length, bufferRead);
				bool Auto_Desligado = bufferRead.GetBitAt(0, 1);
				bool flag = Auto_Desligado;
				if (flag)
				{
					fimlaco = true;
				}
			}
			while (!fimlaco);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000D6E8 File Offset: 0x0000B8E8
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

		// Token: 0x060000A6 RID: 166 RVA: 0x0000D744 File Offset: 0x0000B944
		private void RedundaciaEscreveCLPMADesligado()
		{
			this.conexao();
			bool Auto_Ligado = false;
			bool Auto_Desligado = true;
			byte[] bufferRead = new byte[2];
			this.plc.DBRead(26, 0, bufferRead.Length, bufferRead);
			bufferRead.SetBitAt(0, 0, Auto_Ligado);
			bufferRead.SetBitAt(0, 1, Auto_Desligado);
			this.plc.DBWrite(26, 0, bufferRead.Length, bufferRead);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000D79E File Offset: 0x0000B99E
		private void FrmDadosDosCarros_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000D7A8 File Offset: 0x0000B9A8
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

		// Token: 0x060000A9 RID: 169 RVA: 0x0000D84D File Offset: 0x0000BA4D
		private void LimpaListaAtivos()
		{
			this.ListaAlarmesAtivos.Items.Clear();
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000D864 File Offset: 0x0000BA64
		private void BtnConfiguracoes_Click(object sender, EventArgs e)
		{
			this.timer1.Stop();
			FrmConfiguracoes1920x1080 frmAlarmes = new FrmConfiguracoes1920x1080();
			frmAlarmes.ShowDialog();
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000D88B File Offset: 0x0000BA8B
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000D898 File Offset: 0x0000BA98
		private void BtnAutoDesligado_Click_1(object sender, EventArgs e)
		{
			bool flag = DialogResult.Yes == MessageBox.Show("Tem certfeza que deseja alterar o modo de operação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
			if (flag)
			{
				this.EscreveCLPMADesligado();
				this.VerificaStatus();
				this.AtualizaModo();
				MessageBox.Show("Modo de operação alterado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000D8F0 File Offset: 0x0000BAF0
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

		// Token: 0x060000AE RID: 174 RVA: 0x0000D948 File Offset: 0x0000BB48
		private void Visual_Click(object sender, EventArgs e)
		{
			this.timer1.Stop();
			base.Hide();
			visual1920x1080 carrovisual = new visual1920x1080();
			carrovisual.ShowDialog();
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000D976 File Offset: 0x0000BB76
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000D981 File Offset: 0x0000BB81
		private void button1_Click(object sender, EventArgs e)
		{
			this.conexao();
			this.metodosDeIncializacaodoForm();
		}

		// Token: 0x040000A6 RID: 166
		public const int NALARME = 48;

		// Token: 0x040000A7 RID: 167
		public const int TAMCONTADORES = 1000;

		// Token: 0x040000A8 RID: 168
		public const int Tempo2Max = 1000;

		// Token: 0x040000A9 RID: 169
		public const int NCARROS = 33;

		// Token: 0x040000AA RID: 170
		public const int NBY19 = 4;

		// Token: 0x040000AB RID: 171
		public const int NBY20 = 94;

		// Token: 0x040000AC RID: 172
		public const int NBY23 = 106;

		// Token: 0x040000AD RID: 173
		public const int NBY26 = 2;

		// Token: 0x040000AE RID: 174
		public const string IPCLP = "192.168.0.1";

		// Token: 0x040000AF RID: 175
		public string caminho = Environment.CurrentDirectory;

		// Token: 0x040000B0 RID: 176
		private S7Client plc = new S7Client();

		// Token: 0x040000B1 RID: 177
		public FrmDadosDosCarros1920x1080.contadores[] Contadores = new FrmDadosDosCarros1920x1080.contadores[1000];

		// Token: 0x040000B2 RID: 178
		public FrmDadosDosCarros1920x1080.carros[] carro = new FrmDadosDosCarros1920x1080.carros[33];

		// Token: 0x040000B3 RID: 179
		public FrmDadosDosCarros1920x1080.carrobuffer Carrobuffer = default(FrmDadosDosCarros1920x1080.carrobuffer);

		// Token: 0x040000B4 RID: 180
		public FrmDadosDosCarros1920x1080.status Status = default(FrmDadosDosCarros1920x1080.status);

		// Token: 0x040000B5 RID: 181
		public FrmDadosDosCarros1920x1080.AlarmeAtivos[] AlarmesAtivos = new FrmDadosDosCarros1920x1080.AlarmeAtivos[48];

		// Token: 0x040000B6 RID: 182
		public int tempo;

		// Token: 0x040000B7 RID: 183
		public int tempo2;

		// Token: 0x040000B8 RID: 184
		public bool conectado = false;

		// Token: 0x040000B9 RID: 185
		public bool AlarmeCarroErrado = false;

		// Token: 0x040000BA RID: 186
		public int niveldeacesso = 0;

		// Token: 0x040000BB RID: 187
		public bool permissao = false;

		// Token: 0x040000BC RID: 188
		public bool contcriado = false;

		// Token: 0x040000BD RID: 189
		public string correcaocodigo = "";

		private FrmAvisoManutencao frmAvisoAtual = null;
		// Token: 0x0200001C RID: 28
		public struct carros
		{
			// Token: 0x04000359 RID: 857
			public int IdCarro;

			// Token: 0x0400035A RID: 858
			public double PosicaoCarro;

			// Token: 0x0400035B RID: 859
			public int Status;

			// Token: 0x0400035C RID: 860
			public int QuantidadeCarro;

			// Token: 0x0400035D RID: 861
			public string DescricaoProduto;

			// Token: 0x0400035E RID: 862
			public string CodigoModeloProduto;

			// Token: 0x0400035F RID: 863
			public int NumeroDaReceita;

			// Token: 0x04000360 RID: 864
			public int IdReceita;

			// Token: 0x04000361 RID: 865
			public string NomeDaReceita;

			// Token: 0x04000362 RID: 866
			public int TMin;

			// Token: 0x04000363 RID: 867
			public int TMax;

			// Token: 0x04000364 RID: 868
			public bool carregavel;

			// Token: 0x04000365 RID: 869
			public string setor;
		}

		// Token: 0x0200001D RID: 29
		public struct carrobuffer
		{
			// Token: 0x04000366 RID: 870
			public string indice;

			// Token: 0x04000367 RID: 871
			public string id;

			// Token: 0x04000368 RID: 872
			public string posicao;

			// Token: 0x04000369 RID: 873
			public string produto;

			// Token: 0x0400036A RID: 874
			public string NomeDaReceita;

			// Token: 0x0400036B RID: 875
			public string codigo;

			// Token: 0x0400036C RID: 876
			public string quantidade;

			// Token: 0x0400036D RID: 877
			public string status;

			// Token: 0x0400036E RID: 878
			public bool carregavel;

			// Token: 0x0400036F RID: 879
			public string setor;

			// Token: 0x04000370 RID: 880
			public string ano;

			// Token: 0x04000371 RID: 881
			public string mes;

			// Token: 0x04000372 RID: 882
			public string dia;

			// Token: 0x04000373 RID: 883
			public string data;

			// Token: 0x04000374 RID: 884
			public string hora;

			// Token: 0x04000375 RID: 885
			public string minuto;

			// Token: 0x04000376 RID: 886
			public string segundo;

			// Token: 0x04000377 RID: 887
			public string horario;
		}

		// Token: 0x0200001E RID: 30
		public struct status
		{
			// Token: 0x04000378 RID: 888
			public int ultCarRef;

			// Token: 0x04000379 RID: 889
			public bool AutoOn;

			// Token: 0x0400037A RID: 890
			public bool ModoDesligado;

			// Token: 0x0400037B RID: 891
			public bool ModoManual;

			// Token: 0x0400037C RID: 892
			public bool ModoAutomatico;
		}

		// Token: 0x0200001F RID: 31
		public struct contadores
		{
			// Token: 0x0400037D RID: 893
			public string DescricaoDoProduto;

			// Token: 0x0400037E RID: 894
			public string CodigoDoProduto;

			// Token: 0x0400037F RID: 895
			public int QuantidadeAcumulada;
		}

		// Token: 0x02000020 RID: 32
		public struct AlarmeAtivos
		{
			// Token: 0x04000380 RID: 896
			public int id;

			// Token: 0x04000381 RID: 897
			public string nalarme;

			// Token: 0x04000382 RID: 898
			public bool estado;

			// Token: 0x04000383 RID: 899
			public string data;

			// Token: 0x04000384 RID: 900
			public bool LigadoA;
		}

        private void BtnConfirmarManutencao_Click_1(object sender, EventArgs e)
        {

        }
    }
}
