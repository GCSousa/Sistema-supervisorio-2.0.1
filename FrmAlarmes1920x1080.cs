using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Sharp7;

namespace SupervisorioDana
{
	// Token: 0x02000004 RID: 4
	public partial class FrmAlarmes1920x1080 : Form
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002380 File Offset: 0x00000580
		public FrmAlarmes1920x1080()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002428 File Offset: 0x00000628
		private void leCLPCarro()
		{
			this.conexao();
			byte[] bufferRead = new byte[4];
			this.plc.DBRead(19, 0, bufferRead.Length, bufferRead);
			int nDadoDBcorrente = 0;
			this.ultimocarro = bufferRead.GetIntAt(nDadoDBcorrente);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002468 File Offset: 0x00000668
		private void AtualizaCarro()
		{
			bool flag = this.Alarmes[37].estado || this.Alarmes[38].estado || this.Alarmes[40].estado;
			if (flag)
			{
				this.AlarmeCarroErrado = true;
			}
			else
			{
				this.AlarmeCarroErrado = false;
			}
			bool flag2 = !this.AlarmeCarroErrado;
			if (flag2)
			{
				this.LabelUltCarro.Text = "Ultimo carro: " + Convert.ToString(this.ultimocarro);
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

		// Token: 0x0600000D RID: 13 RVA: 0x00002528 File Offset: 0x00000728
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

		// Token: 0x0600000E RID: 14 RVA: 0x000025C0 File Offset: 0x000007C0
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

		// Token: 0x0600000F RID: 15 RVA: 0x00002614 File Offset: 0x00000814
		private void button5_Click(object sender, EventArgs e)
		{
			this.conexao();
			short carrocerto = short.Parse(this.TBoxAtualizaCarro.Text);
			byte[] bufferRead = new byte[4];
			this.plc.DBRead(19, 0, bufferRead.Length, bufferRead);
			bufferRead.SetIntAt(0, carrocerto);
			this.plc.DBWrite(19, 0, bufferRead.Length, bufferRead);
			this.pedeparaclpatualizarcarro();
			this.leCLPCarro();
			this.AtualizaCarro();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002688 File Offset: 0x00000888
		private void pedeparaclpatualizarcarro()
		{
			this.conexao();
			bool ligabitcarro = true;
			byte[] bufferRead = new byte[2];
			this.plc.DBRead(26, 0, bufferRead.Length, bufferRead);
			bufferRead.SetBitAt(0, 3, ligabitcarro);
			this.plc.DBWrite(26, 0, bufferRead.Length, bufferRead);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000026D8 File Offset: 0x000008D8
		private void LeUsuario()
		{
			string nacess;
			using (StreamReader sr = new StreamReader(this.caminho + "/cofgs.txt"))
			{
				this.justificativa.responsavel = sr.ReadLine();
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

		// Token: 0x06000012 RID: 18 RVA: 0x0000278C File Offset: 0x0000098C
		private void nivelum()
		{
			this.BtnAtualizarCarro.Enabled = false;
			this.TBoxAtualizaCarro.Enabled = false;
			this.BtnRearmar.Enabled = false;
			this.Tboxjustificativa.Enabled = false;
			this.BtnSalvar.Enabled = false;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000027DB File Offset: 0x000009DB
		private void niveldois()
		{
			this.TBoxAtualizaCarro.Enabled = true;
			this.BtnAtualizarCarro.Enabled = true;
			this.BtnAtualizarCarro.BackColor = Color.FromArgb(68, 180, 74);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002814 File Offset: 0x00000A14
		private void niveltres()
		{
			this.BtnRearmar.Enabled = true;
			this.Tboxjustificativa.Enabled = true;
			this.BtnRearmar.BackColor = Color.FromArgb(68, 180, 74);
			this.TBoxAtualizaCarro.Enabled = true;
			this.BtnAtualizarCarro.Enabled = true;
			this.BtnAtualizarCarro.BackColor = Color.FromArgb(68, 180, 74);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000288C File Offset: 0x00000A8C
		private void ListaIDAlarmes()
		{
			for (int i = 0; i < 48; i++)
			{
				this.Alarmes[i].id = i;
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000028C0 File Offset: 0x00000AC0
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
							this.Alarmes[contador].nalarme = linha;
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
				MessageBox.Show("ERRO 03,\narquivo de leitura de nome dos ALarmes não encontrado\n Erro corrigido automaticamente");
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002980 File Offset: 0x00000B80
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

		// Token: 0x06000018 RID: 24 RVA: 0x00002C34 File Offset: 0x00000E34
		private void FrmAlarmes_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002C38 File Offset: 0x00000E38
		private void metodosDeIncializacaodoForm()
		{
			this.LeUsuario();
			this.ListaIDAlarmes();
			this.LeNomeAlarmes();
			this.preencheComboUsuarios();
			this.ColetaAlarmesCLP();
			this.LimpaListaAlarmes();
			this.PreencheAlarmes();
			this.ColetaAlarmesAtivos();
			this.LimpaListaAtivos();
			this.PreencheAtivos();
			this.leCLPparada();
			this.lelistatxt();
			this.leCLPCarro();
			this.AtualizaCarro();
			this.timer1.Start();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002CB4 File Offset: 0x00000EB4
		private void metodosDeIncializacaodoForm2()
		{
			this.LeUsuario();
			this.ListaIDAlarmes();
			this.LeNomeAlarmes();
			this.ColetaAlarmesCLP();
			this.LimpaListaAlarmes();
			this.PreencheAlarmes();
			this.ColetaAlarmesAtivos();
			this.LimpaListaAtivos();
			this.PreencheAtivos();
			this.leCLPparada();
			this.lelistatxt();
			this.leCLPCarro();
			this.AtualizaCarro();
			this.timer1.Start();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002D2C File Offset: 0x00000F2C
		private void FrmAlarmes_Shown(object sender, EventArgs e)
		{
			base.Hide();
			Carregando telatemp = new Carregando();
			telatemp.Show();
			this.conexao();
			bool flag = this.conectado;
			if (flag)
			{
				this.metodosDeIncializacaodoForm();
			}
			telatemp.Hide();
			base.Show();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002D78 File Offset: 0x00000F78
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.tempoinicial++;
			bool flag = this.tempoinicial >= 1000;
			if (flag)
			{
				this.conexao();
			}
			bool flag2 = this.conectado;
			if (flag2)
			{
				this.tempo++;
				this.tempojustificativa++;
				bool flag3 = this.tempojustificativa >= 200 && this.modojustificativa;
				if (flag3)
				{
					this.tempojustificativa = 0;
					this.parte2();
				}
				bool flag4 = this.tempo >= 1000;
				if (flag4)
				{
					this.tempo = 0;
					this.conexao();
					this.ColetaAlarmesCLP();
					this.ColetaAlarmesAtivos();
					this.leCLPparada();
					this.leCLPCarro();
				}
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002E48 File Offset: 0x00001048
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
				this.Comunicacao.Text = "OK";
				this.conectado = true;
			}
			else
			{
				bool flag2 = chamado_limite == 2;
				if (flag2)
				{
					this.Comunicacao.Text = "Desconectado (1)";
					this.conectado = false;
				}
				else
				{
					this.Comunicacao.Text = "Desconectado (2)";
					this.conectado = false;
				}
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002EE8 File Offset: 0x000010E8
		private void ColetaAlarmesCLP()
		{
			this.conexao();
			int nDadoDBcorrente = 0;
			int contadordebit = 0;
			byte[] bufferRead = new byte[6];
			this.plc.DBRead(1, 0, bufferRead.Length, bufferRead);
			for (int i = 0; i < 48; i++)
			{
				this.Alarmes[i].estado = bufferRead.GetBitAt(nDadoDBcorrente, contadordebit);
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

		// Token: 0x0600001F RID: 31 RVA: 0x00002F64 File Offset: 0x00001164
		private void PreencheAlarmes()
		{
			string[] coluna = new string[3];
			for (int i = 0; i < 48; i++)
			{
				coluna[0] = Convert.ToString(this.Alarmes[i].id);
				coluna[1] = this.Alarmes[i].nalarme;
				coluna[2] = Convert.ToString(this.Alarmes[i].estado);
				ListViewItem I = new ListViewItem(coluna);
				this.ListaAlarmes.Items.Add(I);
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002FEB File Offset: 0x000011EB
		private void LimpaListaAlarmes()
		{
			this.ListaAlarmes.Items.Clear();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003000 File Offset: 0x00001200
		private void ColetaAlarmesAtivos()
		{
			int contadorAtivos = 0;
			for (int i = 0; i < 48; i++)
			{
				bool estado = this.Alarmes[i].estado;
				if (estado)
				{
					this.AlarmesAtivos[contadorAtivos].id = i;
					this.AlarmesAtivos[contadorAtivos].nalarme = this.Alarmes[i].nalarme;
					this.AlarmesAtivos[contadorAtivos].data = Convert.ToString(DateTime.Now);
					contadorAtivos++;
				}
			}
			this.contadordealarmesativos = contadorAtivos;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003094 File Offset: 0x00001294
		private void PreencheAtivos()
		{
			int contador = 0;
			string[] coluna = new string[3];
			int cat = this.contadordealarmesativos;
			this.LimpaListaAtivos();
			while (contador < cat)
			{
				coluna[0] = Convert.ToString(this.AlarmesAtivos[contador].id);
				coluna[1] = this.AlarmesAtivos[contador].nalarme;
				coluna[2] = this.AlarmesAtivos[contador].data;
				contador++;
				ListViewItem I = new ListViewItem(coluna);
				this.ListaAlarmesAtivos.Items.Add(I);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003125 File Offset: 0x00001325
		public void LimpaListaAtivos()
		{
			this.ListaAlarmesAtivos.Items.Clear();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003139 File Offset: 0x00001339
		private void FrmAlarmes_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003144 File Offset: 0x00001344
		private void preencheComboUsuarios()
		{
			this.Tboxjustificativa.Items.Clear();
			string[] nome = new string[]
			{
				"1 AGUARDANDO AQUECIMENTO", "2 AJUSTE DE MÁQUINA ", "3 AJUSTE DE PROGRAMA", "4 AUDITORIA", "5 DESENVOLVIMENTO DE FERRAMENTA", "6 DESENVOLVIMENTO DE PEÇA", "7 FALHA NO DISPOSITIVO", "8 FALTA DE DISPOSITIVO", "9 FALTA DE DISPOSITIVO DE MEDIÇÃO", "10 FALTA DE RACK / EMBALAGEM",
				"11 FALTA DE ENERGIA", "12 FALTA DE FERRAMENTA", "13 FALTA DE MATÉRIA PRIMA (TINTAS)", "14 FALTA DE OPERADOR (BANHEIRO/RH/SOPE/BANCO)", "15 GANCHEIRA VAZIA POR FALTA DE PEÇAS (PCP)", "16 LAYOUT", "17 LIMPEZA / TPM", "18 LUBRIFICAÇÃO", "19 MANUTENÇÃO ELETRÔNICA", "20 MANUTENÇÃO MECÂNICA",
				"21 MANUTENÇÃO PREDIAL", "22 MATÉRIA PRIMA (POROSIDADE/OXIDAÇÃO/REBARBA/DESLOCAMENTO)", "23 OPERADOR DESLOCADO", "24 QUEBRA DE DISPOSITIVO", "25 QUEBRA DE FERRAMENTA", "26 REGISTRO DE LIBERAÇÃO DE TURNO", "27 RETRABALHO", "28 REUNIÕES / BOLETIM", "29 SAM / GINÁSTICA LABORAL / FISIOTERAPIA", "30 SETUP - TROCA DE COR",
				"31 TREINAMENTO", "32 TROCA DE PROGRAMA", "33 CARREGAMENTO NA MONOVIA", "34 AGUARDANDO LIBERAÇÃO DA QUALIDADE", "35 PREPARAÇÃO DE TINTA", "36 PURGA DO T-MIX", "37 DESCARREGAMRNTO DA MONOVIA", "38 MASCARAMENTO", "39 AGUARDANDO PALETEIRA ELÉTRICA", "40 PARADA PARA FINALIZAR PINTURA",
				"41 TROCA DOS FILTROS", "42 PARADA PROGRAMADA"
			};
			for (int i = 0; i < 42; i++)
			{
				this.Tboxjustificativa.Items.Add(nome[i]);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003303 File Offset: 0x00001503
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003310 File Offset: 0x00001510
		private void BtnAlarme_Click(object sender, EventArgs e)
		{
			base.Hide();
			FrmDadosDosCarros1920x1080 frmDadosDosCarros = new FrmDadosDosCarros1920x1080();
			frmDadosDosCarros.ShowDialog();
			this.timer1.Stop();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003340 File Offset: 0x00001540
		private void ligabotoesalarme()
		{
			this.TBoxAlarmesdiag.Text = "Rearme Solicitado";
			bool flag = this.niveldeacesso > 1;
			if (flag)
			{
				this.Tboxjustificativa.Enabled = true;
				this.BtnSalvar.Enabled = true;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003388 File Offset: 0x00001588
		private void desligabotoesalarme()
		{
			this.BtnSalvar.Enabled = false;
			bool flag = this.niveldeacesso < 3;
			if (flag)
			{
				this.BtnRearmar.Enabled = false;
				this.Tboxjustificativa.Enabled = false;
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000033CC File Offset: 0x000015CC
		private void escrevetxtalarmeacionado()
		{
			DateTime data = default(DateTime);
			string arquivo = this.caminho + "/prog_dana_controle_rede.txt";
			bool flag = File.Exists(arquivo);
			if (flag)
			{
				try
				{
					using (StreamReader sr = new StreamReader(arquivo))
					{
						string linha = sr.ReadLine();
						string datastring = sr.ReadLine();
					}
				}
				catch (Exception ex)
				{
				}
			}
			else
			{
				StreamWriter x = File.CreateText(this.caminho + "/prog_dana_controle_rede.txt");
				x.Close();
				MessageBox.Show("ERRO 01,\nerro corrigido automaticamente");
			}
			data = DateTime.Now;
			using (StreamWriter y = new StreamWriter(arquivo))
			{
				y.WriteLine("JUSTIFICATIVAPENDENTE");
				int result = DateTime.Compare(data, DateTime.Now);
				bool flag2 = result < 0;
				if (flag2)
				{
					y.WriteLine(Convert.ToString(data));
				}
				else
				{
					y.WriteLine(Convert.ToString(DateTime.Now));
				}
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000034FC File Offset: 0x000016FC
		private void VerificaTxt()
		{
			string justificativa = this.leparametrojustificativa();
			bool flag = justificativa == "JUSTIFICATIVAPENDENTE";
			if (flag)
			{
				this.BtnRearmar.Enabled = true;
			}
			else
			{
				bool flag2 = justificativa == "OK";
				if (!flag2)
				{
					MessageBox.Show("erro na leitura do parametro de justificativa");
				}
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003554 File Offset: 0x00001754
		private string leparametrojustificativa()
		{
			string parametro;
			using (StreamReader sr = new StreamReader(this.caminho + "/prog_dana_controle_rede.txt"))
			{
				parametro = sr.ReadLine();
			}
			return parametro;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000035A4 File Offset: 0x000017A4
		private void reamardealarmeparada()
		{
			string arquivo = this.caminho + "/prog_dana_controle_rede.txt";
			bool flag = File.Exists(arquivo);
			if (flag)
			{
				try
				{
					using (StreamWriter y = new StreamWriter(arquivo))
					{
						y.WriteLine("OK");
						y.WriteLine("");
						y.Close();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			else
			{
				StreamWriter x = File.CreateText(arquivo);
				x.Close();
				this.reamardealarmeparada();
				MessageBox.Show("ERRO 01,\nerro corrigido automaticamente");
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000365C File Offset: 0x0000185C
		private void escreveCLPAlarmeRearmado()
		{
			this.conexao();
			byte[] bufferRead = new byte[2];
			this.plc.DBRead(26, 0, bufferRead.Length, bufferRead);
			bufferRead.SetBitAt(0, 2, true);
			this.plc.DBWrite(26, 0, bufferRead.Length, bufferRead);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000036A8 File Offset: 0x000018A8
		private void BtnSalvar_Click(object sender, EventArgs e)
		{
			this.VerificaTxt();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000036B4 File Offset: 0x000018B4
		private void lelistatxt()
		{
			int contador = 0;
			bool flag = false;
			string v = "";
			string v2 = "";
			string v3 = "";
			string v4 = "";
			string v5 = "";
			int count = 0;
			string arquivo = this.caminho + "/justificativa.txt";
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
							this.jler[contador].id = int.Parse(v);
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
							this.jler[contador].descricao = v2;
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
							this.jler[contador].datai = v3;
							flag = false;
							while (!flag)
							{
								bool flag6 = linha[count] == ';';
								if (flag6)
								{
									flag = true;
								}
								else
								{
									v4 += linha[count].ToString();
								}
								count++;
							}
							this.jler[contador].duracao = v4;
							flag = false;
							while (!flag)
							{
								bool flag7 = linha[count] == ';';
								if (flag7)
								{
									flag = true;
								}
								else
								{
									v5 += linha[count].ToString();
								}
								count++;
							}
							this.jler[contador].responsavel = v5;
							contador++;
							v = "";
							v2 = "";
							v3 = "";
							v4 = "";
							v5 = "";
							flag = false;
							count = 0;
						}
						bool flag8 = contador > 1500;
						if (flag8)
						{
							MessageBox.Show("limite maximo de historico estourado,\n por favor mova o historico de lugar,\n e reinicie o sistema");
						}
					}
				}
				catch (Exception ex)
				{
				}
			}
			else
			{
				StreamWriter x = File.CreateText(arquivo);
				x.Close();
				this.lelistatxt();
				MessageBox.Show("ERRO 10,\nerro corrigido automaticamente");
			}
			this.ListaJustificava.Items.Clear();
			string[] coluna = new string[5];
			for (int i = 0; i < contador; i++)
			{
				coluna[0] = Convert.ToString(this.jler[i].id);
				coluna[1] = this.jler[i].descricao;
				coluna[2] = this.jler[i].datai;
				coluna[3] = this.jler[i].duracao;
				coluna[4] = this.jler[i].responsavel;
				ListViewItem I = new ListViewItem(coluna);
				this.ListaJustificava.Items.Add(I);
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003A90 File Offset: 0x00001C90
		private void leCLPparada()
		{
			this.conexao();
			byte[] bufferRead = new byte[32];
			this.plc.DBRead(29, 0, bufferRead.Length, bufferRead);
			bool justificativa_pendente = bufferRead.GetBitAt(30, 2);
			bool parada_registrada = bufferRead.GetBitAt(30, 0);
			bool flag = justificativa_pendente;
			if (flag)
			{
				this.modojustificativa = true;
				this.aguardandojustificativa = true;
				this.justificativapendentesolicitada();
			}
			else
			{
				bool flag2 = parada_registrada;
				if (flag2)
				{
					this.modojustificativa = false;
					this.aguardandojustificativa = false;
					this.paradaregistradaregistradaativa();
					this.parte4();
					this.escrevenalistatxt();
					this.lelistatxt();
				}
				else
				{
					this.desligabotoesalarme();
				}
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003B34 File Offset: 0x00001D34
		private void justificativapendentesolicitada()
		{
			this.ligabotoesalarme();
			this.escrevetxtalarmeacionado();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003B45 File Offset: 0x00001D45
		private void paradaregistradaregistradaativa()
		{
			this.desligabotoesalarme();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003B50 File Offset: 0x00001D50
		private void BtnRearmar_Click(object sender, EventArgs e)
		{
			bool flag = this.Tboxjustificativa.Text != "" || this.Tboxjustificativa.Text != null;
			if (flag)
			{
				this.escreveCLPAlarmeRearmado();
				this.reamardealarmeparada();
				this.desligabotoesalarme();
				this.ColetaAlarmesCLP();
				this.ColetaAlarmesAtivos();
				this.leCLPCarro();
				this.aguardandojustificativa = this.parte1();
				bool flag2 = this.aguardandojustificativa;
				if (flag2)
				{
					this.modojustificativa = true;
					this.parte2();
				}
				else
				{
					bool flag3 = !this.modojustificativa;
					if (flag3)
					{
						this.parte3();
						this.escrevenalistatxt();
						this.lelistatxt();
					}
				}
			}
			else
			{
				MessageBox.Show("Justificativa inválida, por favor insira alguma justificativa valida");
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003C14 File Offset: 0x00001E14
		private bool parte1()
		{
			this.conexao();
			byte[] bufferRead = new byte[32];
			this.plc.DBRead(29, 0, bufferRead.Length, bufferRead);
			bool justificativa_pendente = bufferRead.GetBitAt(30, 2);
			bool parada_registrada = bufferRead.GetBitAt(30, 0);
			return justificativa_pendente;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003C64 File Offset: 0x00001E64
		private void parte2()
		{
			this.conexao();
			byte[] bufferRead = new byte[32];
			this.plc.DBRead(29, 0, bufferRead.Length, bufferRead);
			bool justificativa_pendente = bufferRead.GetBitAt(30, 2);
			bool parada_registrada = bufferRead.GetBitAt(30, 0);
			bool flag = justificativa_pendente && parada_registrada;
			if (flag)
			{
				this.resolucaojustificativa();
				this.escrevenalistatxt();
				this.modojustificativa = false;
			}
			this.lelistatxt();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003CD7 File Offset: 0x00001ED7
		private void resolucaojustificativa()
		{
			this.justpart1();
			this.justpart2();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003CE8 File Offset: 0x00001EE8
		private void justpart1()
		{
			this.conexao();
			byte[] bufferRead = new byte[32];
			this.plc.DBRead(29, 0, bufferRead.Length, bufferRead);
			bufferRead.SetBitAt(30, 0, false);
			bufferRead.SetBitAt(30, 2, false);
			this.plc.DBWrite(29, 0, bufferRead.Length, bufferRead);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003D44 File Offset: 0x00001F44
		private void justpart2()
		{
			DateTime data = default(DateTime);
			TimeSpan time = default(TimeSpan);
			this.conexao();
			byte[] bufferRead = new byte[32];
			this.plc.DBRead(29, 0, bufferRead.Length, bufferRead);
			data = bufferRead.GetDTLAt(0);
			time = bufferRead.GetS7TimespanAt(24);
			this.justificativa.datai = data.ToString();
			this.justificativa.duracao = time.ToString();
			this.justificativa.descricao = this.Tboxjustificativa.Text;
			this.TBoxAlarmesdiag.Text = "";
			this.Tboxjustificativa.Text = "";
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003DF8 File Offset: 0x00001FF8
		private void parte3()
		{
			DateTime data = DateTime.Now;
			TimeSpan time = TimeSpan.Zero;
			this.justificativa.datai = data.ToString();
			this.justificativa.duracao = time.ToString();
			this.justificativa.descricao = this.Tboxjustificativa.Text;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003E54 File Offset: 0x00002054
		private void parte4()
		{
			DateTime data = default(DateTime);
			TimeSpan time = default(TimeSpan);
			this.conexao();
			byte[] bufferRead = new byte[32];
			this.plc.DBRead(29, 0, bufferRead.Length, bufferRead);
			data = bufferRead.GetDTLAt(0);
			time = bufferRead.GetS7TimespanAt(24);
			int codigomotivo = bufferRead.GetIntAt(28);
			this.part5();
			this.justificativa.datai = data.ToString();
			this.justificativa.duracao = time.ToString();
			this.justificativa.descricao = this.devolvecodigodeparada(codigomotivo);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003EF4 File Offset: 0x000020F4
		private string devolvecodigodeparada(int codparadaI)
		{
			string codigodeparadaS;
			switch (codparadaI)
			{
			case 1:
				codigodeparadaS = "Segurança geral";
				break;
			case 2:
				codigodeparadaS = "Segurança Transportador";
				break;
			case 3:
				codigodeparadaS = "Falha no inversor do Transportador";
				break;
			case 4:
				codigodeparadaS = "Sistema desligado via chave";
				break;
			case 5:
				codigodeparadaS = "Botão de parada acionado";
				break;
			case 6:
				codigodeparadaS = "Temperatura abaixo em modo manual";
				break;
			case 7:
				codigodeparadaS = "Sistema em automático desligado pela interface";
				break;
			case 8:
				codigodeparadaS = "Temperatura abaixo em modo automático";
				break;
			case 9:
				codigodeparadaS = "Carro errado, identificado nos sensores";
				break;
			case 10:
				codigodeparadaS = "Tempo de espera excedido na passagem de carros";
				break;
			case 11:
				codigodeparadaS = "Carro não identificado";
				break;
			case 12:
				codigodeparadaS = "Sensores obstruídos";
				break;
			default:
				codigodeparadaS = "Motivo não cadastrado";
				break;
			}
			return codigodeparadaS;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003FB4 File Offset: 0x000021B4
		private void part5()
		{
			this.conexao();
			byte[] bufferRead = new byte[32];
			this.plc.DBRead(29, 0, bufferRead.Length, bufferRead);
			bufferRead.SetBitAt(30, 0, false);
			this.plc.DBWrite(29, 0, bufferRead.Length, bufferRead);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00004004 File Offset: 0x00002204
		private void escrevenalistatxt()
		{
			string arquivo = this.caminho;
			bool flag = !File.Exists(arquivo + "/justificativa.txt");
			if (flag)
			{
				throw new FileNotFoundException("Arquivo " + arquivo + "/justificativa.txt não encontrado");
			}
			StringBuilder container = new StringBuilder();
			using (StreamReader re = File.OpenText(arquivo + "/justificativa.txt"))
			{
				container.Append(re.ReadToEnd());
			}
			bool flag2 = File.Exists(arquivo + "/justificativa.txt");
			if (flag2)
			{
				File.Delete(arquivo + "/justificativa.txt");
			}
			FileInfo t = new FileInfo(arquivo + "/justificativa.txt");
			using (StreamWriter Tex = t.CreateText())
			{
				Tex.Write(Convert.ToString(this.justificativa.id.ToString() + ";"));
				Tex.Write(this.justificativa.descricao + ";");
				Tex.Write(this.justificativa.datai + ";");
				Tex.Write(this.justificativa.duracao + ";");
				Tex.WriteLine(this.justificativa.responsavel + ";");
				Tex.WriteLine(container.ToString());
				Tex.Write(Tex.NewLine);
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000041A4 File Offset: 0x000023A4
		private void button1_Click(object sender, EventArgs e)
		{
			this.conexao();
			this.metodosDeIncializacaodoForm2();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000041B5 File Offset: 0x000023B5
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x04000005 RID: 5
		public const int TAMJUSTIFICATIVAS = 1500;

		// Token: 0x04000006 RID: 6
		public const int NALARME = 48;

		// Token: 0x04000007 RID: 7
		public FrmAlarmes1920x1080.Alarme[] Alarmes = new FrmAlarmes1920x1080.Alarme[48];

		// Token: 0x04000008 RID: 8
		public FrmAlarmes1920x1080.AlarmeAtivos[] AlarmesAtivos = new FrmAlarmes1920x1080.AlarmeAtivos[48];

		// Token: 0x04000009 RID: 9
		public FrmAlarmes1920x1080.Justificativa justificativa = default(FrmAlarmes1920x1080.Justificativa);

		// Token: 0x0400000A RID: 10
		public FrmAlarmes1920x1080.Justificativa[] jler = new FrmAlarmes1920x1080.Justificativa[1500];

		// Token: 0x0400000B RID: 11
		private S7Client plc = new S7Client();

		// Token: 0x0400000C RID: 12
		public int contadordealarmesativos;

		// Token: 0x0400000D RID: 13
		public string caminho = Environment.CurrentDirectory;

		// Token: 0x0400000E RID: 14
		public int tempo = 0;

		// Token: 0x0400000F RID: 15
		public int tempoinicial = 0;

		// Token: 0x04000010 RID: 16
		public int tempojustificativa = 0;

		// Token: 0x04000011 RID: 17
		public bool conectado = false;

		// Token: 0x04000012 RID: 18
		public bool aguardandojustificativa = false;

		// Token: 0x04000013 RID: 19
		public int contadorjustificativas = 0;

		// Token: 0x04000014 RID: 20
		public int ultimocarro;

		// Token: 0x04000015 RID: 21
		public bool AlarmeCarroErrado;

		// Token: 0x04000016 RID: 22
		public int niveldeacesso = 0;

		// Token: 0x04000017 RID: 23
		public bool modojustificativa = false;

		// Token: 0x04000018 RID: 24
		public const int NBY19 = 4;

		// Token: 0x04000019 RID: 25
		public const int NBY26 = 2;

		// Token: 0x0400001A RID: 26
		public const int NBY29 = 32;

		// Token: 0x0400001E RID: 30
		private ColumnHeader ColCodigo;

		// Token: 0x0400001F RID: 31
		private ColumnHeader ColReceita;

		// Token: 0x04000020 RID: 32
		private ColumnHeader columnHeader1;

		// Token: 0x04000023 RID: 35
		private ColumnHeader columnHeader6;

		// Token: 0x04000024 RID: 36
		private ColumnHeader columnHeader7;

		// Token: 0x04000025 RID: 37
		private ColumnHeader columnHeader2;

		// Token: 0x04000041 RID: 65
		private ColumnHeader DataFim;

		// Token: 0x02000013 RID: 19
		public struct Alarme
		{
			// Token: 0x04000334 RID: 820
			public int id;

			// Token: 0x04000335 RID: 821
			public string nalarme;

			// Token: 0x04000336 RID: 822
			public bool estado;

			// Token: 0x04000337 RID: 823
			public string data;

			// Token: 0x04000338 RID: 824
			public bool LigadoA;
		}

		// Token: 0x02000014 RID: 20
		public struct AlarmeAtivos
		{
			// Token: 0x04000339 RID: 825
			public int id;

			// Token: 0x0400033A RID: 826
			public string nalarme;

			// Token: 0x0400033B RID: 827
			public bool estado;

			// Token: 0x0400033C RID: 828
			public string data;

			// Token: 0x0400033D RID: 829
			public bool LigadoA;
		}

		// Token: 0x02000015 RID: 21
		public struct Justificativa
		{
			// Token: 0x0400033E RID: 830
			public int id;

			// Token: 0x0400033F RID: 831
			public string descricao;

			// Token: 0x04000340 RID: 832
			public string datai;

			// Token: 0x04000341 RID: 833
			public string duracao;

			// Token: 0x04000342 RID: 834
			public string responsavel;
		}
	}
}
