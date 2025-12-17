namespace SupervisorioDana
{
	// Token: 0x02000005 RID: 5
	public partial class FrmCadastro1920x1080 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000060 RID: 96 RVA: 0x00006A70 File Offset: 0x00004C70
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00006AA8 File Offset: 0x00004CA8
		private void InitializeComponent()
		{
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro1920x1080));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.ListaDadosCadastro = new System.Windows.Forms.ListView();
            this.ColId = new System.Windows.Forms.ColumnHeader();
            this.ColDescrição = new System.Windows.Forms.ColumnHeader();
            this.ColCodigo = new System.Windows.Forms.ColumnHeader();
            this.ColReceita = new System.Windows.Forms.ColumnHeader();
            this.BtnsalvarP = new System.Windows.Forms.Button();
            this.TBoxReceitaProdutos = new System.Windows.Forms.TextBox();
            this.TBoxCodigoProdutos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBoxDescricaoProdutos = new System.Windows.Forms.TextBox();
            this.TBoxIDProdutos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnSalvarR = new System.Windows.Forms.Button();
            this.BtncancelarR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabCBufferTMin = new System.Windows.Forms.Label();
            this.LabCBufferTMax = new System.Windows.Forms.Label();
            this.LabCBufferDescricao = new System.Windows.Forms.Label();
            this.LabCBufferIDR = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.LabCBufferReceita = new System.Windows.Forms.Label();
            this.LabCBufferCodigo = new System.Windows.Forms.Label();
            this.LabCBufferProduto = new System.Windows.Forms.Label();
            this.LabCBufferID = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ListaDadosReceita = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.BtncancelarP = new System.Windows.Forms.Button();
            this.TBoxTMaxReceita = new System.Windows.Forms.TextBox();
            this.TBoxTMinReceita = new System.Windows.Forms.TextBox();
            this.TBoxDescricaoReceita = new System.Windows.Forms.TextBox();
            this.TBoxIDReceita = new System.Windows.Forms.TextBox();
            this.Campohisabaixo = new System.Windows.Forms.TextBox();
            this.Campohisacima = new System.Windows.Forms.TextBox();
            this.HistAcima = new System.Windows.Forms.Label();
            this.HistAbaixo = new System.Windows.Forms.Label();
            this.BtnsalvarH = new System.Windows.Forms.Button();
            this.BtncancelarH = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "CADASTRO";
            // 
            // BtnInicio
            // 
            this.BtnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.BtnInicio.Location = new System.Drawing.Point(10, 50);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(150, 40);
            this.BtnInicio.TabIndex = 40;
            this.BtnInicio.Text = "Inicio";
            this.BtnInicio.UseVisualStyleBackColor = false;
            this.BtnInicio.Click += new System.EventHandler(this.button6_Click);
            // 
            // ListaDadosCadastro
            // 
            this.ListaDadosCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.ListaDadosCadastro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaDadosCadastro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColId,
            this.ColDescrição,
            this.ColCodigo,
            this.ColReceita});
            this.ListaDadosCadastro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListaDadosCadastro.ForeColor = System.Drawing.Color.White;
            this.ListaDadosCadastro.FullRowSelect = true;
            this.ListaDadosCadastro.HideSelection = false;
            this.ListaDadosCadastro.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ListaDadosCadastro.Location = new System.Drawing.Point(198, 68);
            this.ListaDadosCadastro.Name = "ListaDadosCadastro";
            this.ListaDadosCadastro.Size = new System.Drawing.Size(653, 721);
            this.ListaDadosCadastro.TabIndex = 44;
            this.ListaDadosCadastro.UseCompatibleStateImageBehavior = false;
            this.ListaDadosCadastro.View = System.Windows.Forms.View.Details;
            this.ListaDadosCadastro.SelectedIndexChanged += new System.EventHandler(this.ListaDadosCadastro_SelectedIndexChanged);
            // 
            // ColId
            // 
            this.ColId.Text = "ID";
            // 
            // ColDescrição
            // 
            this.ColDescrição.Text = "Produto";
            this.ColDescrição.Width = 300;
            // 
            // ColCodigo
            // 
            this.ColCodigo.Text = "Codigo";
            this.ColCodigo.Width = 170;
            // 
            // ColReceita
            // 
            this.ColReceita.Text = "Receita";
            this.ColReceita.Width = 100;
            // 
            // BtnsalvarP
            // 
            this.BtnsalvarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.BtnsalvarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnsalvarP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnsalvarP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.BtnsalvarP.Location = new System.Drawing.Point(670, 885);
            this.BtnsalvarP.Name = "BtnsalvarP";
            this.BtnsalvarP.Size = new System.Drawing.Size(160, 60);
            this.BtnsalvarP.TabIndex = 45;
            this.BtnsalvarP.Text = "Salvar";
            this.BtnsalvarP.UseVisualStyleBackColor = false;
            this.BtnsalvarP.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBoxReceitaProdutos
            // 
            this.TBoxReceitaProdutos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBoxReceitaProdutos.Location = new System.Drawing.Point(421, 987);
            this.TBoxReceitaProdutos.Name = "TBoxReceitaProdutos";
            this.TBoxReceitaProdutos.Size = new System.Drawing.Size(221, 29);
            this.TBoxReceitaProdutos.TabIndex = 54;
            // 
            // TBoxCodigoProdutos
            // 
            this.TBoxCodigoProdutos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBoxCodigoProdutos.Location = new System.Drawing.Point(421, 953);
            this.TBoxCodigoProdutos.Name = "TBoxCodigoProdutos";
            this.TBoxCodigoProdutos.Size = new System.Drawing.Size(221, 29);
            this.TBoxCodigoProdutos.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(310, 890);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 21);
            this.label6.TabIndex = 47;
            this.label6.Text = "Identificador";
            // 
            // TBoxDescricaoProdutos
            // 
            this.TBoxDescricaoProdutos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBoxDescricaoProdutos.Location = new System.Drawing.Point(421, 919);
            this.TBoxDescricaoProdutos.Name = "TBoxDescricaoProdutos";
            this.TBoxDescricaoProdutos.Size = new System.Drawing.Size(221, 29);
            this.TBoxDescricaoProdutos.TabIndex = 52;
            // 
            // TBoxIDProdutos
            // 
            this.TBoxIDProdutos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBoxIDProdutos.Location = new System.Drawing.Point(421, 885);
            this.TBoxIDProdutos.Name = "TBoxIDProdutos";
            this.TBoxIDProdutos.ReadOnly = true;
            this.TBoxIDProdutos.Size = new System.Drawing.Size(221, 29);
            this.TBoxIDProdutos.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(318, 923);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 48;
            this.label7.Text = "Descrição";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(323, 988);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 21);
            this.label9.TabIndex = 50;
            this.label9.Text = "Receita";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(323, 956);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 21);
            this.label8.TabIndex = 49;
            this.label8.Text = "Codigo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(472, 319);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 15);
            this.label13.TabIndex = 57;
            this.label13.Text = "Identificador";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(479, 351);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 15);
            this.label12.TabIndex = 58;
            this.label12.Text = "Descrição";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(486, 412);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 60;
            this.label10.Text = "T.Max";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(485, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 15);
            this.label11.TabIndex = 59;
            this.label11.Text = "T.Mim";
            // 
            // BtnSalvarR
            // 
            this.BtnSalvarR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.BtnSalvarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvarR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSalvarR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.BtnSalvarR.Location = new System.Drawing.Point(1695, 885);
            this.BtnSalvarR.Name = "BtnSalvarR";
            this.BtnSalvarR.Size = new System.Drawing.Size(160, 60);
            this.BtnSalvarR.TabIndex = 55;
            this.BtnSalvarR.Text = "Salvar";
            this.BtnSalvarR.UseVisualStyleBackColor = false;
            this.BtnSalvarR.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtncancelarR
            // 
            this.BtncancelarR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.BtncancelarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtncancelarR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtncancelarR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.BtncancelarR.Location = new System.Drawing.Point(1695, 960);
            this.BtncancelarR.Name = "BtncancelarR";
            this.BtncancelarR.Size = new System.Drawing.Size(160, 60);
            this.BtncancelarR.TabIndex = 56;
            this.BtncancelarR.Text = "Cancelar";
            this.BtncancelarR.UseVisualStyleBackColor = false;
            this.BtncancelarR.Click += new System.EventHandler(this.button8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1318, 890);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 57;
            this.label2.Text = "Identificador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1329, 923);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 58;
            this.label3.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1338, 988);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 60;
            this.label4.Text = "T.Ideal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1333, 956);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 21);
            this.label5.TabIndex = 59;
            this.label5.Text = "T.Alarme";
            // 
            // LabCBufferTMin
            // 
            this.LabCBufferTMin.AutoSize = true;
            this.LabCBufferTMin.BackColor = System.Drawing.Color.Transparent;
            this.LabCBufferTMin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabCBufferTMin.ForeColor = System.Drawing.Color.White;
            this.LabCBufferTMin.Location = new System.Drawing.Point(920, 730);
            this.LabCBufferTMin.Name = "LabCBufferTMin";
            this.LabCBufferTMin.Size = new System.Drawing.Size(183, 25);
            this.LabCBufferTMin.TabIndex = 69;
            this.LabCBufferTMin.Text = "Temperatura Ideal: ";
            // 
            // LabCBufferTMax
            // 
            this.LabCBufferTMax.AutoSize = true;
            this.LabCBufferTMax.BackColor = System.Drawing.Color.Transparent;
            this.LabCBufferTMax.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabCBufferTMax.ForeColor = System.Drawing.Color.White;
            this.LabCBufferTMax.Location = new System.Drawing.Point(920, 670);
            this.LabCBufferTMax.Name = "LabCBufferTMax";
            this.LabCBufferTMax.Size = new System.Drawing.Size(230, 25);
            this.LabCBufferTMax.TabIndex = 68;
            this.LabCBufferTMax.Text = "Temperatura de Alarme: ";
            // 
            // LabCBufferDescricao
            // 
            this.LabCBufferDescricao.AutoSize = true;
            this.LabCBufferDescricao.BackColor = System.Drawing.Color.Transparent;
            this.LabCBufferDescricao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabCBufferDescricao.ForeColor = System.Drawing.Color.White;
            this.LabCBufferDescricao.Location = new System.Drawing.Point(920, 610);
            this.LabCBufferDescricao.Name = "LabCBufferDescricao";
            this.LabCBufferDescricao.Size = new System.Drawing.Size(102, 25);
            this.LabCBufferDescricao.TabIndex = 67;
            this.LabCBufferDescricao.Text = "Descrição:";
            // 
            // LabCBufferIDR
            // 
            this.LabCBufferIDR.AutoSize = true;
            this.LabCBufferIDR.BackColor = System.Drawing.Color.Transparent;
            this.LabCBufferIDR.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabCBufferIDR.ForeColor = System.Drawing.Color.White;
            this.LabCBufferIDR.Location = new System.Drawing.Point(920, 550);
            this.LabCBufferIDR.Name = "LabCBufferIDR";
            this.LabCBufferIDR.Size = new System.Drawing.Size(37, 25);
            this.LabCBufferIDR.TabIndex = 66;
            this.LabCBufferIDR.Text = "ID:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(986, 481);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(172, 30);
            this.label20.TabIndex = 65;
            this.label20.Text = "Receita Alterada";
            // 
            // LabCBufferReceita
            // 
            this.LabCBufferReceita.AutoSize = true;
            this.LabCBufferReceita.BackColor = System.Drawing.Color.Transparent;
            this.LabCBufferReceita.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabCBufferReceita.ForeColor = System.Drawing.Color.White;
            this.LabCBufferReceita.Location = new System.Drawing.Point(920, 350);
            this.LabCBufferReceita.Name = "LabCBufferReceita";
            this.LabCBufferReceita.Size = new System.Drawing.Size(80, 25);
            this.LabCBufferReceita.TabIndex = 74;
            this.LabCBufferReceita.Text = "Receita:";
            // 
            // LabCBufferCodigo
            // 
            this.LabCBufferCodigo.AutoSize = true;
            this.LabCBufferCodigo.BackColor = System.Drawing.Color.Transparent;
            this.LabCBufferCodigo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabCBufferCodigo.ForeColor = System.Drawing.Color.White;
            this.LabCBufferCodigo.Location = new System.Drawing.Point(920, 290);
            this.LabCBufferCodigo.Name = "LabCBufferCodigo";
            this.LabCBufferCodigo.Size = new System.Drawing.Size(82, 25);
            this.LabCBufferCodigo.TabIndex = 73;
            this.LabCBufferCodigo.Text = "Codigo:";
            // 
            // LabCBufferProduto
            // 
            this.LabCBufferProduto.AutoSize = true;
            this.LabCBufferProduto.BackColor = System.Drawing.Color.Transparent;
            this.LabCBufferProduto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabCBufferProduto.ForeColor = System.Drawing.Color.White;
            this.LabCBufferProduto.Location = new System.Drawing.Point(920, 230);
            this.LabCBufferProduto.Name = "LabCBufferProduto";
            this.LabCBufferProduto.Size = new System.Drawing.Size(97, 25);
            this.LabCBufferProduto.TabIndex = 72;
            this.LabCBufferProduto.Text = "Produto: ";
            // 
            // LabCBufferID
            // 
            this.LabCBufferID.AutoSize = true;
            this.LabCBufferID.BackColor = System.Drawing.Color.Transparent;
            this.LabCBufferID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabCBufferID.ForeColor = System.Drawing.Color.White;
            this.LabCBufferID.Location = new System.Drawing.Point(920, 180);
            this.LabCBufferID.Name = "LabCBufferID";
            this.LabCBufferID.Size = new System.Drawing.Size(42, 25);
            this.LabCBufferID.TabIndex = 71;
            this.LabCBufferID.Text = "ID: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(990, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(185, 30);
            this.label16.TabIndex = 70;
            this.label16.Text = "Produto Alterado";
            // 
            // ListaDadosReceita
            // 
            this.ListaDadosReceita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.ListaDadosReceita.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaDadosReceita.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ListaDadosReceita.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListaDadosReceita.ForeColor = System.Drawing.Color.White;
            this.ListaDadosReceita.FullRowSelect = true;
            this.ListaDadosReceita.HideSelection = false;
            this.ListaDadosReceita.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.ListaDadosReceita.Location = new System.Drawing.Point(1299, 68);
            this.ListaDadosReceita.Name = "ListaDadosReceita";
            this.ListaDadosReceita.Size = new System.Drawing.Size(586, 721);
            this.ListaDadosReceita.TabIndex = 75;
            this.ListaDadosReceita.UseCompatibleStateImageBehavior = false;
            this.ListaDadosReceita.View = System.Windows.Forms.View.Details;
            this.ListaDadosReceita.SelectedIndexChanged += new System.EventHandler(this.ListaDadosReceita_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descrição";
            this.columnHeader2.Width = 340;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "T alarme";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "T ideal";
            this.columnHeader4.Width = 80;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1880, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(0, 0);
            this.textBox5.MaximumSize = new System.Drawing.Size(0, 30);
            this.textBox5.MinimumSize = new System.Drawing.Size(0, 40);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(1386, 40);
            this.textBox5.TabIndex = 77;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(1383, 40);
            this.textBox7.MaximumSize = new System.Drawing.Size(3, 1000);
            this.textBox7.MinimumSize = new System.Drawing.Size(3, 1000);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(3, 16);
            this.textBox7.TabIndex = 79;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(0, 785);
            this.textBox8.MaximumSize = new System.Drawing.Size(0, 3);
            this.textBox8.MinimumSize = new System.Drawing.Size(0, 3);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(1383, 3);
            this.textBox8.TabIndex = 80;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(-267, -146);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.textBox6.MaximumSize = new System.Drawing.Size(4, 1920);
            this.textBox6.MinimumSize = new System.Drawing.Size(4, 1920);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(4, 1920);
            this.textBox6.TabIndex = 81;
            // 
            // BtncancelarP
            // 
            this.BtncancelarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.BtncancelarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtncancelarP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtncancelarP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.BtncancelarP.Location = new System.Drawing.Point(670, 960);
            this.BtncancelarP.Name = "BtncancelarP";
            this.BtncancelarP.Size = new System.Drawing.Size(160, 60);
            this.BtncancelarP.TabIndex = 82;
            this.BtncancelarP.Text = "Cancelar";
            this.BtncancelarP.UseVisualStyleBackColor = false;
            this.BtncancelarP.Click += new System.EventHandler(this.button5_Click);
            // 
            // TBoxTMaxReceita
            // 
            this.TBoxTMaxReceita.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBoxTMaxReceita.Location = new System.Drawing.Point(1441, 987);
            this.TBoxTMaxReceita.Name = "TBoxTMaxReceita";
            this.TBoxTMaxReceita.Size = new System.Drawing.Size(221, 29);
            this.TBoxTMaxReceita.TabIndex = 86;
            // 
            // TBoxTMinReceita
            // 
            this.TBoxTMinReceita.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBoxTMinReceita.Location = new System.Drawing.Point(1441, 953);
            this.TBoxTMinReceita.Name = "TBoxTMinReceita";
            this.TBoxTMinReceita.Size = new System.Drawing.Size(221, 29);
            this.TBoxTMinReceita.TabIndex = 85;
            // 
            // TBoxDescricaoReceita
            // 
            this.TBoxDescricaoReceita.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBoxDescricaoReceita.Location = new System.Drawing.Point(1441, 919);
            this.TBoxDescricaoReceita.Name = "TBoxDescricaoReceita";
            this.TBoxDescricaoReceita.Size = new System.Drawing.Size(221, 29);
            this.TBoxDescricaoReceita.TabIndex = 84;
            // 
            // TBoxIDReceita
            // 
            this.TBoxIDReceita.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBoxIDReceita.Location = new System.Drawing.Point(1441, 885);
            this.TBoxIDReceita.Name = "TBoxIDReceita";
            this.TBoxIDReceita.ReadOnly = true;
            this.TBoxIDReceita.Size = new System.Drawing.Size(221, 29);
            this.TBoxIDReceita.TabIndex = 83;
            // 
            // Campohisabaixo
            // 
            this.Campohisabaixo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Campohisabaixo.Location = new System.Drawing.Point(869, 978);
            this.Campohisabaixo.Name = "Campohisabaixo";
            this.Campohisabaixo.Size = new System.Drawing.Size(221, 29);
            this.Campohisabaixo.TabIndex = 90;
            // 
            // Campohisacima
            // 
            this.Campohisacima.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Campohisacima.Location = new System.Drawing.Point(869, 911);
            this.Campohisacima.Name = "Campohisacima";
            this.Campohisacima.Size = new System.Drawing.Size(221, 29);
            this.Campohisacima.TabIndex = 89;
            // 
            // HistAcima
            // 
            this.HistAcima.AutoSize = true;
            this.HistAcima.BackColor = System.Drawing.Color.Transparent;
            this.HistAcima.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HistAcima.ForeColor = System.Drawing.Color.White;
            this.HistAcima.Location = new System.Drawing.Point(917, 884);
            this.HistAcima.Name = "HistAcima";
            this.HistAcima.Size = new System.Drawing.Size(126, 21);
            this.HistAcima.TabIndex = 87;
            this.HistAcima.Text = "Histerese acima: ";
            // 
            // HistAbaixo
            // 
            this.HistAbaixo.AutoSize = true;
            this.HistAbaixo.BackColor = System.Drawing.Color.Transparent;
            this.HistAbaixo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HistAbaixo.ForeColor = System.Drawing.Color.White;
            this.HistAbaixo.Location = new System.Drawing.Point(914, 953);
            this.HistAbaixo.Name = "HistAbaixo";
            this.HistAbaixo.Size = new System.Drawing.Size(130, 21);
            this.HistAbaixo.TabIndex = 88;
            this.HistAbaixo.Text = "Histerese abaixo: ";
            // 
            // BtnsalvarH
            // 
            this.BtnsalvarH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.BtnsalvarH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnsalvarH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnsalvarH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.BtnsalvarH.Location = new System.Drawing.Point(1117, 885);
            this.BtnsalvarH.Name = "BtnsalvarH";
            this.BtnsalvarH.Size = new System.Drawing.Size(160, 60);
            this.BtnsalvarH.TabIndex = 91;
            this.BtnsalvarH.Text = "Salvar";
            this.BtnsalvarH.UseVisualStyleBackColor = false;
            this.BtnsalvarH.Click += new System.EventHandler(this.button9_Click);
            // 
            // BtncancelarH
            // 
            this.BtncancelarH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.BtncancelarH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtncancelarH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtncancelarH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.BtncancelarH.Location = new System.Drawing.Point(1117, 960);
            this.BtncancelarH.Name = "BtncancelarH";
            this.BtncancelarH.Size = new System.Drawing.Size(160, 60);
            this.BtncancelarH.TabIndex = 92;
            this.BtncancelarH.Text = "Cancelar";
            this.BtncancelarH.UseVisualStyleBackColor = false;
            this.BtncancelarH.Click += new System.EventHandler(this.button10_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(950, 838);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(235, 25);
            this.label14.TabIndex = 93;
            this.label14.Text = "Controle de Temperatura";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(430, 843);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(206, 25);
            this.label15.TabIndex = 94;
            this.label15.Text = "Cadastro de produtos";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(1450, 844);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(194, 25);
            this.label17.TabIndex = 95;
            this.label17.Text = "Cadastro de Receitas";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1850, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 96;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.button1.Location = new System.Drawing.Point(10, 800);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 192;
            this.button1.Text = "Recarregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmCadastro1920x1080
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.BtncancelarH);
            this.Controls.Add(this.BtnsalvarH);
            this.Controls.Add(this.Campohisabaixo);
            this.Controls.Add(this.Campohisacima);
            this.Controls.Add(this.HistAcima);
            this.Controls.Add(this.HistAbaixo);
            this.Controls.Add(this.TBoxTMaxReceita);
            this.Controls.Add(this.TBoxTMinReceita);
            this.Controls.Add(this.TBoxDescricaoReceita);
            this.Controls.Add(this.TBoxIDReceita);
            this.Controls.Add(this.BtncancelarP);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ListaDadosReceita);
            this.Controls.Add(this.LabCBufferReceita);
            this.Controls.Add(this.LabCBufferCodigo);
            this.Controls.Add(this.LabCBufferProduto);
            this.Controls.Add(this.LabCBufferID);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.LabCBufferTMin);
            this.Controls.Add(this.LabCBufferTMax);
            this.Controls.Add(this.LabCBufferDescricao);
            this.Controls.Add(this.LabCBufferIDR);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.BtnSalvarR);
            this.Controls.Add(this.BtncancelarR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnsalvarP);
            this.Controls.Add(this.TBoxReceitaProdutos);
            this.Controls.Add(this.TBoxCodigoProdutos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBoxDescricaoProdutos);
            this.Controls.Add(this.TBoxIDProdutos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ListaDadosCadastro);
            this.Controls.Add(this.BtnInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCadastro1920x1080";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cadastro de Produtos e Receitas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadastro_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadastro1920x1080_Load);
            this.Shown += new System.EventHandler(this.FrmCadastro_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000051 RID: 81
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.Button BtnInicio;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.ListView ListaDadosCadastro;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.ColumnHeader ColId;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.ColumnHeader ColDescrição;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.ColumnHeader ColCodigo;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.ColumnHeader ColReceita;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.Button BtnsalvarP;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.TextBox TBoxReceitaProdutos;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.TextBox TBoxCodigoProdutos;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.TextBox TBoxDescricaoProdutos;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.TextBox TBoxIDProdutos;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.Button BtnSalvarR;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.Button BtncancelarR;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400006A RID: 106
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.Label LabCBufferTMin;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.Label LabCBufferTMax;

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Forms.Label LabCBufferDescricao;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.Label LabCBufferIDR;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Forms.Label label20;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.Label LabCBufferReceita;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.Label LabCBufferCodigo;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.Label LabCBufferProduto;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.Label LabCBufferID;

		// Token: 0x04000075 RID: 117
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04000076 RID: 118
		private global::System.Windows.Forms.ListView ListaDadosReceita;

		// Token: 0x04000077 RID: 119
		private global::System.Windows.Forms.ColumnHeader columnHeader1;

		// Token: 0x04000078 RID: 120
		private global::System.Windows.Forms.ColumnHeader columnHeader2;

		// Token: 0x04000079 RID: 121
		private global::System.Windows.Forms.ColumnHeader columnHeader3;

		// Token: 0x0400007A RID: 122
		private global::System.Windows.Forms.ColumnHeader columnHeader4;

		// Token: 0x0400007B RID: 123
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400007C RID: 124
		private global::System.Windows.Forms.TextBox textBox5;

		// Token: 0x0400007D RID: 125
		private global::System.Windows.Forms.TextBox textBox7;

		// Token: 0x0400007E RID: 126
		private global::System.Windows.Forms.TextBox textBox8;

		// Token: 0x0400007F RID: 127
		private global::System.Windows.Forms.TextBox textBox6;

		// Token: 0x04000080 RID: 128
		private global::System.Windows.Forms.Button BtncancelarP;

		// Token: 0x04000081 RID: 129
		private global::System.Windows.Forms.TextBox TBoxTMaxReceita;

		// Token: 0x04000082 RID: 130
		private global::System.Windows.Forms.TextBox TBoxTMinReceita;

		// Token: 0x04000083 RID: 131
		private global::System.Windows.Forms.TextBox TBoxDescricaoReceita;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.Forms.TextBox TBoxIDReceita;

		// Token: 0x04000085 RID: 133
		private global::System.Windows.Forms.TextBox Campohisabaixo;

		// Token: 0x04000086 RID: 134
		private global::System.Windows.Forms.TextBox Campohisacima;

		// Token: 0x04000087 RID: 135
		private global::System.Windows.Forms.Label HistAcima;

		// Token: 0x04000088 RID: 136
		private global::System.Windows.Forms.Label HistAbaixo;

		// Token: 0x04000089 RID: 137
		private global::System.Windows.Forms.Button BtnsalvarH;

		// Token: 0x0400008A RID: 138
		private global::System.Windows.Forms.Button BtncancelarH;

		// Token: 0x0400008B RID: 139
		private global::System.Windows.Forms.Label label14;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.Label label15;

		// Token: 0x0400008D RID: 141
		private global::System.Windows.Forms.Label label17;

		// Token: 0x0400008E RID: 142
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x0400008F RID: 143
		private global::System.Windows.Forms.Button button1;
	}
}
