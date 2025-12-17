using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Sharp7;
using SupervisorioDana.Properties;

namespace SupervisorioDana
{
	// Token: 0x02000011 RID: 17
	public partial class visual : Form
	{
		// Token: 0x060001A2 RID: 418 RVA: 0x0002C290 File Offset: 0x0002A490
		public visual()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0002C2DF File Offset: 0x0002A4DF
		private void grafico_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0002C2E4 File Offset: 0x0002A4E4
		private void visual_Shown(object sender, EventArgs e)
		{
			base.Hide();
			Carregando telatemp = new Carregando();
			telatemp.Show();
			this.conexao();
			bool flag = this.conectado;
			if (flag)
			{
				this.metodosciclicos();
				this.tempo = 0;
				this.timer1.Start();
			}
			telatemp.Hide();
			base.Show();
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0002C341 File Offset: 0x0002A541
		private void metodosciclicos()
		{
			this.preenchecarroCLP();
			this.ordenacarros();
			this.mudacorcarro();
			this.atualizaboxcarro();
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0002C360 File Offset: 0x0002A560
		private void preenchecarroCLP()
		{
			this.conexao();
			byte[] bufferRead = new byte[3102];
			this.plc.DBRead(20, 0, bufferRead.Length, bufferRead);
			for (int i = 0; i < 33; i++)
			{
				int nDadoDBcorrente = i * 94;
				this.carro[i].IdCarro = bufferRead.GetIntAt(nDadoDBcorrente);
				this.carro[i].PosicaoCarro = (double)bufferRead.GetRealAt(2 + nDadoDBcorrente);
				this.carro[i].Status = bufferRead.GetIntAt(6 + nDadoDBcorrente);
				this.carro[i].QuantidadeCarro = bufferRead.GetIntAt(8 + nDadoDBcorrente);
				this.carro[i].DescricaoProduto = bufferRead.GetStringAt(10 + nDadoDBcorrente);
				this.carro[i].CodigoModeloProduto = bufferRead.GetStringAt(38 + nDadoDBcorrente);
				this.carro[i].NomeDaReceita = bufferRead.GetStringAt(60 + nDadoDBcorrente);
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0002C46C File Offset: 0x0002A66C
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
				this.conectado = true;
			}
			else
			{
				bool flag2 = chamado_limite == 2;
				if (flag2)
				{
					this.conectado = false;
				}
				else
				{
					this.conectado = false;
				}
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0002C4D8 File Offset: 0x0002A6D8
		private void ordenacarros()
		{
			int countflag = 0;
			int contadortrintaetres = 0;
			int poscarrozero = 0;
			bool flagcarro = false;
			while (!flagcarro)
			{
				bool flag = this.carro[countflag].PosicaoCarro == 0.0;
				if (flag)
				{
					poscarrozero = countflag;
					flagcarro = true;
				}
				else
				{
					countflag++;
				}
			}
			int poscarrocorrente = poscarrozero;
			while (contadortrintaetres < 33)
			{
				bool flag2 = poscarrocorrente >= 33;
				if (flag2)
				{
					poscarrocorrente = 0;
				}
				this.carroordenado[contadortrintaetres] = this.carro[poscarrocorrente];
				this.carroordenado[contadortrintaetres].setor = this.selecionasetor(this.carro[poscarrocorrente].PosicaoCarro);
				this.carroordenado[contadortrintaetres].PosicaoCarro = Math.Round(this.carroordenado[contadortrintaetres].PosicaoCarro, 1);
				poscarrocorrente++;
				contadortrintaetres++;
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0002C5C8 File Offset: 0x0002A7C8
		private void BtnInicio_Click(object sender, EventArgs e)
		{
			base.Hide();
			FrmDadosDosCarros frmDadosDosCarros = new FrmDadosDosCarros();
			frmDadosDosCarros.ShowDialog();
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0002C5EA File Offset: 0x0002A7EA
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0002C5F4 File Offset: 0x0002A7F4
		private void mudacorcarro()
		{
			bool flag = this.carroordenado[0].Status == 0;
			if (flag)
			{
				this.Car1.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag2 = this.carroordenado[0].Status == 1;
				if (flag2)
				{
					this.Car1.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car1.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag3 = this.carroordenado[32].Status == 0;
			if (flag3)
			{
				this.Car2.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag4 = this.carroordenado[32].Status == 1;
				if (flag4)
				{
					this.Car2.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car2.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag5 = this.carroordenado[31].Status == 0;
			if (flag5)
			{
				this.Car3.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag6 = this.carroordenado[31].Status == 1;
				if (flag6)
				{
					this.Car3.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car3.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag7 = this.carroordenado[30].Status == 0;
			if (flag7)
			{
				this.Car4.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag8 = this.carroordenado[30].Status == 1;
				if (flag8)
				{
					this.Car4.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car4.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag9 = this.carroordenado[29].Status == 0;
			if (flag9)
			{
				this.Car5.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag10 = this.carroordenado[29].Status == 1;
				if (flag10)
				{
					this.Car5.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car5.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag11 = this.carroordenado[28].Status == 0;
			if (flag11)
			{
				this.Car6.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag12 = this.carroordenado[28].Status == 1;
				if (flag12)
				{
					this.Car6.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car6.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag13 = this.carroordenado[27].Status == 0;
			if (flag13)
			{
				this.Car7.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag14 = this.carroordenado[27].Status == 1;
				if (flag14)
				{
					this.Car7.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car7.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag15 = this.carroordenado[26].Status == 0;
			if (flag15)
			{
				this.Car8.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag16 = this.carroordenado[26].Status == 1;
				if (flag16)
				{
					this.Car8.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car8.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag17 = this.carroordenado[25].Status == 0;
			if (flag17)
			{
				this.Car9.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag18 = this.carroordenado[25].Status == 1;
				if (flag18)
				{
					this.Car9.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car9.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag19 = this.carroordenado[24].Status == 0;
			if (flag19)
			{
				this.Car10.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag20 = this.carroordenado[24].Status == 1;
				if (flag20)
				{
					this.Car10.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car10.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag21 = this.carroordenado[23].Status == 0;
			if (flag21)
			{
				this.Car11.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag22 = this.carroordenado[23].Status == 1;
				if (flag22)
				{
					this.Car11.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car11.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag23 = this.carroordenado[22].Status == 0;
			if (flag23)
			{
				this.Car12.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag24 = this.carroordenado[22].Status == 1;
				if (flag24)
				{
					this.Car12.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car12.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag25 = this.carroordenado[21].Status == 0;
			if (flag25)
			{
				this.Car13.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag26 = this.carroordenado[21].Status == 1;
				if (flag26)
				{
					this.Car13.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car13.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag27 = this.carroordenado[20].Status == 0;
			if (flag27)
			{
				this.Car14.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag28 = this.carroordenado[20].Status == 1;
				if (flag28)
				{
					this.Car14.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car14.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag29 = this.carroordenado[19].Status == 0;
			if (flag29)
			{
				this.Car15.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag30 = this.carroordenado[19].Status == 1;
				if (flag30)
				{
					this.Car15.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car15.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag31 = this.carroordenado[18].Status == 0;
			if (flag31)
			{
				this.Car16.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag32 = this.carroordenado[18].Status == 1;
				if (flag32)
				{
					this.Car16.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car16.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag33 = this.carroordenado[17].Status == 0;
			if (flag33)
			{
				this.Car17.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag34 = this.carroordenado[17].Status == 1;
				if (flag34)
				{
					this.Car17.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car17.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag35 = this.carroordenado[16].Status == 0;
			if (flag35)
			{
				this.Car18.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag36 = this.carroordenado[16].Status == 1;
				if (flag36)
				{
					this.Car18.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car18.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag37 = this.carroordenado[15].Status == 0;
			if (flag37)
			{
				this.Car19.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag38 = this.carroordenado[15].Status == 1;
				if (flag38)
				{
					this.Car19.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car19.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag39 = this.carroordenado[14].Status == 0;
			if (flag39)
			{
				this.Car20.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag40 = this.carroordenado[14].Status == 1;
				if (flag40)
				{
					this.Car20.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car20.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag41 = this.carroordenado[13].Status == 0;
			if (flag41)
			{
				this.Car21.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag42 = this.carroordenado[13].Status == 1;
				if (flag42)
				{
					this.Car21.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car21.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag43 = this.carroordenado[12].Status == 0;
			if (flag43)
			{
				this.Car22.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag44 = this.carroordenado[12].Status == 1;
				if (flag44)
				{
					this.Car22.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car22.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag45 = this.carroordenado[11].Status == 0;
			if (flag45)
			{
				this.Car23.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag46 = this.carroordenado[11].Status == 1;
				if (flag46)
				{
					this.Car23.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car23.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag47 = this.carroordenado[10].Status == 0;
			if (flag47)
			{
				this.Car24.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag48 = this.carroordenado[10].Status == 1;
				if (flag48)
				{
					this.Car24.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car24.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag49 = this.carroordenado[9].Status == 0;
			if (flag49)
			{
				this.Car25.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag50 = this.carroordenado[9].Status == 1;
				if (flag50)
				{
					this.Car25.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car25.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag51 = this.carroordenado[8].Status == 0;
			if (flag51)
			{
				this.Car26.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag52 = this.carroordenado[8].Status == 1;
				if (flag52)
				{
					this.Car26.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car26.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag53 = this.carroordenado[7].Status == 0;
			if (flag53)
			{
				this.Car27.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag54 = this.carroordenado[7].Status == 1;
				if (flag54)
				{
					this.Car27.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car27.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag55 = this.carroordenado[6].Status == 0;
			if (flag55)
			{
				this.Car28.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag56 = this.carroordenado[6].Status == 1;
				if (flag56)
				{
					this.Car28.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car28.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag57 = this.carroordenado[5].Status == 0;
			if (flag57)
			{
				this.Car29.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag58 = this.carroordenado[5].Status == 1;
				if (flag58)
				{
					this.Car29.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car29.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag59 = this.carroordenado[4].Status == 0;
			if (flag59)
			{
				this.Car30.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag60 = this.carroordenado[4].Status == 1;
				if (flag60)
				{
					this.Car30.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car30.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag61 = this.carroordenado[3].Status == 0;
			if (flag61)
			{
				this.Car31.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag62 = this.carroordenado[3].Status == 1;
				if (flag62)
				{
					this.Car31.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car31.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag63 = this.carroordenado[2].Status == 0;
			if (flag63)
			{
				this.Car32.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag64 = this.carroordenado[2].Status == 1;
				if (flag64)
				{
					this.Car32.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car32.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
			bool flag65 = this.carroordenado[1].Status == 0;
			if (flag65)
			{
				this.Car33.BackColor = Color.FromArgb(56, 79, 97);
			}
			else
			{
				bool flag66 = this.carroordenado[1].Status == 1;
				if (flag66)
				{
					this.Car33.BackColor = Color.FromArgb(68, 180, 74);
				}
				else
				{
					this.Car33.BackColor = Color.FromArgb(9, 37, 60);
				}
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0002D770 File Offset: 0x0002B970
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

		// Token: 0x060001AD RID: 429 RVA: 0x0002DA44 File Offset: 0x0002BC44
		private void atualizaboxcarro()
		{
			this.TBox33.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[1].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[1].setor,
				"\r\n",
				this.carroordenado[1].DescricaoProduto,
				"\r\n",
				this.carroordenado[1].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[1].QuantidadeCarro.ToString()
			});
			this.TBox32.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[2].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[2].setor,
				"\r\n",
				this.carroordenado[2].DescricaoProduto,
				"\r\n",
				this.carroordenado[2].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[2].QuantidadeCarro.ToString()
			});
			this.TBox31.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[3].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[3].setor,
				"\r\n",
				this.carroordenado[3].DescricaoProduto,
				"\r\n",
				this.carroordenado[3].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[3].QuantidadeCarro.ToString()
			});
			this.TBox30.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[4].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[4].setor,
				"\r\n",
				this.carroordenado[4].DescricaoProduto,
				"\r\n",
				this.carroordenado[4].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[4].QuantidadeCarro.ToString()
			});
			this.TBox29.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[5].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[5].setor,
				"\r\n",
				this.carroordenado[5].DescricaoProduto,
				"\r\n",
				this.carroordenado[5].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[5].QuantidadeCarro.ToString()
			});
			this.TBox28.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[6].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[6].setor,
				"\r\n",
				this.carroordenado[6].DescricaoProduto,
				"\r\n",
				this.carroordenado[6].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[6].QuantidadeCarro.ToString()
			});
			this.TBox27.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[7].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[7].setor,
				"\r\n",
				this.carroordenado[7].DescricaoProduto,
				"\r\n",
				this.carroordenado[7].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[7].QuantidadeCarro.ToString()
			});
			this.TBox26.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[8].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[8].setor,
				"\r\n",
				this.carroordenado[8].DescricaoProduto,
				"\r\n",
				this.carroordenado[8].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[8].QuantidadeCarro.ToString()
			});
			this.TBox25.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[9].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[9].setor,
				"\r\n",
				this.carroordenado[9].DescricaoProduto,
				"\r\n",
				this.carroordenado[9].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[9].QuantidadeCarro.ToString()
			});
			this.TBox24.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[10].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[10].setor,
				"\r\n",
				this.carroordenado[10].DescricaoProduto,
				"\r\n",
				this.carroordenado[10].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[10].QuantidadeCarro.ToString()
			});
			this.TBox23.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[11].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[11].setor,
				"\r\n",
				this.carroordenado[11].DescricaoProduto,
				"\r\n",
				this.carroordenado[11].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[11].QuantidadeCarro.ToString()
			});
			this.TBox22.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[12].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[12].setor,
				"\r\n",
				this.carroordenado[12].DescricaoProduto,
				"\r\n",
				this.carroordenado[12].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[12].QuantidadeCarro.ToString()
			});
			this.TBox21.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[13].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[13].setor,
				"\r\n",
				this.carroordenado[13].DescricaoProduto,
				"\r\n",
				this.carroordenado[13].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[13].QuantidadeCarro.ToString()
			});
			this.TBox20.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[14].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[14].setor,
				"\r\n",
				this.carroordenado[14].DescricaoProduto,
				"\r\n",
				this.carroordenado[14].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[14].QuantidadeCarro.ToString()
			});
			this.TBox19.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[15].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[15].setor,
				"\r\n",
				this.carroordenado[15].DescricaoProduto,
				"\r\n",
				this.carroordenado[15].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[15].QuantidadeCarro.ToString()
			});
			this.TBox18.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[16].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[16].setor,
				"\r\n",
				this.carroordenado[16].DescricaoProduto,
				"\r\n",
				this.carroordenado[16].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[16].QuantidadeCarro.ToString()
			});
			this.TBox17.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[17].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[17].setor,
				"\r\n",
				this.carroordenado[17].DescricaoProduto,
				"\r\n",
				this.carroordenado[17].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[17].QuantidadeCarro.ToString()
			});
			this.TBox16.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[18].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[18].setor,
				"\r\n",
				this.carroordenado[18].DescricaoProduto,
				"\r\n",
				this.carroordenado[18].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[18].QuantidadeCarro.ToString()
			});
			this.TBox15.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[19].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[19].setor,
				"\r\n",
				this.carroordenado[19].DescricaoProduto,
				"\r\n",
				this.carroordenado[19].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[19].QuantidadeCarro.ToString()
			});
			this.TBox14.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[20].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[20].setor,
				"\r\n",
				this.carroordenado[20].DescricaoProduto,
				"\r\n",
				this.carroordenado[20].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[20].QuantidadeCarro.ToString()
			});
			this.TBox13.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[21].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[21].setor,
				"\r\n",
				this.carroordenado[21].DescricaoProduto,
				"\r\n",
				this.carroordenado[21].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[21].QuantidadeCarro.ToString()
			});
			this.TBox12.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[22].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[22].setor,
				"\r\n",
				this.carroordenado[22].DescricaoProduto,
				"\r\n",
				this.carroordenado[22].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[22].QuantidadeCarro.ToString()
			});
			this.TBox11.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[23].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[23].setor,
				"\r\n",
				this.carroordenado[23].DescricaoProduto,
				"\r\n",
				this.carroordenado[23].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[23].QuantidadeCarro.ToString()
			});
			this.TBox10.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[24].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[24].setor,
				"\r\n",
				this.carroordenado[24].DescricaoProduto,
				"\r\n",
				this.carroordenado[24].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[24].QuantidadeCarro.ToString()
			});
			this.TBox9.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[25].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[25].setor,
				"\r\n",
				this.carroordenado[25].DescricaoProduto,
				"\r\n",
				this.carroordenado[25].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[25].QuantidadeCarro.ToString()
			});
			this.TBox8.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[26].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[26].setor,
				"\r\n",
				this.carroordenado[26].DescricaoProduto,
				"\r\n",
				this.carroordenado[26].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[26].QuantidadeCarro.ToString()
			});
			this.TBox7.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[27].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[27].setor,
				"\r\n",
				this.carroordenado[27].DescricaoProduto,
				"\r\n",
				this.carroordenado[27].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[27].QuantidadeCarro.ToString()
			});
			this.TBox6.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[28].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[28].setor,
				"\r\n",
				this.carroordenado[28].DescricaoProduto,
				"\r\n",
				this.carroordenado[28].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[28].QuantidadeCarro.ToString()
			});
			this.TBox5.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[29].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[29].setor,
				"\r\n",
				this.carroordenado[29].DescricaoProduto,
				"\r\n",
				this.carroordenado[29].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[29].QuantidadeCarro.ToString()
			});
			this.TBox4.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[30].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[30].setor,
				"\r\n",
				this.carroordenado[30].DescricaoProduto,
				"\r\n",
				this.carroordenado[30].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[30].QuantidadeCarro.ToString()
			});
			this.TBox3.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[31].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[31].setor,
				"\r\n",
				this.carroordenado[31].DescricaoProduto,
				"\r\n",
				this.carroordenado[31].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[31].QuantidadeCarro.ToString()
			});
			this.TBox2.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[32].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[32].setor,
				"\r\n",
				this.carroordenado[32].DescricaoProduto,
				"\r\n",
				this.carroordenado[32].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[32].QuantidadeCarro.ToString()
			});
			this.TBox1.Text = string.Concat(new string[]
			{
				"\r\n",
				this.carroordenado[0].PosicaoCarro.ToString(),
				"\r\n",
				this.carroordenado[0].setor,
				"\r\n",
				this.carroordenado[0].DescricaoProduto,
				"\r\n",
				this.carroordenado[0].CodigoModeloProduto,
				"\r\n",
				this.carroordenado[0].QuantidadeCarro.ToString()
			});
			this.Car33.Text = this.carroordenado[1].IdCarro.ToString();
			this.Car32.Text = this.carroordenado[2].IdCarro.ToString();
			this.Car31.Text = this.carroordenado[3].IdCarro.ToString();
			this.Car30.Text = this.carroordenado[4].IdCarro.ToString();
			this.Car29.Text = this.carroordenado[5].IdCarro.ToString();
			this.Car28.Text = this.carroordenado[6].IdCarro.ToString();
			this.Car27.Text = this.carroordenado[7].IdCarro.ToString();
			this.Car26.Text = this.carroordenado[8].IdCarro.ToString();
			this.Car25.Text = this.carroordenado[9].IdCarro.ToString();
			this.Car24.Text = this.carroordenado[10].IdCarro.ToString();
			this.Car23.Text = this.carroordenado[11].IdCarro.ToString();
			this.Car22.Text = this.carroordenado[12].IdCarro.ToString();
			this.Car21.Text = this.carroordenado[13].IdCarro.ToString();
			this.Car20.Text = this.carroordenado[14].IdCarro.ToString();
			this.Car19.Text = this.carroordenado[15].IdCarro.ToString();
			this.Car18.Text = this.carroordenado[16].IdCarro.ToString();
			this.Car17.Text = this.carroordenado[17].IdCarro.ToString();
			this.Car16.Text = this.carroordenado[18].IdCarro.ToString();
			this.Car15.Text = this.carroordenado[19].IdCarro.ToString();
			this.Car14.Text = this.carroordenado[20].IdCarro.ToString();
			this.Car13.Text = this.carroordenado[21].IdCarro.ToString();
			this.Car12.Text = this.carroordenado[22].IdCarro.ToString();
			this.Car11.Text = this.carroordenado[23].IdCarro.ToString();
			this.Car10.Text = this.carroordenado[24].IdCarro.ToString();
			this.Car9.Text = this.carroordenado[25].IdCarro.ToString();
			this.Car8.Text = this.carroordenado[26].IdCarro.ToString();
			this.Car7.Text = this.carroordenado[27].IdCarro.ToString();
			this.Car6.Text = this.carroordenado[28].IdCarro.ToString();
			this.Car5.Text = this.carroordenado[29].IdCarro.ToString();
			this.Car4.Text = this.carroordenado[30].IdCarro.ToString();
			this.Car3.Text = this.carroordenado[31].IdCarro.ToString();
			this.Car2.Text = this.carroordenado[32].IdCarro.ToString();
			this.Car1.Text = this.carroordenado[0].IdCarro.ToString();
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0002F5D4 File Offset: 0x0002D7D4
		private void abrirvisualcarro()
		{
			this.TBox1.Visible = true;
			this.TBox1n.Visible = true;
			this.TBox2.Visible = true;
			this.TBox2n.Visible = true;
			this.TBox3.Visible = true;
			this.TBox3n.Visible = true;
			this.TBox4.Visible = true;
			this.TBox4n.Visible = true;
			this.TBox5.Visible = true;
			this.TBox5n.Visible = true;
			this.TBox6.Visible = true;
			this.TBox6n.Visible = true;
			this.TBox7.Visible = true;
			this.TBox7n.Visible = true;
			this.TBox8.Visible = true;
			this.TBox8n.Visible = true;
			this.TBox33.Visible = true;
			this.TBox33n.Visible = true;
			this.TBox32.Visible = true;
			this.TBox32n.Visible = true;
			this.TBox31.Visible = true;
			this.TBox31n.Visible = true;
			this.TBox30.Visible = true;
			this.TBox30n.Visible = true;
			this.TBox29.Visible = true;
			this.TBox29n.Visible = true;
			this.TBox28.Visible = true;
			this.TBox28n.Visible = true;
			this.TBox27.Visible = true;
			this.TBox27n.Visible = true;
			this.TBox26.Visible = true;
			this.TBox26n.Visible = true;
			this.TBox25.Visible = true;
			this.TBox25n.Visible = true;
			this.TBox24.Visible = true;
			this.TBox24n.Visible = true;
			this.TBox23.Visible = true;
			this.TBox23n.Visible = true;
			this.TBox22.Visible = true;
			this.TBox22n.Visible = true;
			this.TBox21.Visible = true;
			this.TBox21n.Visible = true;
			this.TBox20.Visible = true;
			this.TBox20n.Visible = true;
			this.TBox19.Visible = true;
			this.TBox19n.Visible = true;
			this.TBox18.Visible = true;
			this.TBox18n.Visible = true;
			this.TBox17.Visible = true;
			this.TBox17n.Visible = true;
			this.TBox16.Visible = true;
			this.TBox16n.Visible = true;
			this.TBox15.Visible = true;
			this.TBox15n.Visible = true;
			this.TBox14.Visible = true;
			this.TBox14n.Visible = true;
			this.TBox13.Visible = true;
			this.TBox13n.Visible = true;
			this.TBox12.Visible = true;
			this.TBox12n.Visible = true;
			this.TBox11.Visible = true;
			this.TBox11n.Visible = true;
			this.TBox10.Visible = true;
			this.TBox10n.Visible = true;
			this.TBox9.Visible = true;
			this.TBox9n.Visible = true;
			this.Car9.SetBounds(1166, 70, 0, 0);
			this.Car10.SetBounds(1106, 70, 0, 0);
			this.Car11.SetBounds(1046, 70, 0, 0);
			this.Car12.SetBounds(986, 70, 0, 0);
			this.Car13.SetBounds(926, 70, 0, 0);
			this.Car14.SetBounds(865, 70, 0, 0);
			this.Car15.SetBounds(806, 70, 0, 0);
			this.Car16.SetBounds(746, 70, 0, 0);
			this.Car17.SetBounds(686, 70, 0, 0);
			this.Car18.SetBounds(626, 70, 0, 0);
			this.Car19.SetBounds(566, 70, 0, 0);
			this.Car20.SetBounds(506, 70, 0, 0);
			this.Car21.SetBounds(444, 70, 0, 0);
			this.Car22.SetBounds(386, 70, 0, 0);
			this.Car23.SetBounds(326, 70, 0, 0);
			this.Car24.SetBounds(266, 70, 0, 0);
			this.Car25.SetBounds(206, 70, 0, 0);
			this.Car8.SetBounds(1166, 620, 0, 0);
			this.Car7.SetBounds(1106, 620, 0, 0);
			this.Car6.SetBounds(1046, 620, 0, 0);
			this.Car5.SetBounds(986, 620, 0, 0);
			this.Car4.SetBounds(926, 620, 0, 0);
			this.Car3.SetBounds(865, 620, 0, 0);
			this.Car2.SetBounds(806, 620, 0, 0);
			this.Car1.SetBounds(746, 620, 0, 0);
			this.Car33.SetBounds(686, 620, 0, 0);
			this.Car32.SetBounds(626, 620, 0, 0);
			this.Car31.SetBounds(566, 620, 0, 0);
			this.Car30.SetBounds(506, 620, 0, 0);
			this.Car29.SetBounds(446, 620, 0, 0);
			this.Car28.SetBounds(386, 620, 0, 0);
			this.Car27.SetBounds(326, 620, 0, 0);
			this.Car26.SetBounds(266, 620, 0, 0);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0002FC24 File Offset: 0x0002DE24
		private void fecharvisualcarro()
		{
			this.TBox1.Visible = false;
			this.TBox1n.Visible = false;
			this.TBox2.Visible = false;
			this.TBox2n.Visible = false;
			this.TBox3.Visible = false;
			this.TBox3n.Visible = false;
			this.TBox4.Visible = false;
			this.TBox4n.Visible = false;
			this.TBox5.Visible = false;
			this.TBox5n.Visible = false;
			this.TBox6.Visible = false;
			this.TBox6n.Visible = false;
			this.TBox7.Visible = false;
			this.TBox7n.Visible = false;
			this.TBox8.Visible = false;
			this.TBox8n.Visible = false;
			this.TBox33.Visible = false;
			this.TBox33n.Visible = false;
			this.TBox32.Visible = false;
			this.TBox32n.Visible = false;
			this.TBox31.Visible = false;
			this.TBox31n.Visible = false;
			this.TBox30.Visible = false;
			this.TBox30n.Visible = false;
			this.TBox29.Visible = false;
			this.TBox29n.Visible = false;
			this.TBox28.Visible = false;
			this.TBox28n.Visible = false;
			this.TBox27.Visible = false;
			this.TBox27n.Visible = false;
			this.TBox26.Visible = false;
			this.TBox26n.Visible = false;
			this.TBox25.Visible = false;
			this.TBox25n.Visible = false;
			this.TBox24.Visible = false;
			this.TBox24n.Visible = false;
			this.TBox23.Visible = false;
			this.TBox23n.Visible = false;
			this.TBox22.Visible = false;
			this.TBox22n.Visible = false;
			this.TBox21.Visible = false;
			this.TBox21n.Visible = false;
			this.TBox20.Visible = false;
			this.TBox20n.Visible = false;
			this.TBox19.Visible = false;
			this.TBox19n.Visible = false;
			this.TBox18.Visible = false;
			this.TBox18n.Visible = false;
			this.TBox17.Visible = false;
			this.TBox17n.Visible = false;
			this.TBox16.Visible = false;
			this.TBox16n.Visible = false;
			this.TBox15.Visible = false;
			this.TBox15n.Visible = false;
			this.TBox14.Visible = false;
			this.TBox14n.Visible = false;
			this.TBox13.Visible = false;
			this.TBox13n.Visible = false;
			this.TBox12.Visible = false;
			this.TBox12n.Visible = false;
			this.TBox11.Visible = false;
			this.TBox11n.Visible = false;
			this.TBox10.Visible = false;
			this.TBox10n.Visible = false;
			this.TBox9.Visible = false;
			this.TBox9n.Visible = false;
			this.Car9.SetBounds(1166, 306, 0, 0);
			this.Car10.SetBounds(1106, 270, 0, 0);
			this.Car11.SetBounds(1046, 270, 0, 0);
			this.Car12.SetBounds(986, 270, 0, 0);
			this.Car13.SetBounds(926, 270, 0, 0);
			this.Car14.SetBounds(865, 270, 0, 0);
			this.Car15.SetBounds(806, 270, 0, 0);
			this.Car16.SetBounds(746, 270, 0, 0);
			this.Car17.SetBounds(686, 270, 0, 0);
			this.Car18.SetBounds(626, 270, 0, 0);
			this.Car19.SetBounds(566, 270, 0, 0);
			this.Car20.SetBounds(506, 270, 0, 0);
			this.Car21.SetBounds(444, 270, 0, 0);
			this.Car22.SetBounds(386, 270, 0, 0);
			this.Car23.SetBounds(326, 270, 0, 0);
			this.Car24.SetBounds(266, 270, 0, 0);
			this.Car25.SetBounds(206, 345, 0, 0);
			this.Car8.SetBounds(1166, 370, 0, 0);
			this.Car7.SetBounds(1106, 420, 0, 0);
			this.Car6.SetBounds(1046, 420, 0, 0);
			this.Car5.SetBounds(986, 420, 0, 0);
			this.Car4.SetBounds(926, 420, 0, 0);
			this.Car3.SetBounds(865, 420, 0, 0);
			this.Car2.SetBounds(806, 420, 0, 0);
			this.Car1.SetBounds(746, 420, 0, 0);
			this.Car33.SetBounds(686, 420, 0, 0);
			this.Car32.SetBounds(626, 420, 0, 0);
			this.Car31.SetBounds(566, 420, 0, 0);
			this.Car30.SetBounds(506, 420, 0, 0);
			this.Car29.SetBounds(446, 420, 0, 0);
			this.Car28.SetBounds(386, 420, 0, 0);
			this.Car27.SetBounds(326, 420, 0, 0);
			this.Car26.SetBounds(266, 420, 0, 0);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000302A4 File Offset: 0x0002E4A4
		private void fecharcarrosvisual_Click(object sender, EventArgs e)
		{
			bool flag = !this.travado;
			if (flag)
			{
				this.fecharcarrosvisual.Image = Resources.fechado;
				this.travado = true;
				this.labNsetor2.SetBounds(268, 221, 0, 0);
				this.labNsetor3.SetBounds(425, 221, 0, 0);
				this.labNsetor4.SetBounds(592, 221, 0, 0);
				this.labNsetor5.SetBounds(778, 221, 0, 0);
				this.labNsetor6.SetBounds(882, 223, 0, 0);
				this.labNsetor7.SetBounds(958, 223, 0, 0);
				this.labNsetor8.SetBounds(1071, 223, 0, 0);
				this.labNsetor9.SetBounds(1155, 223, 0, 0);
				this.labNsetor1.SetBounds(488, 487, 0, 0);
				this.labNsetor10.SetBounds(1105, 489, 0, 0);
				this.labNsetor11.SetBounds(1032, 489, 0, 0);
				this.labNsetor12.SetBounds(978, 489, 0, 0);
				this.labNsetor13.SetBounds(873, 489, 0, 0);
				this.CorSetor2.SetBounds(200, 265, 0, 0);
				this.CorSetor2n2.SetBounds(259, 265, 0, 0);
				this.CorSetor3.SetBounds(439, 265, 0, 0);
				this.CorSetor4.SetBounds(499, 265, 0, 0);
				this.CorSetor5.SetBounds(779, 265, 0, 0);
				this.CorSetor6.SetBounds(840, 265, 0, 0);
				this.CorSetor7.SetBounds(980, 265, 0, 0);
				this.CorSetor8.SetBounds(1040, 265, 0, 0);
				this.CorSetor9.SetBounds(1160, 265, 0, 0);
				this.CorSetor2n1.Visible = true;
				this.CorSetor1.SetBounds(259, 415, 0, 0);
				this.CorSetor13.SetBounds(859, 415, 0, 0);
				this.CorSetor12.SetBounds(976, 415, 0, 0);
				this.CorSetor11.SetBounds(1033, 415, 0, 0);
				this.CorSetor10.SetBounds(1098, 415, 0, 0);
				this.CorSetor9n2.SetBounds(1160, 415, 0, 0);
				this.CorSetor9n1.Visible = true;
				this.fecharvisualcarro();
			}
			else
			{
				bool flag2 = this.travado;
				if (flag2)
				{
					this.fecharcarrosvisual.Image = Resources.aberto;
					this.travado = false;
					this.labNsetor2.SetBounds(268, 37, 0, 0);
					this.labNsetor3.SetBounds(425, 37, 0, 0);
					this.labNsetor4.SetBounds(592, 37, 0, 0);
					this.labNsetor5.SetBounds(778, 37, 0, 0);
					this.labNsetor6.SetBounds(882, 30, 0, 0);
					this.labNsetor7.SetBounds(958, 30, 0, 0);
					this.labNsetor8.SetBounds(1071, 30, 0, 0);
					this.labNsetor9.SetBounds(1155, 39, 0, 0);
					this.labNsetor1.SetBounds(488, 682, 0, 0);
					this.labNsetor10.SetBounds(1105, 684, 0, 0);
					this.labNsetor11.SetBounds(1032, 684, 0, 0);
					this.labNsetor12.SetBounds(978, 684, 0, 0);
					this.labNsetor13.SetBounds(873, 684, 0, 0);
					this.CorSetor2.SetBounds(200, 65, 0, 0);
					this.CorSetor2n2.SetBounds(259, 65, 0, 0);
					this.CorSetor3.SetBounds(439, 65, 0, 0);
					this.CorSetor4.SetBounds(499, 65, 0, 0);
					this.CorSetor5.SetBounds(779, 65, 0, 0);
					this.CorSetor6.SetBounds(840, 65, 0, 0);
					this.CorSetor7.SetBounds(980, 65, 0, 0);
					this.CorSetor8.SetBounds(1040, 65, 0, 0);
					this.CorSetor9.SetBounds(1160, 65, 0, 0);
					this.CorSetor2n1.Visible = false;
					this.CorSetor1.SetBounds(259, 615, 0, 0);
					this.CorSetor13.SetBounds(859, 615, 0, 0);
					this.CorSetor12.SetBounds(976, 615, 0, 0);
					this.CorSetor11.SetBounds(1033, 615, 0, 0);
					this.CorSetor10.SetBounds(1098, 615, 0, 0);
					this.CorSetor9n2.SetBounds(1160, 615, 0, 0);
					this.CorSetor9n1.Visible = false;
					this.abrirvisualcarro();
				}
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00030858 File Offset: 0x0002EA58
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.tempo++;
			bool flag = this.tempo >= 200;
			if (flag)
			{
				this.tempo = 0;
				this.metodosciclicos();
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00030898 File Offset: 0x0002EA98
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000308A3 File Offset: 0x0002EAA3
		private void button1_Click(object sender, EventArgs e)
		{
			this.metodosciclicos();
		}

		// Token: 0x0400029B RID: 667
		public const int NCARROS = 33;

		// Token: 0x0400029C RID: 668
		public const int NBY20 = 94;

		// Token: 0x0400029D RID: 669
		public const string IPCLP = "192.168.0.1";

		// Token: 0x0400029E RID: 670
		public visual.carros[] carro = new visual.carros[33];

		// Token: 0x0400029F RID: 671
		public visual.carros[] carroordenado = new visual.carros[33];

		// Token: 0x040002A0 RID: 672
		private S7Client plc = new S7Client();

		// Token: 0x040002A1 RID: 673
		public bool conectado;

		// Token: 0x040002A2 RID: 674
		public int x;

		// Token: 0x040002A3 RID: 675
		public int y;

		// Token: 0x040002A4 RID: 676
		private bool travado = true;

		// Token: 0x040002A5 RID: 677
		private int tempo;

		// Token: 0x02000032 RID: 50
		public struct carros
		{
			// Token: 0x040003EB RID: 1003
			public int IdCarro;

			// Token: 0x040003EC RID: 1004
			public double PosicaoCarro;

			// Token: 0x040003ED RID: 1005
			public int Status;

			// Token: 0x040003EE RID: 1006
			public int QuantidadeCarro;

			// Token: 0x040003EF RID: 1007
			public string DescricaoProduto;

			// Token: 0x040003F0 RID: 1008
			public string CodigoModeloProduto;

			// Token: 0x040003F1 RID: 1009
			public int NumeroDaReceita;

			// Token: 0x040003F2 RID: 1010
			public int IdReceita;

			// Token: 0x040003F3 RID: 1011
			public string NomeDaReceita;

			// Token: 0x040003F4 RID: 1012
			public int TMin;

			// Token: 0x040003F5 RID: 1013
			public int TMax;

			// Token: 0x040003F6 RID: 1014
			public bool carregavel;

			// Token: 0x040003F7 RID: 1015
			public string setor;
		}
	}
}
