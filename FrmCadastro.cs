using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Sharp7;
using SupervisorioDana.Properties;

namespace SupervisorioDana
{
	// Token: 0x0200000C RID: 12
	public partial class FrmCadastro : Form
	{
		// Token: 0x0600011A RID: 282 RVA: 0x00020F8C File Offset: 0x0001F18C
		public FrmCadastro()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00021018 File Offset: 0x0001F218
		private void Form1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0002101B File Offset: 0x0001F21B
		private void metodosDeIncializacaodoForm()
		{
			this.leusuario();
			this.conexao();
			this.atualizaListaProduto();
			this.atualizaListaReceita();
			this.atualizaHisterese();
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00021044 File Offset: 0x0001F244
		private void FrmCadastro_Shown(object sender, EventArgs e)
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

		// Token: 0x0600011E RID: 286 RVA: 0x00021090 File Offset: 0x0001F290
		public void conexao()
		{
			int chamado_limite = 0;
			int verifica_conexao;
			do
			{
				verifica_conexao = this.plc.ConnectTo("192.168.0.1", 0, 1);
				chamado_limite++;
			}
			while (verifica_conexao != 0 && chamado_limite != 3);
			bool flag = verifica_conexao == 0;
			if (flag)
			{
				this.conectado = true;
			}
			else
			{
				bool flag2 = chamado_limite == 3;
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

		// Token: 0x0600011F RID: 287 RVA: 0x000210FC File Offset: 0x0001F2FC
		public void atualizaListaProduto()
		{
			string[] coluna = new string[4];
			byte[] bufferRead = new byte[2928];
			this.plc.DBRead(24, 0, bufferRead.Length, bufferRead);
			for (int i = 0; i < 61; i++)
			{
				int nDadoDBcorrente = i * 48;
				this.produto[i].IdProduto = i;
				this.produto[i].DescricaoProduto = bufferRead.GetStringAt(nDadoDBcorrente);
				this.produto[i].CodigoModeloProduto = bufferRead.GetStringAt(28 + nDadoDBcorrente);
				this.produto[i].NumeroDaReceita = bufferRead.GetIntAt(46 + nDadoDBcorrente);
			}
			this.limpaformularioProduto();
			for (int j = 0; j < 61; j++)
			{
				coluna[0] = Convert.ToString(this.produto[j].IdProduto);
				coluna[1] = Convert.ToString(this.produto[j].DescricaoProduto);
				coluna[2] = Convert.ToString(this.produto[j].CodigoModeloProduto);
				coluna[3] = Convert.ToString(this.produto[j].NumeroDaReceita);
				ListViewItem I = new ListViewItem(coluna);
				this.ListaDadosCadastro.Items.Add(I);
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00021254 File Offset: 0x0001F454
		public void atualizaListaReceita()
		{
			string[] coluna = new string[7];
			byte[] bufferRead = new byte[756];
			this.plc.DBRead(21, 0, bufferRead.Length, bufferRead);
			for (int i = 0; i < 21; i++)
			{
				int nDadoDBcorrente = i * 36;
				this.receita[i].IdReceita = bufferRead.GetIntAt(nDadoDBcorrente);
				this.receita[i].NomeDaReceita = bufferRead.GetStringAt(2 + nDadoDBcorrente);
				this.receita[i].TMin = bufferRead.GetIntAt(30 + nDadoDBcorrente);
				this.receita[i].TMax = bufferRead.GetIntAt(32 + nDadoDBcorrente);
			}
			this.limpaformularioReceita();
			for (int j = 0; j < 21; j++)
			{
				coluna[0] = Convert.ToString(this.receita[j].IdReceita);
				coluna[1] = Convert.ToString(this.receita[j].NomeDaReceita);
				coluna[2] = Convert.ToString(this.receita[j].TMin);
				coluna[3] = Convert.ToString(this.receita[j].TMax);
				ListViewItem I = new ListViewItem(coluna);
				this.ListaDadosReceita.Items.Add(I);
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000213B4 File Offset: 0x0001F5B4
		private void atualizaHisterese()
		{
			this.conexao();
			byte[] bufferRead = new byte[408];
			this.plc.DBRead(22, 0, bufferRead.Length, bufferRead);
			this.histerese.acima = bufferRead.GetRealAt(392);
			this.histerese.abaixo = bufferRead.GetRealAt(396);
			this.histerese.acima = MathF.Round(this.histerese.acima, 1);
			this.histerese.abaixo = MathF.Round(this.histerese.abaixo, 1);
			this.HistAcima.Text = "Histerese acima: " + this.histerese.acima.ToString();
			this.HistAbaixo.Text = "Histerese abaixo: " + this.histerese.abaixo.ToString();
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00021498 File Offset: 0x0001F698
		private void button9_Click(object sender, EventArgs e)
		{
			float HACIMA = float.Parse(this.Campohisacima.Text);
			float HBAIXO = float.Parse(this.Campohisabaixo.Text);
			this.conexao();
			byte[] bufferRead = new byte[408];
			this.plc.DBRead(22, 0, bufferRead.Length, bufferRead);
			bufferRead.SetRealAt(392, HACIMA);
			bufferRead.SetRealAt(396, HBAIXO);
			this.plc.DBWrite(22, 0, bufferRead.Length, bufferRead);
			this.atualizaHisterese();
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00021521 File Offset: 0x0001F721
		public void limpaformularioProduto()
		{
			this.ListaDadosCadastro.Items.Clear();
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00021535 File Offset: 0x0001F735
		public void limpaformularioReceita()
		{
			this.ListaDadosReceita.Items.Clear();
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0002154C File Offset: 0x0001F74C
		private void button1_Click(object sender, EventArgs e)
		{
			this.conexao();
			byte[] bufferRead = new byte[2928];
			this.plc.DBRead(24, 0, bufferRead.Length, bufferRead);
			int bufferiD = int.Parse(this.TBoxIDProdutos.Text);
			string bufferDescricao = this.TBoxDescricaoProdutos.Text;
			string bufferCodigo = this.TBoxCodigoProdutos.Text;
			short bufferNReceita = short.Parse(this.TBoxReceitaProdutos.Text);
			int nDadoDBcorrente = bufferiD * 48;
			this.ListaDadosCadastro.Items[bufferiD].SubItems[0].Text = this.TBoxIDProdutos.Text;
			bufferRead.SetStringAt(nDadoDBcorrente, 25, bufferDescricao);
			bufferRead.SetStringAt(nDadoDBcorrente + 28, 15, bufferCodigo);
			bufferRead.SetIntAt(nDadoDBcorrente + 46, bufferNReceita);
			this.plc.DBWrite(24, 0, bufferRead.Length, bufferRead);
			this.preenchealteradoP();
			this.atualizaListaProduto();
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00021640 File Offset: 0x0001F840
		private void preenchealteradoP()
		{
			this.LabCBufferID.Text = this.TBoxIDProdutos.Text;
			this.LabCBufferProduto.Text = this.TBoxDescricaoProdutos.Text;
			this.LabCBufferCodigo.Text = this.TBoxCodigoProdutos.Text;
			this.LabCBufferReceita.Text = this.TBoxReceitaProdutos.Text;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000216AC File Offset: 0x0001F8AC
		private void button4_Click(object sender, EventArgs e)
		{
			this.conexao();
			byte[] bufferRead = new byte[756];
			this.plc.DBRead(21, 0, bufferRead.Length, bufferRead);
			short bufferiD = short.Parse(this.TBoxIDReceita.Text);
			string bufferDescricao = this.TBoxDescricaoReceita.Text;
			short T_MAX = short.Parse(this.TBoxTMaxReceita.Text);
			short T_MIN = short.Parse(this.TBoxTMinReceita.Text);
			int nDadoDBcorrente = (int)(bufferiD * 36);
			bufferRead.SetIntAt(nDadoDBcorrente, bufferiD);
			bufferRead.SetStringAt(nDadoDBcorrente + 2, 25, bufferDescricao);
			bufferRead.SetIntAt(nDadoDBcorrente + 30, T_MIN);
			bufferRead.SetIntAt(nDadoDBcorrente + 32, T_MAX);
			this.plc.DBWrite(21, 0, bufferRead.Length, bufferRead);
			this.preenchealteradoR();
			this.atualizaListaReceita();
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00021780 File Offset: 0x0001F980
		private void preenchealteradoR()
		{
			this.LabCBufferIDR.Text = this.TBoxIDReceita.Text;
			this.LabCBufferDescricao.Text = this.TBoxDescricaoReceita.Text;
			this.LabCBufferTMin.Text = this.TBoxTMinReceita.Text;
			this.LabCBufferTMax.Text = this.TBoxTMaxReceita.Text;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000217EC File Offset: 0x0001F9EC
		private void button6_Click(object sender, EventArgs e)
		{
			base.Hide();
			FrmDadosDosCarros frmDadosDosCarros = new FrmDadosDosCarros();
			frmDadosDosCarros.ShowDialog();
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0002180E File Offset: 0x0001FA0E
		private void FrmCadastro_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00021818 File Offset: 0x0001FA18
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

		// Token: 0x0600012C RID: 300 RVA: 0x000218C4 File Offset: 0x0001FAC4
		private void nivelum()
		{
			this.BtnsalvarP.Enabled = false;
			this.BtncancelarP.Enabled = false;
			this.BtnsalvarH.Enabled = false;
			this.BtncancelarH.Enabled = false;
			this.BtnSalvarR.Enabled = false;
			this.BtncancelarR.Enabled = false;
			this.TBoxIDProdutos.Enabled = false;
			this.TBoxDescricaoProdutos.Enabled = false;
			this.TBoxCodigoProdutos.Enabled = false;
			this.TBoxReceitaProdutos.Enabled = false;
			this.TBoxIDReceita.Enabled = false;
			this.TBoxDescricaoReceita.Enabled = false;
			this.TBoxTMinReceita.Enabled = false;
			this.TBoxTMaxReceita.Enabled = false;
			this.Campohisabaixo.Enabled = false;
			this.Campohisacima.Enabled = false;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000219A4 File Offset: 0x0001FBA4
		private void niveldois()
		{
			this.BtnsalvarP.Enabled = false;
			this.BtncancelarP.Enabled = false;
			this.BtnsalvarH.Enabled = false;
			this.BtncancelarH.Enabled = false;
			this.BtnSalvarR.Enabled = false;
			this.BtncancelarR.Enabled = false;
			this.TBoxIDProdutos.Enabled = false;
			this.TBoxDescricaoProdutos.Enabled = false;
			this.TBoxCodigoProdutos.Enabled = false;
			this.TBoxReceitaProdutos.Enabled = false;
			this.TBoxIDReceita.Enabled = false;
			this.TBoxDescricaoReceita.Enabled = false;
			this.TBoxTMinReceita.Enabled = false;
			this.TBoxTMaxReceita.Enabled = false;
			this.Campohisabaixo.Enabled = false;
			this.Campohisacima.Enabled = false;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00021A84 File Offset: 0x0001FC84
		private void niveltres()
		{
			this.BtnsalvarP.Enabled = true;
			this.BtncancelarP.Enabled = true;
			this.BtnsalvarH.Enabled = true;
			this.BtncancelarH.Enabled = true;
			this.BtnSalvarR.Enabled = true;
			this.BtncancelarR.Enabled = true;
			this.BtnsalvarP.BackColor = Color.FromArgb(68, 180, 74);
			this.BtncancelarP.BackColor = Color.FromArgb(68, 180, 74);
			this.BtnsalvarH.BackColor = Color.FromArgb(68, 180, 74);
			this.BtncancelarH.BackColor = Color.FromArgb(68, 180, 74);
			this.BtnSalvarR.BackColor = Color.FromArgb(68, 180, 74);
			this.BtncancelarR.BackColor = Color.FromArgb(68, 180, 74);
			this.TBoxIDProdutos.Enabled = true;
			this.TBoxDescricaoProdutos.Enabled = true;
			this.TBoxCodigoProdutos.Enabled = true;
			this.TBoxReceitaProdutos.Enabled = true;
			this.TBoxIDReceita.Enabled = true;
			this.TBoxDescricaoReceita.Enabled = true;
			this.TBoxTMinReceita.Enabled = true;
			this.TBoxTMaxReceita.Enabled = true;
			this.Campohisabaixo.Enabled = true;
			this.Campohisacima.Enabled = true;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00021C00 File Offset: 0x0001FE00
		private void ListaDadosCadastro_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.niveldeacesso > 1;
			if (flag)
			{
				bool flag2 = this.ListaDadosCadastro.SelectedItems.Count > 0;
				if (flag2)
				{
					this.produtoBuffer.IdProduto = this.ListaDadosCadastro.SelectedItems[0].SubItems[0].Text;
					this.produtoBuffer.DescricaoProduto = this.ListaDadosCadastro.SelectedItems[0].SubItems[1].Text;
					this.produtoBuffer.CodigoModeloProduto = this.ListaDadosCadastro.SelectedItems[0].SubItems[2].Text;
					this.produtoBuffer.NumeroDaReceita = this.ListaDadosCadastro.SelectedItems[0].SubItems[3].Text;
				}
				this.TBoxIDProdutos.Text = this.produtoBuffer.IdProduto;
				this.TBoxDescricaoProdutos.Text = this.produtoBuffer.DescricaoProduto;
				this.TBoxCodigoProdutos.Text = this.produtoBuffer.CodigoModeloProduto;
				this.TBoxReceitaProdutos.Text = this.produtoBuffer.NumeroDaReceita;
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00021D48 File Offset: 0x0001FF48
		private void ListaDadosReceita_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.niveldeacesso > 1;
			if (flag)
			{
				bool flag2 = this.ListaDadosReceita.SelectedItems.Count > 0;
				if (flag2)
				{
					this.receitaBuffer.IdReceita = this.ListaDadosReceita.SelectedItems[0].SubItems[0].Text;
					this.receitaBuffer.NomeDaReceita = this.ListaDadosReceita.SelectedItems[0].SubItems[1].Text;
					this.receitaBuffer.TMin = this.ListaDadosReceita.SelectedItems[0].SubItems[2].Text;
					this.receitaBuffer.TMax = this.ListaDadosReceita.SelectedItems[0].SubItems[3].Text;
				}
				this.TBoxIDReceita.Text = this.receitaBuffer.IdReceita;
				this.TBoxDescricaoReceita.Text = this.receitaBuffer.NomeDaReceita;
				this.TBoxTMinReceita.Text = this.receitaBuffer.TMin;
				this.TBoxTMaxReceita.Text = this.receitaBuffer.TMax;
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00021E90 File Offset: 0x00020090
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00021E9C File Offset: 0x0002009C
		private void button5_Click(object sender, EventArgs e)
		{
			this.TBoxIDProdutos.Text = "";
			this.TBoxDescricaoProdutos.Text = "";
			this.TBoxCodigoProdutos.Text = "";
			this.TBoxReceitaProdutos.Text = "";
			this.produtoBuffer.IdProduto = null;
			this.produtoBuffer.DescricaoProduto = null;
			this.produtoBuffer.CodigoModeloProduto = null;
			this.produtoBuffer.NumeroDaReceita = null;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00021F20 File Offset: 0x00020120
		private void button8_Click(object sender, EventArgs e)
		{
			this.TBoxIDReceita.Text = "";
			this.TBoxDescricaoReceita.Text = "";
			this.TBoxTMinReceita.Text = "";
			this.TBoxTMaxReceita.Text = "";
			this.receitaBuffer.IdReceita = null;
			this.receitaBuffer.NomeDaReceita = null;
			this.receitaBuffer.TMin = null;
			this.receitaBuffer.TMax = null;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00021FA2 File Offset: 0x000201A2
		private void button10_Click(object sender, EventArgs e)
		{
			this.Campohisacima.Text = "";
			this.Campohisabaixo.Text = "";
			this.atualizaHisterese();
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00021FCE File Offset: 0x000201CE
		private void button1_Click_1(object sender, EventArgs e)
		{
			this.conexao();
			this.metodosDeIncializacaodoForm();
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00021FDF File Offset: 0x000201DF
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x040001DD RID: 477
		private S7Client plc = new S7Client();

		// Token: 0x040001DE RID: 478
		public FrmCadastro.Produtos[] produto = new FrmCadastro.Produtos[61];

		// Token: 0x040001DF RID: 479
		public FrmCadastro.ProdutosB produtoBuffer = default(FrmCadastro.ProdutosB);

		// Token: 0x040001E0 RID: 480
		public FrmCadastro.Receitas[] receita = new FrmCadastro.Receitas[21];

		// Token: 0x040001E1 RID: 481
		public FrmCadastro.ReceitasB receitaBuffer = default(FrmCadastro.ReceitasB);

		// Token: 0x040001E2 RID: 482
		public FrmCadastro.Histerese histerese = default(FrmCadastro.Histerese);

		// Token: 0x040001E3 RID: 483
		public string caminho = Environment.CurrentDirectory;

		// Token: 0x040001E4 RID: 484
		public int tempo;

		// Token: 0x040001E5 RID: 485
		public bool conectado = false;

		// Token: 0x040001E6 RID: 486
		public int niveldeacesso = 0;

		// Token: 0x040001E7 RID: 487
		public bool permissao = false;

		// Token: 0x02000026 RID: 38
		public struct Produtos
		{
			// Token: 0x040003A5 RID: 933
			public int IdProduto;

			// Token: 0x040003A6 RID: 934
			public string DescricaoProduto;

			// Token: 0x040003A7 RID: 935
			public string CodigoModeloProduto;

			// Token: 0x040003A8 RID: 936
			public int NumeroDaReceita;
		}

		// Token: 0x02000027 RID: 39
		public struct ProdutosB
		{
			// Token: 0x040003A9 RID: 937
			public string IdProduto;

			// Token: 0x040003AA RID: 938
			public string DescricaoProduto;

			// Token: 0x040003AB RID: 939
			public string CodigoModeloProduto;

			// Token: 0x040003AC RID: 940
			public string NumeroDaReceita;
		}

		// Token: 0x02000028 RID: 40
		public struct Receitas
		{
			// Token: 0x040003AD RID: 941
			public int IdReceita;

			// Token: 0x040003AE RID: 942
			public string NomeDaReceita;

			// Token: 0x040003AF RID: 943
			public int TMin;

			// Token: 0x040003B0 RID: 944
			public int TMax;
		}

		// Token: 0x02000029 RID: 41
		public struct ReceitasB
		{
			// Token: 0x040003B1 RID: 945
			public string IdReceita;

			// Token: 0x040003B2 RID: 946
			public string NomeDaReceita;

			// Token: 0x040003B3 RID: 947
			public string TMin;

			// Token: 0x040003B4 RID: 948
			public string TMax;
		}

		// Token: 0x0200002A RID: 42
		public struct Histerese
		{
			// Token: 0x040003B5 RID: 949
			public float acima;

			// Token: 0x040003B6 RID: 950
			public float abaixo;
		}
	}
}
