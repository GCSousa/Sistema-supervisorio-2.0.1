using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
namespace SupervisorioDana
{
	// Token: 0x02000008 RID: 8
	public partial class FrmEntrada1920x1080 : Form
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x0001035C File Offset: 0x0000E55C
		public FrmEntrada1920x1080()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000103BB File Offset: 0x0000E5BB
		private void Entrada_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000103BE File Offset: 0x0000E5BE
		private void FrmEntrada_Shown(object sender, EventArgs e)
		{
			this.label1.Select();
			this.ledados();
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000103D4 File Offset: 0x0000E5D4
		private void BtnConectar_Click(object sender, EventArgs e)
		{
			this.botaoapertado();
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000103DE File Offset: 0x0000E5DE
		private void TBoxLogin_MouseClick(object sender, MouseEventArgs e)
		{
			this.VerificaEstadoLogin();
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000103E8 File Offset: 0x0000E5E8
		private void TBoxSenha_MouseClick(object sender, MouseEventArgs e)
		{
			this.VerificaEstadoSenha();
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000103F4 File Offset: 0x0000E5F4
		private void TBoxLogin_KeyUp(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return || e.KeyCode == Keys.Tab;
			if (flag)
			{
				this.VerificaEstadoLogin();
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00010428 File Offset: 0x0000E628
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

		// Token: 0x060000BB RID: 187 RVA: 0x00010466 File Offset: 0x0000E666
		private void TBoxLogin_TextChanged(object sender, EventArgs e)
		{
			this.VerificaEstadoLogin();
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00010470 File Offset: 0x0000E670
		private void TBoxSenha_TextChanged(object sender, EventArgs e)
		{
			this.VerificaEstadoSenha();
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0001047C File Offset: 0x0000E67C
		private void Entrada_KeyUp(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Tab;
			if (flag)
			{
				this.VerificaEstadoSenha();
				this.VerificaEstadoLogin();
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000104A8 File Offset: 0x0000E6A8
		private void Entrada_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000104B4 File Offset: 0x0000E6B4
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

		// Token: 0x060000C0 RID: 192 RVA: 0x000105D8 File Offset: 0x0000E7D8
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

		// Token: 0x060000C1 RID: 193 RVA: 0x00010618 File Offset: 0x0000E818
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

		// Token: 0x060000C2 RID: 194 RVA: 0x00010670 File Offset: 0x0000E870
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
						FrmDadosDosCarros1920x1080 frmDadosDosCarros = new FrmDadosDosCarros1920x1080();
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

		// Token: 0x060000C3 RID: 195 RVA: 0x0001074C File Offset: 0x0000E94C
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

		// Token: 0x060000C4 RID: 196 RVA: 0x000107FC File Offset: 0x0000E9FC
		private void escrevenomelogado(string nlogado, string nivlogado)
		{
			this.nomelogado = nlogado;
			this.nivellogado = nivlogado;
			this.atualizaconfig();
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00010814 File Offset: 0x0000EA14
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

		// Token: 0x060000C6 RID: 198 RVA: 0x0001090C File Offset: 0x0000EB0C
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

		// Token: 0x060000C7 RID: 199 RVA: 0x00010990 File Offset: 0x0000EB90
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x040000F6 RID: 246
		public FrmEntrada1920x1080.Usuarios[] usuarios = new FrmEntrada1920x1080.Usuarios[30];

		// Token: 0x040000F7 RID: 247
		public int estadologin = 0;

		// Token: 0x040000F8 RID: 248
		public int estadoSenha = 0;

		// Token: 0x040000F9 RID: 249
		public string caminho = Environment.CurrentDirectory;

		// Token: 0x040000FA RID: 250
		public string nomelogado = "";

		// Token: 0x040000FB RID: 251
		public string nivellogado = "";

		// Token: 0x02000021 RID: 33
		public struct Usuarios
		{
			// Token: 0x04000385 RID: 901
			public int id;

			// Token: 0x04000386 RID: 902
			public string nome;

			// Token: 0x04000387 RID: 903
			public string senha;

			// Token: 0x04000388 RID: 904
			public string nivel;
		}
	}
}
