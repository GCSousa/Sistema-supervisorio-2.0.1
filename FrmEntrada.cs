using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SupervisorioDana
{
	// Token: 0x0200000F RID: 15
	public partial class FrmEntrada : Form
	{
		// Token: 0x0600018A RID: 394 RVA: 0x0002B3F0 File Offset: 0x000295F0
		public FrmEntrada()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0002B44F File Offset: 0x0002964F
		private void Entrada_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0002B452 File Offset: 0x00029652
		private void FrmEntrada_Shown(object sender, EventArgs e)
		{
			this.label1.Select();
			this.ledados();
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0002B468 File Offset: 0x00029668
		private void BtnConectar_Click(object sender, EventArgs e)
		{
			this.botaoapertado();
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0002B472 File Offset: 0x00029672
		private void TBoxLogin_MouseClick(object sender, MouseEventArgs e)
		{
			this.VerificaEstadoLogin();
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0002B47C File Offset: 0x0002967C
		private void TBoxSenha_MouseClick(object sender, MouseEventArgs e)
		{
			this.VerificaEstadoSenha();
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0002B488 File Offset: 0x00029688
		private void TBoxLogin_KeyUp(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return || e.KeyCode == Keys.Tab;
			if (flag)
			{
				this.VerificaEstadoLogin();
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0002B4BC File Offset: 0x000296BC
		private void TBoxSenha_KeyUp(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Tab;
			if (flag)
			{
				this.VerificaEstadoSenha();
			}
			bool flag2 = e.KeyCode == Keys.Return;
			if (flag2)
			{
				this.botaoapertado();
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0002B4FA File Offset: 0x000296FA
		private void TBoxLogin_TextChanged(object sender, EventArgs e)
		{
			this.VerificaEstadoLogin();
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0002B504 File Offset: 0x00029704
		private void TBoxSenha_TextChanged(object sender, EventArgs e)
		{
			this.VerificaEstadoSenha();
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0002B510 File Offset: 0x00029710
		private void Entrada_KeyUp(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Tab;
			if (flag)
			{
				this.VerificaEstadoSenha();
				this.VerificaEstadoLogin();
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0002B53C File Offset: 0x0002973C
		private void Entrada_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0002B548 File Offset: 0x00029748
		private void ledados()
		{
			int cont_linhas = 0;
			int contador = 0;
			string arquivo = this.caminho + "/userscontrol.txt";
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
							bool flag2 = cont_linhas % 3 == 0;
							if (flag2)
							{
								this.usuarios[contador].nome = linha;
							}
							else
							{
								bool flag3 = cont_linhas % 3 == 1;
								if (flag3)
								{
									this.usuarios[contador].senha = linha;
								}
								else
								{
									bool flag4 = cont_linhas % 3 == 2;
									if (flag4)
									{
										this.usuarios[contador].nivel = linha;
										contador++;
									}
								}
							}
							cont_linhas++;
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
				this.arquivonaoencontrado();
				this.ledados();
				MessageBox.Show("ERRO 01,\nerro corrigido automaticamente");
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0002B66C File Offset: 0x0002986C
		private void VerificaEstadoLogin()
		{
			bool flag = this.estadologin == 0;
			if (flag)
			{
				this.TBoxLogin.Clear();
				this.TBoxLogin.TextAlign = HorizontalAlignment.Center;
			}
			this.estadologin = 1;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0002B6AC File Offset: 0x000298AC
		private void VerificaEstadoSenha()
		{
			bool flag = this.estadoSenha == 0;
			if (flag)
			{
				bool flag2 = this.TBoxSenha.Text == "Insira a Senha";
				if (flag2)
				{
					this.TBoxSenha.Clear();
					this.TBoxSenha.TextAlign = HorizontalAlignment.Center;
				}
			}
			this.estadoSenha = 1;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0002B704 File Offset: 0x00029904
		public void botaoapertado()
		{
			bool login_valido = false;
			int i = 0;
			do
			{
				string user = this.usuarios[i].nome;
				string senha = this.usuarios[i].senha;
				string nivel = this.usuarios[i].nivel;
				bool flag = this.TBoxLogin.Text == user;
				if (flag)
				{
					bool flag2 = this.TBoxSenha.Text == senha;
					if (flag2)
					{
						base.Hide();
						login_valido = true;
						this.escrevenomelogado(user, nivel);
						FrmDadosDosCarros frmDadosDosCarros = new FrmDadosDosCarros();
						frmDadosDosCarros.ShowDialog();
					}
				}
				i++;
			}
			while (i < 30 && !login_valido);
			bool flag3 = !login_valido;
			if (flag3)
			{
				this.LabErro.Text = "Usuario e / ou senha incorreta";
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0002B7E0 File Offset: 0x000299E0
		private void arquivonaoencontrado()
		{
			StreamWriter x = File.CreateText(this.caminho + "/userscontrol.txt");
			x.Close();
			using (StreamWriter y = new StreamWriter(this.caminho + "/userscontrol.txt"))
			{
				y.WriteLine("admin");
				y.WriteLine("I2V0IojvTogl");
				y.WriteLine("3");
				y.WriteLine("previsio");
				y.WriteLine("mp1234");
				y.WriteLine("3");
				y.Close();
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0002B890 File Offset: 0x00029A90
		private void escrevenomelogado(string nlogado, string nivlogado)
		{
			this.nomelogado = nlogado;
			this.nivellogado = nivlogado;
			this.atualizaconfig();
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0002B8A8 File Offset: 0x00029AA8
		private void atualizaconfig()
		{
			string arquivo = this.caminho + "/cofgs.txt";
			bool flag = File.Exists(arquivo);
			if (flag)
			{
				try
				{
					using (StreamWriter sr = new StreamWriter(this.caminho + "/cofgs.txt"))
					{
						sr.WriteLine(this.nomelogado);
						sr.WriteLine(this.nivellogado);
						bool flag2 = int.Parse(this.nivellogado) <= 2;
						if (flag2)
						{
							sr.WriteLine("false");
						}
						else
						{
							bool flag3 = int.Parse(this.nivellogado) > 3;
							if (flag3)
							{
								sr.WriteLine("true");
							}
						}
					}
				}
				catch (Exception ex)
				{
				}
			}
			else
			{
				this.confnaoencontrado();
				this.atualizaconfig();
				MessageBox.Show("ERRO 02,\nerro corrigido automaticamente");
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0002B9A0 File Offset: 0x00029BA0
		private void confnaoencontrado()
		{
			StreamWriter x = File.CreateText(this.caminho + "/cofgs.txt");
			x.Close();
			using (StreamWriter y = new StreamWriter(this.caminho + "/cofgs.txt"))
			{
				y.WriteLine(this.nomelogado);
				y.WriteLine(this.nivellogado);
				y.Close();
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0002BA24 File Offset: 0x00029C24
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0400028D RID: 653
		public FrmEntrada.Usuarios[] usuarios = new FrmEntrada.Usuarios[30];

		// Token: 0x0400028E RID: 654
		public int estadologin = 0;

		// Token: 0x0400028F RID: 655
		public int estadoSenha = 0;

		// Token: 0x04000290 RID: 656
		public string caminho = Environment.CurrentDirectory;

		// Token: 0x04000291 RID: 657
		public string nomelogado = "";

		// Token: 0x04000292 RID: 658
		public string nivellogado = "";

		// Token: 0x02000031 RID: 49
		public struct Usuarios
		{
			// Token: 0x040003E7 RID: 999
			public int id;

			// Token: 0x040003E8 RID: 1000
			public string nome;

			// Token: 0x040003E9 RID: 1001
			public string senha;

			// Token: 0x040003EA RID: 1002
			public string nivel;
		}
	}
}
