using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SupervisorioDana
{
	// Token: 0x02000006 RID: 6
	public partial class FrmConfiguracoes1920x1080 : Form
	{
		// Token: 0x06000062 RID: 98 RVA: 0x000097C4 File Offset: 0x000079C4
		public FrmConfiguracoes1920x1080()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00009819 File Offset: 0x00007A19
		private void FrmConfiguracoes_Load(object sender, EventArgs e)
		{
			this.verificaQUsuarios();
			this.preencheComboUsuarios();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000982C File Offset: 0x00007A2C
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

		// Token: 0x06000065 RID: 101 RVA: 0x00009958 File Offset: 0x00007B58
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

		// Token: 0x06000066 RID: 102 RVA: 0x00009A08 File Offset: 0x00007C08
		private void preencheComboUsuarios()
		{
			this.comboBox1.Items.Clear();
			for (int i = 0; i < this.QUsuariosAtivos; i++)
			{
				string nome = this.usuarios[i].nome;
				this.comboBox1.Items.Add(nome);
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00009A64 File Offset: 0x00007C64
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

		// Token: 0x06000068 RID: 104 RVA: 0x00009BA8 File Offset: 0x00007DA8
		private void FrmConfiguracoes_FormClosing(object sender, FormClosingEventArgs e)
		{
			FrmConfiguracoes1920x1080 frmAlarmes = new FrmConfiguracoes1920x1080();
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00009BBC File Offset: 0x00007DBC
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

		// Token: 0x0600006A RID: 106 RVA: 0x00009C34 File Offset: 0x00007E34
		private void limpaTBoxUsuarios()
		{
			this.TBoxNome.Text = "";
			this.TBoxSenha.Text = "";
			this.RBobservador.Checked = false;
			this.RBoperador.Checked = false;
			this.RBsupervisor.Checked = false;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00009C90 File Offset: 0x00007E90
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

		// Token: 0x0600006C RID: 108 RVA: 0x00009CFC File Offset: 0x00007EFC
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

		// Token: 0x0600006D RID: 109 RVA: 0x00009E38 File Offset: 0x00008038
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

		// Token: 0x0600006E RID: 110 RVA: 0x00009EB0 File Offset: 0x000080B0
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

		// Token: 0x0600006F RID: 111 RVA: 0x0000A060 File Offset: 0x00008260
		private void pictureBox1_Click_1(object sender, EventArgs e)
		{
			base.Hide();
		}

		// Token: 0x04000090 RID: 144
		public const int Nusuarios = 30;

		// Token: 0x04000091 RID: 145
		public FrmConfiguracoes1920x1080.Usuarios[] usuarios = new FrmConfiguracoes1920x1080.Usuarios[30];

		// Token: 0x04000092 RID: 146
		public FrmConfiguracoes1920x1080.Usuarios usuariobuffer = default(FrmConfiguracoes1920x1080.Usuarios);

		// Token: 0x04000093 RID: 147
		public int QUsuariosAtivos = 0;

		// Token: 0x04000094 RID: 148
		public bool NovoUsuario = false;

		// Token: 0x04000095 RID: 149
		public string caminho = Environment.CurrentDirectory;

		// Token: 0x0200001B RID: 27
		public struct Usuarios
		{
			// Token: 0x04000355 RID: 853
			public int id;

			// Token: 0x04000356 RID: 854
			public string nome;

			// Token: 0x04000357 RID: 855
			public string senha;

			// Token: 0x04000358 RID: 856
			public string nivel;
		}
	}
}
