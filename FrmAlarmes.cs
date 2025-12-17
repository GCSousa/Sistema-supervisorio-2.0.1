using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Sharp7;
using SupervisorioDana.Properties;

namespace SupervisorioDana
{
	// Token: 0x0200000B RID: 11
	public partial class FrmAlarmes : Form
	{
		// Token: 0x060000E1 RID: 225 RVA: 0x0001DA38 File Offset: 0x0001BC38
		public FrmAlarmes()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0001DAE0 File Offset: 0x0001BCE0
		private void leCLPCarro()
		{
			this.conexao();
			byte[] bufferRead = new byte[4];
			this.plc.DBRead(19, 0, bufferRead.Length, bufferRead);
			int nDadoDBcorrente = 0;
			this.ultimocarro = bufferRead.GetIntAt(nDadoDBcorrente);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0001DB20 File Offset: 0x0001BD20
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

		// Token: 0x060000E4 RID: 228 RVA: 0x0001DBE0 File Offset: 0x0001BDE0
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

		// Token: 0x060000E5 RID: 229 RVA: 0x0001DC78 File Offset: 0x0001BE78
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

		// Token: 0x060000E6 RID: 230 RVA: 0x0001DCCC File Offset: 0x0001BECC
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

		// Token: 0x060000E7 RID: 231 RVA: 0x0001DD40 File Offset: 0x0001BF40
		private void pedeparaclpatualizarcarro()
		{
			this.conexao();
			bool ligabitcarro = true;
			byte[] bufferRead = new byte[2];
			this.plc.DBRead(26, 0, bufferRead.Length, bufferRead);
			bufferRead.SetBitAt(0, 3, ligabitcarro);
			this.plc.DBWrite(26, 0, bufferRead.Length, bufferRead);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0001DD90 File Offset: 0x0001BF90
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

		// Token: 0x060000E9 RID: 233 RVA: 0x0001DE44 File Offset: 0x0001C044
		private void nivelum()
		{
			this.BtnAtualizarCarro.Enabled = false;
			this.TBoxAtualizaCarro.Enabled = false;
			this.BtnRearmar.Enabled = false;
			this.Tboxjustificativa.Enabled = false;
			this.BtnSalvar.Enabled = false;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0001DE93 File Offset: 0x0001C093
		private void niveldois()
		{
			this.TBoxAtualizaCarro.Enabled = true;
			this.BtnAtualizarCarro.Enabled = true;
			this.BtnAtualizarCarro.BackColor = Color.FromArgb(68, 180, 74);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0001DECC File Offset: 0x0001C0CC
		private void niveltres()
		{
			this.BtnRearmar.Enabled = true;
			this.Tboxjustificativa.Enabled = true;
			this.BtnRearmar.BackColor = Color.FromArgb(68, 180, 74);
			this.TBoxAtualizaCarro.Enabled = true;
			this.BtnAtualizarCarro.Enabled = true;
			this.BtnAtualizarCarro.BackColor = Color.FromArgb(68, 180, 74);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0001DF44 File Offset: 0x0001C144
		private void ListaIDAlarmes()
		{
			for (int i = 0; i < 48; i++)
			{
				this.Alarmes[i].id = i;
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0001DF78 File Offset: 0x0001C178
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

		// Token: 0x060000EE RID: 238 RVA: 0x0001E038 File Offset: 0x0001C238
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

		// Token: 0x060000EF RID: 239 RVA: 0x0001E2EC File Offset: 0x0001C4EC
		private void FrmAlarmes_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0001E2F0 File Offset: 0x0001C4F0
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

		// Token: 0x060000F1 RID: 241 RVA: 0x0001E36C File Offset: 0x0001C56C
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

		// Token: 0x060000F2 RID: 242 RVA: 0x0001E3E4 File Offset: 0x0001C5E4
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

		// Token: 0x060000F3 RID: 243 RVA: 0x0001E430 File Offset: 0x0001C630
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

		// Token: 0x060000F4 RID: 244 RVA: 0x0001E500 File Offset: 0x0001C700
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

		// Token: 0x060000F5 RID: 245 RVA: 0x0001E5A0 File Offset: 0x0001C7A0
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

		// Token: 0x060000F6 RID: 246 RVA: 0x0001E61C File Offset: 0x0001C81C
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

		// Token: 0x060000F7 RID: 247 RVA: 0x0001E6A3 File Offset: 0x0001C8A3
		private void LimpaListaAlarmes()
		{
			this.ListaAlarmes.Items.Clear();
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0001E6B8 File Offset: 0x0001C8B8
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

		// Token: 0x060000F9 RID: 249 RVA: 0x0001E74C File Offset: 0x0001C94C
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

		// Token: 0x060000FA RID: 250 RVA: 0x0001E7DD File Offset: 0x0001C9DD
		public void LimpaListaAtivos()
		{
			this.ListaAlarmesAtivos.Items.Clear();
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0001E7F1 File Offset: 0x0001C9F1
		private void FrmAlarmes_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0001E7FC File Offset: 0x0001C9FC
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

		// Token: 0x060000FD RID: 253 RVA: 0x0001E9BB File Offset: 0x0001CBBB
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0001E9C8 File Offset: 0x0001CBC8
		private void BtnAlarme_Click(object sender, EventArgs e)
		{
			base.Hide();
			FrmDadosDosCarros frmDadosDosCarros = new FrmDadosDosCarros();
			frmDadosDosCarros.ShowDialog();
			this.timer1.Stop();
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0001E9F8 File Offset: 0x0001CBF8
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

		// Token: 0x06000100 RID: 256 RVA: 0x0001EA40 File Offset: 0x0001CC40
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

		// Token: 0x06000101 RID: 257 RVA: 0x0001EA84 File Offset: 0x0001CC84
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

		// Token: 0x06000102 RID: 258 RVA: 0x0001EBB4 File Offset: 0x0001CDB4
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

		// Token: 0x06000103 RID: 259 RVA: 0x0001EC0C File Offset: 0x0001CE0C
		private string leparametrojustificativa()
		{
			string parametro;
			using (StreamReader sr = new StreamReader(this.caminho + "/prog_dana_controle_rede.txt"))
			{
				parametro = sr.ReadLine();
			}
			return parametro;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0001EC5C File Offset: 0x0001CE5C
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

		// Token: 0x06000105 RID: 261 RVA: 0x0001ED14 File Offset: 0x0001CF14
		private void escreveCLPAlarmeRearmado()
		{
			this.conexao();
			byte[] bufferRead = new byte[2];
			this.plc.DBRead(26, 0, bufferRead.Length, bufferRead);
			bufferRead.SetBitAt(0, 2, true);
			this.plc.DBWrite(26, 0, bufferRead.Length, bufferRead);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0001ED60 File Offset: 0x0001CF60
		private void BtnSalvar_Click(object sender, EventArgs e)
		{
			this.VerificaTxt();
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0001ED6C File Offset: 0x0001CF6C
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

		// Token: 0x06000108 RID: 264 RVA: 0x0001F148 File Offset: 0x0001D348
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

		// Token: 0x06000109 RID: 265 RVA: 0x0001F1EC File Offset: 0x0001D3EC
		private void justificativapendentesolicitada()
		{
			this.ligabotoesalarme();
			this.escrevetxtalarmeacionado();
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0001F1FD File Offset: 0x0001D3FD
		private void paradaregistradaregistradaativa()
		{
			this.desligabotoesalarme();
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0001F208 File Offset: 0x0001D408
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

		// Token: 0x0600010C RID: 268 RVA: 0x0001F2CC File Offset: 0x0001D4CC
		private bool parte1()
		{
			this.conexao();
			byte[] bufferRead = new byte[32];
			this.plc.DBRead(29, 0, bufferRead.Length, bufferRead);
			bool justificativa_pendente = bufferRead.GetBitAt(30, 2);
			bool parada_registrada = bufferRead.GetBitAt(30, 0);
			return justificativa_pendente;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0001F31C File Offset: 0x0001D51C
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

		// Token: 0x0600010E RID: 270 RVA: 0x0001F38F File Offset: 0x0001D58F
		private void resolucaojustificativa()
		{
			this.justpart1();
			this.justpart2();
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0001F3A0 File Offset: 0x0001D5A0
		private void justpart1()
		{
			this.conexao();
			byte[] bufferRead = new byte[32];
			this.plc.DBRead(29, 0, bufferRead.Length, bufferRead);
			bufferRead.SetBitAt(30, 0, false);
			bufferRead.SetBitAt(30, 2, false);
			this.plc.DBWrite(29, 0, bufferRead.Length, bufferRead);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0001F3FC File Offset: 0x0001D5FC
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

		// Token: 0x06000111 RID: 273 RVA: 0x0001F4B0 File Offset: 0x0001D6B0
		private void parte3()
		{
			DateTime data = DateTime.Now;
			TimeSpan time = TimeSpan.Zero;
			this.justificativa.datai = data.ToString();
			this.justificativa.duracao = time.ToString();
			this.justificativa.descricao = this.Tboxjustificativa.Text;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0001F50C File Offset: 0x0001D70C
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

		// Token: 0x06000113 RID: 275 RVA: 0x0001F5AC File Offset: 0x0001D7AC
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

		// Token: 0x06000114 RID: 276 RVA: 0x0001F66C File Offset: 0x0001D86C
		private void part5()
		{
			this.conexao();
			byte[] bufferRead = new byte[32];
			this.plc.DBRead(29, 0, bufferRead.Length, bufferRead);
			bufferRead.SetBitAt(30, 0, false);
			this.plc.DBWrite(29, 0, bufferRead.Length, bufferRead);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0001F6BC File Offset: 0x0001D8BC
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

		// Token: 0x06000116 RID: 278 RVA: 0x0001F85C File Offset: 0x0001DA5C
		private void button1_Click(object sender, EventArgs e)
		{
			this.conexao();
			this.metodosDeIncializacaodoForm2();
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0001F86D File Offset: 0x0001DA6D
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0400019D RID: 413
		public const int TAMJUSTIFICATIVAS = 1500;

		// Token: 0x0400019E RID: 414
		public const int NALARME = 48;

		// Token: 0x0400019F RID: 415
		public FrmAlarmes.Alarme[] Alarmes = new FrmAlarmes.Alarme[48];

		// Token: 0x040001A0 RID: 416
		public FrmAlarmes.AlarmeAtivos[] AlarmesAtivos = new FrmAlarmes.AlarmeAtivos[48];

		// Token: 0x040001A1 RID: 417
		public FrmAlarmes.Justificativa justificativa = default(FrmAlarmes.Justificativa);

		// Token: 0x040001A2 RID: 418
		public FrmAlarmes.Justificativa[] jler = new FrmAlarmes.Justificativa[1500];

		// Token: 0x040001A3 RID: 419
		private S7Client plc = new S7Client();

		// Token: 0x040001A4 RID: 420
		public int contadordealarmesativos;

		// Token: 0x040001A5 RID: 421
		public string caminho = Environment.CurrentDirectory;

		// Token: 0x040001A6 RID: 422
		public int tempo = 0;

		// Token: 0x040001A7 RID: 423
		public int tempoinicial = 0;

		// Token: 0x040001A8 RID: 424
		public int tempojustificativa = 0;

		// Token: 0x040001A9 RID: 425
		public bool conectado = false;

		// Token: 0x040001AA RID: 426
		public bool aguardandojustificativa = false;

		// Token: 0x040001AB RID: 427
		public int contadorjustificativas = 0;

		// Token: 0x040001AC RID: 428
		public int ultimocarro;

		// Token: 0x040001AD RID: 429
		public bool AlarmeCarroErrado;

		// Token: 0x040001AE RID: 430
		public int niveldeacesso = 0;

		// Token: 0x040001AF RID: 431
		public bool modojustificativa = false;

		// Token: 0x040001B0 RID: 432
		public const int NBY19 = 4;

		// Token: 0x040001B1 RID: 433
		public const int NBY26 = 2;

		// Token: 0x040001B2 RID: 434
		public const int NBY29 = 32;

		// Token: 0x040001B6 RID: 438
		private ColumnHeader ColCodigo;

		// Token: 0x040001B7 RID: 439
		private ColumnHeader ColReceita;

		// Token: 0x040001B8 RID: 440
		private ColumnHeader columnHeader1;

		// Token: 0x040001BB RID: 443
		private ColumnHeader columnHeader6;

		// Token: 0x040001BC RID: 444
		private ColumnHeader columnHeader7;

		// Token: 0x040001BD RID: 445
		private ColumnHeader columnHeader2;

		// Token: 0x040001D9 RID: 473
		private ColumnHeader DataFim;

		// Token: 0x02000023 RID: 35
		public struct Alarme
		{
			// Token: 0x04000396 RID: 918
			public int id;

			// Token: 0x04000397 RID: 919
			public string nalarme;

			// Token: 0x04000398 RID: 920
			public bool estado;

			// Token: 0x04000399 RID: 921
			public string data;

			// Token: 0x0400039A RID: 922
			public bool LigadoA;
		}

		// Token: 0x02000024 RID: 36
		public struct AlarmeAtivos
		{
			// Token: 0x0400039B RID: 923
			public int id;

			// Token: 0x0400039C RID: 924
			public string nalarme;

			// Token: 0x0400039D RID: 925
			public bool estado;

			// Token: 0x0400039E RID: 926
			public string data;

			// Token: 0x0400039F RID: 927
			public bool LigadoA;
		}

		// Token: 0x02000025 RID: 37
		public struct Justificativa
		{
			// Token: 0x040003A0 RID: 928
			public int id;

			// Token: 0x040003A1 RID: 929
			public string descricao;

			// Token: 0x040003A2 RID: 930
			public string datai;

			// Token: 0x040003A3 RID: 931
			public string duracao;

			// Token: 0x040003A4 RID: 932
			public string responsavel;
		}
	}
}
