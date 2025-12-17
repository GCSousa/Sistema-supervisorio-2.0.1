using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Sharp7;

namespace SupervisorioDana
{
	// Token: 0x02000005 RID: 5
	public partial class FrmCadastro1920x1080 : Form
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00005A10 File Offset: 0x00003C10
		public FrmCadastro1920x1080()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00005A9C File Offset: 0x00003C9C
		private void metodosDeIncializacaodoForm()
		{
			this.leusuario();
			this.conexao();
			this.atualizaListaProduto();
			this.atualizaListaReceita();
			this.atualizaHisterese();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00005AC4 File Offset: 0x00003CC4
		private void FrmCadastro_Shown(object sender, EventArgs e)
		{
			base.Hide();
			Carregando1920x1080 telatemp = new Carregando1920x1080();
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

		// Token: 0x06000046 RID: 70 RVA: 0x00005B10 File Offset: 0x00003D10
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

		// Token: 0x06000047 RID: 71 RVA: 0x00005B7C File Offset: 0x00003D7C
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

		// Token: 0x06000048 RID: 72 RVA: 0x00005CD4 File Offset: 0x00003ED4
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

		// Token: 0x06000049 RID: 73 RVA: 0x00005E34 File Offset: 0x00004034
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

		// Token: 0x0600004A RID: 74 RVA: 0x00005F18 File Offset: 0x00004118
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

		// Token: 0x0600004B RID: 75 RVA: 0x00005FA1 File Offset: 0x000041A1
		public void limpaformularioProduto()
		{
			this.ListaDadosCadastro.Items.Clear();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00005FB5 File Offset: 0x000041B5
		public void limpaformularioReceita()
		{
			this.ListaDadosReceita.Items.Clear();
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00005FCC File Offset: 0x000041CC
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

		// Token: 0x0600004E RID: 78 RVA: 0x000060C0 File Offset: 0x000042C0
		private void preenchealteradoP()
		{
			this.LabCBufferID.Text = this.TBoxIDProdutos.Text;
			this.LabCBufferProduto.Text = this.TBoxDescricaoProdutos.Text;
			this.LabCBufferCodigo.Text = this.TBoxCodigoProdutos.Text;
			this.LabCBufferReceita.Text = this.TBoxReceitaProdutos.Text;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000612C File Offset: 0x0000432C
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

		// Token: 0x06000050 RID: 80 RVA: 0x00006200 File Offset: 0x00004400
		private void preenchealteradoR()
		{
			this.LabCBufferIDR.Text = this.TBoxIDReceita.Text;
			this.LabCBufferDescricao.Text = this.TBoxDescricaoReceita.Text;
			this.LabCBufferTMin.Text = this.TBoxTMinReceita.Text;
			this.LabCBufferTMax.Text = this.TBoxTMaxReceita.Text;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000626C File Offset: 0x0000446C
		private void button6_Click(object sender, EventArgs e)
		{
			base.Hide();
			FrmDadosDosCarros1920x1080 frmDadosDosCarros = new FrmDadosDosCarros1920x1080();
			frmDadosDosCarros.ShowDialog();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000628E File Offset: 0x0000448E
		private void FrmCadastro_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00006298 File Offset: 0x00004498
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

		// Token: 0x06000054 RID: 84 RVA: 0x00006344 File Offset: 0x00004544
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

		// Token: 0x06000055 RID: 85 RVA: 0x00006424 File Offset: 0x00004624
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

		// Token: 0x06000056 RID: 86 RVA: 0x00006504 File Offset: 0x00004704
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

		// Token: 0x06000057 RID: 87 RVA: 0x00006680 File Offset: 0x00004880
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

		// Token: 0x06000058 RID: 88 RVA: 0x000067C8 File Offset: 0x000049C8
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

		// Token: 0x06000059 RID: 89 RVA: 0x00006910 File Offset: 0x00004B10
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000691C File Offset: 0x00004B1C
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

		// Token: 0x0600005B RID: 91 RVA: 0x000069A0 File Offset: 0x00004BA0
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

		// Token: 0x0600005C RID: 92 RVA: 0x00006A22 File Offset: 0x00004C22
		private void button10_Click(object sender, EventArgs e)
		{
			this.Campohisacima.Text = "";
			this.Campohisabaixo.Text = "";
			this.atualizaHisterese();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00006A4E File Offset: 0x00004C4E
		private void FrmCadastro1920x1080_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00006A51 File Offset: 0x00004C51
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00006A5C File Offset: 0x00004C5C
		private void button1_Click_1(object sender, EventArgs e)
		{
			this.conexao();
			this.metodosDeIncializacaodoForm();
		}

		// Token: 0x04000046 RID: 70
		private S7Client plc = new S7Client();

		// Token: 0x04000047 RID: 71
		public FrmCadastro1920x1080.Produtos[] produto = new FrmCadastro1920x1080.Produtos[61];

		// Token: 0x04000048 RID: 72
		public FrmCadastro1920x1080.ProdutosB produtoBuffer = default(FrmCadastro1920x1080.ProdutosB);

		// Token: 0x04000049 RID: 73
		public FrmCadastro1920x1080.Receitas[] receita = new FrmCadastro1920x1080.Receitas[21];

		// Token: 0x0400004A RID: 74
		public FrmCadastro1920x1080.ReceitasB receitaBuffer = default(FrmCadastro1920x1080.ReceitasB);

		// Token: 0x0400004B RID: 75
		public FrmCadastro1920x1080.Histerese histerese = default(FrmCadastro1920x1080.Histerese);

		// Token: 0x0400004C RID: 76
		public string caminho = Environment.CurrentDirectory;

		// Token: 0x0400004D RID: 77
		public int tempo;

		// Token: 0x0400004E RID: 78
		public bool conectado = false;

		// Token: 0x0400004F RID: 79
		public int niveldeacesso = 0;

		// Token: 0x04000050 RID: 80
		public bool permissao = false;

		// Token: 0x02000016 RID: 22
		public struct Produtos
		{
			// Token: 0x04000343 RID: 835
			public int IdProduto;

			// Token: 0x04000344 RID: 836
			public string DescricaoProduto;

			// Token: 0x04000345 RID: 837
			public string CodigoModeloProduto;

			// Token: 0x04000346 RID: 838
			public int NumeroDaReceita;
		}

		// Token: 0x02000017 RID: 23
		public struct ProdutosB
		{
			// Token: 0x04000347 RID: 839
			public string IdProduto;

			// Token: 0x04000348 RID: 840
			public string DescricaoProduto;

			// Token: 0x04000349 RID: 841
			public string CodigoModeloProduto;

			// Token: 0x0400034A RID: 842
			public string NumeroDaReceita;
		}

		// Token: 0x02000018 RID: 24
		public struct Receitas
		{
			// Token: 0x0400034B RID: 843
			public int IdReceita;

			// Token: 0x0400034C RID: 844
			public string NomeDaReceita;

			// Token: 0x0400034D RID: 845
			public int TMin;

			// Token: 0x0400034E RID: 846
			public int TMax;
		}

		// Token: 0x02000019 RID: 25
		public struct ReceitasB
		{
			// Token: 0x0400034F RID: 847
			public string IdReceita;

			// Token: 0x04000350 RID: 848
			public string NomeDaReceita;

			// Token: 0x04000351 RID: 849
			public string TMin;

			// Token: 0x04000352 RID: 850
			public string TMax;
		}

		// Token: 0x0200001A RID: 26
		public struct Histerese
		{
			// Token: 0x04000353 RID: 851
			public float acima;

			// Token: 0x04000354 RID: 852
			public float abaixo;
		}
	}
}
