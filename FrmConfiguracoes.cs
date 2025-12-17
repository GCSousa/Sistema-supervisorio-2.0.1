using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using SupervisorioDana.Properties;

namespace SupervisorioDana
{
	// Token: 0x0200000D RID: 13
	public partial class FrmConfiguracoes : Form
	{
		// Token: 0x06000139 RID: 313 RVA: 0x00024964 File Offset: 0x00022B64
		public FrmConfiguracoes()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000249B9 File Offset: 0x00022BB9
		private void FrmConfiguracoes_Load(object sender, EventArgs e)
		{
			this.verificaQUsuarios();
			this.preencheComboUsuarios();
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000249CC File Offset: 0x00022BCC
		private void verificaQUsuarios()
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
						this.QUsuariosAtivos = contador;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			else
			{
				this.CriaArquivoUsuario();
				this.verificaQUsuarios();
				MessageBox.Show("Erro 02: arquivo de leitura de usuario não encontrado");
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00024AF8 File Offset: 0x00022CF8
		private void CriaArquivoUsuario()
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

		// Token: 0x0600013D RID: 317 RVA: 0x00024BA8 File Offset: 0x00022DA8
		private void preencheComboUsuarios()
		{
			this.comboBox1.Items.Clear();
			for (int i = 0; i < this.QUsuariosAtivos; i++)
			{
				string nome = this.usuarios[i].nome;
				this.comboBox1.Items.Add(nome);
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00024C04 File Offset: 0x00022E04
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.comboBox1.Items.Count > 0;
			if (flag)
			{
				this.usuariobuffer.id = this.comboBox1.SelectedIndex;
				this.usuariobuffer.nome = this.usuarios[this.usuariobuffer.id].nome;
				this.usuariobuffer.senha = this.usuarios[this.usuariobuffer.id].senha;
				this.usuariobuffer.nivel = this.usuarios[this.usuariobuffer.id].nivel;
				this.TBoxNome.Text = this.usuariobuffer.nome;
				this.TBoxSenha.Text = this.usuariobuffer.senha;
				string nivel = this.usuariobuffer.nivel;
				string text = nivel;
				if (!(text == "1"))
				{
					if (!(text == "2"))
					{
						if (text == "3")
						{
							this.RBsupervisor.Checked = true;
						}
					}
					else
					{
						this.RBoperador.Checked = true;
					}
				}
				else
				{
					this.RBobservador.Checked = true;
				}
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00024D48 File Offset: 0x00022F48
		private void FrmConfiguracoes_FormClosing(object sender, FormClosingEventArgs e)
		{
			FrmConfiguracoes frmAlarmes = new FrmConfiguracoes();
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00024D5C File Offset: 0x00022F5C
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox1.Checked;
			if (@checked)
			{
				this.comboBox1.Enabled = false;
				this.comboBox1.Items.Clear();
				this.limpaTBoxUsuarios();
				this.NovoUsuario = true;
			}
			else
			{
				this.checkBox1.Checked = false;
				this.comboBox1.Enabled = true;
				this.verificaQUsuarios();
				this.preencheComboUsuarios();
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00024DD4 File Offset: 0x00022FD4
		private void limpaTBoxUsuarios()
		{
			this.TBoxNome.Text = "";
			this.TBoxSenha.Text = "";
			this.RBobservador.Checked = false;
			this.RBoperador.Checked = false;
			this.RBsupervisor.Checked = false;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00024E30 File Offset: 0x00023030
		private void button1_Click(object sender, EventArgs e)
		{
			int valido = this.validaususario();
			bool flag = valido == 1;
			if (flag)
			{
				bool novoUsuario = this.NovoUsuario;
				if (novoUsuario)
				{
					this.inserenalista();
				}
				else
				{
					string nomebuffer = this.usuariobuffer.nome;
					string novousuario = this.TBoxNome.Text;
					int posisao = this.usuariobuffer.id * 3;
					this.substituinalista(nomebuffer, novousuario, posisao);
				}
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00024E9C File Offset: 0x0002309C
		private void substituinalista(string nomecorrente, string novousuario, int posisao)
		{
			string vcaminho = this.caminho + "/userscontrol.txt";
			string[] lines = File.ReadAllLines(vcaminho);
			using (StreamWriter writer = new StreamWriter(vcaminho))
			{
				for (int i = 0; i < lines.Length; i++)
				{
					bool flag = i == posisao && lines[i] == nomecorrente;
					if (flag)
					{
						writer.WriteLine(novousuario);
						writer.WriteLine(this.TBoxSenha.Text);
						bool @checked = this.RBobservador.Checked;
						if (@checked)
						{
							writer.WriteLine(1);
						}
						else
						{
							bool checked2 = this.RBoperador.Checked;
							if (checked2)
							{
								writer.WriteLine(2);
							}
							else
							{
								bool checked3 = this.RBsupervisor.Checked;
								if (checked3)
								{
									writer.WriteLine(3);
								}
							}
						}
						i += 2;
					}
					else
					{
						writer.WriteLine(lines[i]);
					}
				}
				writer.Close();
			}
			this.checkBox1.Checked = false;
			this.NovoUsuario = false;
			this.limpaTBoxUsuarios();
			this.verificaQUsuarios();
			this.preencheComboUsuarios();
			MessageBox.Show("Usuario Modificado Com Susesso!");
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00024FD8 File Offset: 0x000231D8
		private int validaususario()
		{
			int nnivel = 0;
			bool @checked = this.RBobservador.Checked;
			if (@checked)
			{
				nnivel = 1;
			}
			else
			{
				bool checked2 = this.RBoperador.Checked;
				if (checked2)
				{
					nnivel = 2;
				}
				else
				{
					bool checked3 = this.RBsupervisor.Checked;
					if (checked3)
					{
						nnivel = 3;
					}
				}
			}
			bool flag = nnivel >= 1 && nnivel <= 3;
			int valido;
			if (flag)
			{
				valido = 1;
			}
			else
			{
				valido = 0;
			}
			return valido;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00025050 File Offset: 0x00023250
		private void inserenalista()
		{
			int nnivel = 0;
			string nnome = this.TBoxNome.Text;
			string nsenha = this.TBoxSenha.Text;
			bool @checked = this.RBobservador.Checked;
			if (@checked)
			{
				nnivel = 1;
			}
			else
			{
				bool checked2 = this.RBoperador.Checked;
				if (checked2)
				{
					nnivel = 2;
				}
				else
				{
					bool checked3 = this.RBsupervisor.Checked;
					if (checked3)
					{
						nnivel = 3;
					}
				}
			}
			string arquivo = this.caminho;
			bool flag = !File.Exists(arquivo + "/userscontrol.txt");
			if (flag)
			{
				throw new FileNotFoundException("Arquivo " + arquivo + "/userscontrol.txt não encontrado");
			}
			StringBuilder container = new StringBuilder();
			using (StreamReader re = File.OpenText(arquivo + "/userscontrol.txt"))
			{
				container.Append(re.ReadToEnd());
			}
			bool flag2 = File.Exists(arquivo + "/userscontrol.txt");
			if (flag2)
			{
				File.Delete(arquivo + "/userscontrol.txt");
			}
			FileInfo t = new FileInfo(arquivo + "/userscontrol.txt");
			using (StreamWriter Tex = t.CreateText())
			{
				Tex.Write(container.ToString());
				Tex.WriteLine(nnome);
				Tex.WriteLine(nsenha);
				Tex.WriteLine(nnivel);
				Tex.Close();
			}
			this.checkBox1.Checked = false;
			this.NovoUsuario = false;
			this.limpaTBoxUsuarios();
			this.verificaQUsuarios();
			this.preencheComboUsuarios();
			MessageBox.Show("Usuario Criado com sucesso!");
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00025200 File Offset: 0x00023400
		private void pictureBox1_Click_1(object sender, EventArgs e)
		{
			base.Hide();
		}

		// Token: 0x04000227 RID: 551
		public const int Nusuarios = 30;

		// Token: 0x04000228 RID: 552
		public FrmConfiguracoes.Usuarios[] usuarios = new FrmConfiguracoes.Usuarios[30];

		// Token: 0x04000229 RID: 553
		public FrmConfiguracoes.Usuarios usuariobuffer = default(FrmConfiguracoes.Usuarios);

		// Token: 0x0400022A RID: 554
		public int QUsuariosAtivos = 0;

		// Token: 0x0400022B RID: 555
		public bool NovoUsuario = false;

		// Token: 0x0400022C RID: 556
		public string caminho = Environment.CurrentDirectory;

		// Token: 0x0200002B RID: 43
		public struct Usuarios
		{
			// Token: 0x040003B7 RID: 951
			public int id;

			// Token: 0x040003B8 RID: 952
			public string nome;

			// Token: 0x040003B9 RID: 953
			public string senha;

			// Token: 0x040003BA RID: 954
			public string nivel;
		}
	}
}
