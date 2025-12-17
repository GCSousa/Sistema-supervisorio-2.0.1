namespace SupervisorioDana
{
	// Token: 0x0200000C RID: 12
	public partial class FrmCadastro : global::System.Windows.Forms.Form
	{
		// Token: 0x06000137 RID: 311 RVA: 0x00021FEC File Offset: 0x000201EC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00022024 File Offset: 0x00020224
		private void InitializeComponent()
		{
			global::System.Windows.Forms.ListViewItem listViewItem = new global::System.Windows.Forms.ListViewItem("");
			global::System.Windows.Forms.ListViewItem listViewItem2 = new global::System.Windows.Forms.ListViewItem("");
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SupervisorioDana.FrmCadastro));
			this.label1 = new global::System.Windows.Forms.Label();
			this.BtnInicio = new global::System.Windows.Forms.Button();
			this.ListaDadosCadastro = new global::System.Windows.Forms.ListView();
			this.ColId = new global::System.Windows.Forms.ColumnHeader();
			this.ColDescrição = new global::System.Windows.Forms.ColumnHeader();
			this.ColCodigo = new global::System.Windows.Forms.ColumnHeader();
			this.ColReceita = new global::System.Windows.Forms.ColumnHeader();
			this.BtnsalvarP = new global::System.Windows.Forms.Button();
			this.TBoxReceitaProdutos = new global::System.Windows.Forms.TextBox();
			this.TBoxCodigoProdutos = new global::System.Windows.Forms.TextBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.TBoxDescricaoProdutos = new global::System.Windows.Forms.TextBox();
			this.TBoxIDProdutos = new global::System.Windows.Forms.TextBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label13 = new global::System.Windows.Forms.Label();
			this.label12 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.BtnSalvarR = new global::System.Windows.Forms.Button();
			this.BtncancelarR = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.LabCBufferTMin = new global::System.Windows.Forms.Label();
			this.LabCBufferTMax = new global::System.Windows.Forms.Label();
			this.LabCBufferDescricao = new global::System.Windows.Forms.Label();
			this.LabCBufferIDR = new global::System.Windows.Forms.Label();
			this.label20 = new global::System.Windows.Forms.Label();
			this.LabCBufferReceita = new global::System.Windows.Forms.Label();
			this.LabCBufferCodigo = new global::System.Windows.Forms.Label();
			this.LabCBufferProduto = new global::System.Windows.Forms.Label();
			this.LabCBufferID = new global::System.Windows.Forms.Label();
			this.label16 = new global::System.Windows.Forms.Label();
			this.ListaDadosReceita = new global::System.Windows.Forms.ListView();
			this.columnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new global::System.Windows.Forms.ColumnHeader();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.textBox5 = new global::System.Windows.Forms.TextBox();
			this.textBox7 = new global::System.Windows.Forms.TextBox();
			this.textBox8 = new global::System.Windows.Forms.TextBox();
			this.textBox6 = new global::System.Windows.Forms.TextBox();
			this.BtncancelarP = new global::System.Windows.Forms.Button();
			this.TBoxTMaxReceita = new global::System.Windows.Forms.TextBox();
			this.TBoxTMinReceita = new global::System.Windows.Forms.TextBox();
			this.TBoxDescricaoReceita = new global::System.Windows.Forms.TextBox();
			this.TBoxIDReceita = new global::System.Windows.Forms.TextBox();
			this.Campohisabaixo = new global::System.Windows.Forms.TextBox();
			this.Campohisacima = new global::System.Windows.Forms.TextBox();
			this.HistAcima = new global::System.Windows.Forms.Label();
			this.HistAbaixo = new global::System.Windows.Forms.Label();
			this.BtnsalvarH = new global::System.Windows.Forms.Button();
			this.BtncancelarH = new global::System.Windows.Forms.Button();
			this.label14 = new global::System.Windows.Forms.Label();
			this.label15 = new global::System.Windows.Forms.Label();
			this.label17 = new global::System.Windows.Forms.Label();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.button1 = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(20, 7);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(77, 17);
			this.label1.TabIndex = 10;
			this.label1.Text = "CADASTRO";
			this.BtnInicio.BackColor = global::System.Drawing.Color.FromArgb(68, 180, 74);
			this.BtnInicio.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.BtnInicio.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.BtnInicio.ForeColor = global::System.Drawing.Color.FromArgb(9, 37, 60);
			this.BtnInicio.Location = new global::System.Drawing.Point(8, 40);
			this.BtnInicio.Name = "BtnInicio";
			this.BtnInicio.Size = new global::System.Drawing.Size(100, 30);
			this.BtnInicio.TabIndex = 40;
			this.BtnInicio.Text = "Inicio";
			this.BtnInicio.UseVisualStyleBackColor = false;
			this.BtnInicio.Click += new global::System.EventHandler(this.button6_Click);
			this.ListaDadosCadastro.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.ListaDadosCadastro.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.ListaDadosCadastro.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[] { this.ColId, this.ColDescrição, this.ColCodigo, this.ColReceita });
			this.ListaDadosCadastro.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point);
			this.ListaDadosCadastro.ForeColor = global::System.Drawing.Color.White;
			this.ListaDadosCadastro.FullRowSelect = true;
			this.ListaDadosCadastro.HideSelection = false;
			this.ListaDadosCadastro.Items.AddRange(new global::System.Windows.Forms.ListViewItem[] { listViewItem });
			this.ListaDadosCadastro.Location = new global::System.Drawing.Point(129, 47);
			this.ListaDadosCadastro.Name = "ListaDadosCadastro";
			this.ListaDadosCadastro.Size = new global::System.Drawing.Size(435, 477);
			this.ListaDadosCadastro.TabIndex = 44;
			this.ListaDadosCadastro.UseCompatibleStateImageBehavior = false;
			this.ListaDadosCadastro.View = global::System.Windows.Forms.View.Details;
			this.ListaDadosCadastro.SelectedIndexChanged += new global::System.EventHandler(this.ListaDadosCadastro_SelectedIndexChanged);
			this.ColId.Text = "ID";
			this.ColId.Width = 30;
			this.ColDescrição.Text = "Produto";
			this.ColDescrição.Width = 180;
			this.ColCodigo.Text = "Codigo";
			this.ColCodigo.Width = 150;
			this.ColReceita.Text = "Receita";
			this.ColReceita.Width = 50;
			this.BtnsalvarP.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.BtnsalvarP.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.BtnsalvarP.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.BtnsalvarP.ForeColor = global::System.Drawing.Color.FromArgb(9, 37, 60);
			this.BtnsalvarP.Location = new global::System.Drawing.Point(463, 563);
			this.BtnsalvarP.Name = "BtnsalvarP";
			this.BtnsalvarP.Size = new global::System.Drawing.Size(90, 50);
			this.BtnsalvarP.TabIndex = 45;
			this.BtnsalvarP.Text = "Salvar";
			this.BtnsalvarP.UseVisualStyleBackColor = false;
			this.BtnsalvarP.Click += new global::System.EventHandler(this.button1_Click);
			this.TBoxReceitaProdutos.Location = new global::System.Drawing.Point(277, 658);
			this.TBoxReceitaProdutos.Name = "TBoxReceitaProdutos";
			this.TBoxReceitaProdutos.Size = new global::System.Drawing.Size(180, 23);
			this.TBoxReceitaProdutos.TabIndex = 54;
			this.TBoxCodigoProdutos.Location = new global::System.Drawing.Point(277, 626);
			this.TBoxCodigoProdutos.Name = "TBoxCodigoProdutos";
			this.TBoxCodigoProdutos.Size = new global::System.Drawing.Size(180, 23);
			this.TBoxCodigoProdutos.TabIndex = 53;
			this.label6.AutoSize = true;
			this.label6.BackColor = global::System.Drawing.Color.Transparent;
			this.label6.ForeColor = global::System.Drawing.Color.White;
			this.label6.Location = new global::System.Drawing.Point(201, 571);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(74, 15);
			this.label6.TabIndex = 47;
			this.label6.Text = "Identificador";
			this.TBoxDescricaoProdutos.Location = new global::System.Drawing.Point(277, 596);
			this.TBoxDescricaoProdutos.Name = "TBoxDescricaoProdutos";
			this.TBoxDescricaoProdutos.Size = new global::System.Drawing.Size(180, 23);
			this.TBoxDescricaoProdutos.TabIndex = 52;
			this.TBoxIDProdutos.Location = new global::System.Drawing.Point(277, 566);
			this.TBoxIDProdutos.Name = "TBoxIDProdutos";
			this.TBoxIDProdutos.ReadOnly = true;
			this.TBoxIDProdutos.Size = new global::System.Drawing.Size(180, 23);
			this.TBoxIDProdutos.TabIndex = 51;
			this.label7.AutoSize = true;
			this.label7.BackColor = global::System.Drawing.Color.Transparent;
			this.label7.ForeColor = global::System.Drawing.Color.White;
			this.label7.Location = new global::System.Drawing.Point(208, 601);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(58, 15);
			this.label7.TabIndex = 48;
			this.label7.Text = "Descrição";
			this.label9.AutoSize = true;
			this.label9.BackColor = global::System.Drawing.Color.Transparent;
			this.label9.ForeColor = global::System.Drawing.Color.White;
			this.label9.Location = new global::System.Drawing.Point(212, 661);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(45, 15);
			this.label9.TabIndex = 50;
			this.label9.Text = "Receita";
			this.label8.AutoSize = true;
			this.label8.BackColor = global::System.Drawing.Color.Transparent;
			this.label8.ForeColor = global::System.Drawing.Color.White;
			this.label8.Location = new global::System.Drawing.Point(211, 629);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(46, 15);
			this.label8.TabIndex = 49;
			this.label8.Text = "Codigo";
			this.label13.AutoSize = true;
			this.label13.Location = new global::System.Drawing.Point(472, 319);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(74, 15);
			this.label13.TabIndex = 57;
			this.label13.Text = "Identificador";
			this.label12.AutoSize = true;
			this.label12.Location = new global::System.Drawing.Point(479, 351);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(58, 15);
			this.label12.TabIndex = 58;
			this.label12.Text = "Descrição";
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(486, 412);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(39, 15);
			this.label10.TabIndex = 60;
			this.label10.Text = "T.Max";
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(485, 381);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(41, 15);
			this.label11.TabIndex = 59;
			this.label11.Text = "T.Mim";
			this.BtnSalvarR.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.BtnSalvarR.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.BtnSalvarR.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.BtnSalvarR.ForeColor = global::System.Drawing.Color.FromArgb(9, 37, 60);
			this.BtnSalvarR.Location = new global::System.Drawing.Point(1138, 567);
			this.BtnSalvarR.Name = "BtnSalvarR";
			this.BtnSalvarR.Size = new global::System.Drawing.Size(99, 53);
			this.BtnSalvarR.TabIndex = 55;
			this.BtnSalvarR.Text = "Salvar";
			this.BtnSalvarR.UseVisualStyleBackColor = false;
			this.BtnSalvarR.Click += new global::System.EventHandler(this.button4_Click);
			this.BtncancelarR.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.BtncancelarR.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.BtncancelarR.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.BtncancelarR.ForeColor = global::System.Drawing.Color.FromArgb(9, 37, 60);
			this.BtncancelarR.Location = new global::System.Drawing.Point(1139, 626);
			this.BtncancelarR.Name = "BtncancelarR";
			this.BtncancelarR.Size = new global::System.Drawing.Size(99, 54);
			this.BtncancelarR.TabIndex = 56;
			this.BtncancelarR.Text = "Cancelar";
			this.BtncancelarR.UseVisualStyleBackColor = false;
			this.BtncancelarR.Click += new global::System.EventHandler(this.button8_Click);
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(873, 568);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(74, 15);
			this.label2.TabIndex = 57;
			this.label2.Text = "Identificador";
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(880, 600);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(58, 15);
			this.label3.TabIndex = 58;
			this.label3.Text = "Descrição";
			this.label4.AutoSize = true;
			this.label4.BackColor = global::System.Drawing.Color.Transparent;
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(887, 661);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(41, 15);
			this.label4.TabIndex = 60;
			this.label4.Text = "T.Ideal";
			this.label5.AutoSize = true;
			this.label5.BackColor = global::System.Drawing.Color.Transparent;
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Location = new global::System.Drawing.Point(887, 630);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(54, 15);
			this.label5.TabIndex = 59;
			this.label5.Text = "T.Alarme";
			this.LabCBufferTMin.AutoSize = true;
			this.LabCBufferTMin.BackColor = global::System.Drawing.Color.Transparent;
			this.LabCBufferTMin.ForeColor = global::System.Drawing.Color.White;
			this.LabCBufferTMin.Location = new global::System.Drawing.Point(630, 492);
			this.LabCBufferTMin.Name = "LabCBufferTMin";
			this.LabCBufferTMin.Size = new global::System.Drawing.Size(107, 15);
			this.LabCBufferTMin.TabIndex = 69;
			this.LabCBufferTMin.Text = "Temperatura Ideal: ";
			this.LabCBufferTMax.AutoSize = true;
			this.LabCBufferTMax.BackColor = global::System.Drawing.Color.Transparent;
			this.LabCBufferTMax.ForeColor = global::System.Drawing.Color.White;
			this.LabCBufferTMax.Location = new global::System.Drawing.Point(630, 445);
			this.LabCBufferTMax.Name = "LabCBufferTMax";
			this.LabCBufferTMax.Size = new global::System.Drawing.Size(136, 15);
			this.LabCBufferTMax.TabIndex = 68;
			this.LabCBufferTMax.Text = "Temperatura de Alarme: ";
			this.LabCBufferDescricao.AutoSize = true;
			this.LabCBufferDescricao.BackColor = global::System.Drawing.Color.Transparent;
			this.LabCBufferDescricao.ForeColor = global::System.Drawing.Color.White;
			this.LabCBufferDescricao.Location = new global::System.Drawing.Point(630, 395);
			this.LabCBufferDescricao.Name = "LabCBufferDescricao";
			this.LabCBufferDescricao.Size = new global::System.Drawing.Size(61, 15);
			this.LabCBufferDescricao.TabIndex = 67;
			this.LabCBufferDescricao.Text = "Descrição:";
			this.LabCBufferIDR.AutoSize = true;
			this.LabCBufferIDR.BackColor = global::System.Drawing.Color.Transparent;
			this.LabCBufferIDR.ForeColor = global::System.Drawing.Color.White;
			this.LabCBufferIDR.Location = new global::System.Drawing.Point(630, 351);
			this.LabCBufferIDR.Name = "LabCBufferIDR";
			this.LabCBufferIDR.Size = new global::System.Drawing.Size(21, 15);
			this.LabCBufferIDR.TabIndex = 66;
			this.LabCBufferIDR.Text = "ID:";
			this.label20.AutoSize = true;
			this.label20.BackColor = global::System.Drawing.Color.Transparent;
			this.label20.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.label20.ForeColor = global::System.Drawing.Color.White;
			this.label20.Location = new global::System.Drawing.Point(661, 311);
			this.label20.Name = "label20";
			this.label20.Size = new global::System.Drawing.Size(135, 21);
			this.label20.TabIndex = 65;
			this.label20.Text = "Receita Alterada";
			this.LabCBufferReceita.AutoSize = true;
			this.LabCBufferReceita.BackColor = global::System.Drawing.Color.Transparent;
			this.LabCBufferReceita.ForeColor = global::System.Drawing.Color.White;
			this.LabCBufferReceita.Location = new global::System.Drawing.Point(630, 236);
			this.LabCBufferReceita.Name = "LabCBufferReceita";
			this.LabCBufferReceita.Size = new global::System.Drawing.Size(48, 15);
			this.LabCBufferReceita.TabIndex = 74;
			this.LabCBufferReceita.Text = "Receita:";
			this.LabCBufferCodigo.AutoSize = true;
			this.LabCBufferCodigo.BackColor = global::System.Drawing.Color.Transparent;
			this.LabCBufferCodigo.ForeColor = global::System.Drawing.Color.White;
			this.LabCBufferCodigo.Location = new global::System.Drawing.Point(630, 188);
			this.LabCBufferCodigo.Name = "LabCBufferCodigo";
			this.LabCBufferCodigo.Size = new global::System.Drawing.Size(49, 15);
			this.LabCBufferCodigo.TabIndex = 73;
			this.LabCBufferCodigo.Text = "Codigo:";
			this.LabCBufferProduto.AutoSize = true;
			this.LabCBufferProduto.BackColor = global::System.Drawing.Color.Transparent;
			this.LabCBufferProduto.ForeColor = global::System.Drawing.Color.White;
			this.LabCBufferProduto.Location = new global::System.Drawing.Point(630, 143);
			this.LabCBufferProduto.Name = "LabCBufferProduto";
			this.LabCBufferProduto.Size = new global::System.Drawing.Size(56, 15);
			this.LabCBufferProduto.TabIndex = 72;
			this.LabCBufferProduto.Text = "Produto: ";
			this.LabCBufferID.AutoSize = true;
			this.LabCBufferID.BackColor = global::System.Drawing.Color.Transparent;
			this.LabCBufferID.ForeColor = global::System.Drawing.Color.White;
			this.LabCBufferID.Location = new global::System.Drawing.Point(630, 98);
			this.LabCBufferID.Name = "LabCBufferID";
			this.LabCBufferID.Size = new global::System.Drawing.Size(24, 15);
			this.LabCBufferID.TabIndex = 71;
			this.LabCBufferID.Text = "ID: ";
			this.label16.AutoSize = true;
			this.label16.BackColor = global::System.Drawing.Color.Transparent;
			this.label16.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.label16.ForeColor = global::System.Drawing.Color.White;
			this.label16.Location = new global::System.Drawing.Point(654, 52);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(142, 21);
			this.label16.TabIndex = 70;
			this.label16.Text = "Produto Alterado";
			this.ListaDadosReceita.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.ListaDadosReceita.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.ListaDadosReceita.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[] { this.columnHeader1, this.columnHeader2, this.columnHeader3, this.columnHeader4 });
			this.ListaDadosReceita.ForeColor = global::System.Drawing.Color.White;
			this.ListaDadosReceita.FullRowSelect = true;
			this.ListaDadosReceita.HideSelection = false;
			this.ListaDadosReceita.Items.AddRange(new global::System.Windows.Forms.ListViewItem[] { listViewItem2 });
			this.ListaDadosReceita.Location = new global::System.Drawing.Point(862, 46);
			this.ListaDadosReceita.Name = "ListaDadosReceita";
			this.ListaDadosReceita.Size = new global::System.Drawing.Size(395, 478);
			this.ListaDadosReceita.TabIndex = 75;
			this.ListaDadosReceita.UseCompatibleStateImageBehavior = false;
			this.ListaDadosReceita.View = global::System.Windows.Forms.View.Details;
			this.ListaDadosReceita.SelectedIndexChanged += new global::System.EventHandler(this.ListaDadosReceita_SelectedIndexChanged);
			this.columnHeader1.Text = "ID";
			this.columnHeader1.Width = 30;
			this.columnHeader2.Text = "Descrição";
			this.columnHeader2.Width = 255;
			this.columnHeader3.Text = "T alarme";
			this.columnHeader4.Text = "T ideal";
			this.columnHeader4.Width = 50;
			this.pictureBox1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = (global::System.Drawing.Image)resources.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(1250, 0);
			this.pictureBox1.Margin = new global::System.Windows.Forms.Padding(0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(28, 29);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 76;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.textBox5.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.textBox5.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBox5.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.textBox5.Enabled = false;
			this.textBox5.Location = new global::System.Drawing.Point(0, 0);
			this.textBox5.MaximumSize = new global::System.Drawing.Size(0, 30);
			this.textBox5.MinimumSize = new global::System.Drawing.Size(0, 30);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new global::System.Drawing.Size(1280, 30);
			this.textBox5.TabIndex = 77;
			this.textBox7.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.textBox7.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBox7.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.textBox7.Enabled = false;
			this.textBox7.Location = new global::System.Drawing.Point(1277, 30);
			this.textBox7.MaximumSize = new global::System.Drawing.Size(3, 1000);
			this.textBox7.MinimumSize = new global::System.Drawing.Size(3, 1000);
			this.textBox7.Name = "textBox7";
			this.textBox7.ReadOnly = true;
			this.textBox7.Size = new global::System.Drawing.Size(3, 16);
			this.textBox7.TabIndex = 79;
			this.textBox8.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.textBox8.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBox8.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.textBox8.Enabled = false;
			this.textBox8.Location = new global::System.Drawing.Point(0, 717);
			this.textBox8.MaximumSize = new global::System.Drawing.Size(0, 3);
			this.textBox8.MinimumSize = new global::System.Drawing.Size(0, 3);
			this.textBox8.Name = "textBox8";
			this.textBox8.ReadOnly = true;
			this.textBox8.Size = new global::System.Drawing.Size(1277, 3);
			this.textBox8.TabIndex = 80;
			this.textBox6.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.textBox6.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.textBox6.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBox6.Enabled = false;
			this.textBox6.Location = new global::System.Drawing.Point(0, 6);
			this.textBox6.Margin = new global::System.Windows.Forms.Padding(4, 3, 3, 3);
			this.textBox6.MaximumSize = new global::System.Drawing.Size(4, 1000);
			this.textBox6.MinimumSize = new global::System.Drawing.Size(4, 1000);
			this.textBox6.Multiline = true;
			this.textBox6.Name = "textBox6";
			this.textBox6.ReadOnly = true;
			this.textBox6.Size = new global::System.Drawing.Size(4, 1000);
			this.textBox6.TabIndex = 81;
			this.BtncancelarP.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.BtncancelarP.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.BtncancelarP.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.BtncancelarP.ForeColor = global::System.Drawing.Color.FromArgb(9, 37, 60);
			this.BtncancelarP.Location = new global::System.Drawing.Point(463, 625);
			this.BtncancelarP.Name = "BtncancelarP";
			this.BtncancelarP.Size = new global::System.Drawing.Size(90, 54);
			this.BtncancelarP.TabIndex = 82;
			this.BtncancelarP.Text = "Cancelar";
			this.BtncancelarP.UseVisualStyleBackColor = false;
			this.BtncancelarP.Click += new global::System.EventHandler(this.button5_Click);
			this.TBoxTMaxReceita.Location = new global::System.Drawing.Point(952, 658);
			this.TBoxTMaxReceita.Name = "TBoxTMaxReceita";
			this.TBoxTMaxReceita.Size = new global::System.Drawing.Size(180, 23);
			this.TBoxTMaxReceita.TabIndex = 86;
			this.TBoxTMinReceita.Location = new global::System.Drawing.Point(952, 626);
			this.TBoxTMinReceita.Name = "TBoxTMinReceita";
			this.TBoxTMinReceita.Size = new global::System.Drawing.Size(180, 23);
			this.TBoxTMinReceita.TabIndex = 85;
			this.TBoxDescricaoReceita.Location = new global::System.Drawing.Point(952, 596);
			this.TBoxDescricaoReceita.Name = "TBoxDescricaoReceita";
			this.TBoxDescricaoReceita.Size = new global::System.Drawing.Size(180, 23);
			this.TBoxDescricaoReceita.TabIndex = 84;
			this.TBoxIDReceita.Location = new global::System.Drawing.Point(952, 566);
			this.TBoxIDReceita.Name = "TBoxIDReceita";
			this.TBoxIDReceita.ReadOnly = true;
			this.TBoxIDReceita.Size = new global::System.Drawing.Size(180, 23);
			this.TBoxIDReceita.TabIndex = 83;
			this.Campohisabaixo.Location = new global::System.Drawing.Point(575, 660);
			this.Campohisabaixo.Name = "Campohisabaixo";
			this.Campohisabaixo.Size = new global::System.Drawing.Size(170, 23);
			this.Campohisabaixo.TabIndex = 90;
			this.Campohisacima.Location = new global::System.Drawing.Point(572, 598);
			this.Campohisacima.Name = "Campohisacima";
			this.Campohisacima.Size = new global::System.Drawing.Size(173, 23);
			this.Campohisacima.TabIndex = 89;
			this.HistAcima.AutoSize = true;
			this.HistAcima.BackColor = global::System.Drawing.Color.Transparent;
			this.HistAcima.ForeColor = global::System.Drawing.Color.White;
			this.HistAcima.Location = new global::System.Drawing.Point(575, 571);
			this.HistAcima.Name = "HistAcima";
			this.HistAcima.Size = new global::System.Drawing.Size(96, 15);
			this.HistAcima.TabIndex = 87;
			this.HistAcima.Text = "Histerese acima: ";
			this.HistAbaixo.AutoSize = true;
			this.HistAbaixo.BackColor = global::System.Drawing.Color.Transparent;
			this.HistAbaixo.ForeColor = global::System.Drawing.Color.White;
			this.HistAbaixo.Location = new global::System.Drawing.Point(572, 634);
			this.HistAbaixo.Name = "HistAbaixo";
			this.HistAbaixo.Size = new global::System.Drawing.Size(99, 15);
			this.HistAbaixo.TabIndex = 88;
			this.HistAbaixo.Text = "Histerese abaixo: ";
			this.BtnsalvarH.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.BtnsalvarH.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.BtnsalvarH.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.BtnsalvarH.ForeColor = global::System.Drawing.Color.FromArgb(9, 37, 60);
			this.BtnsalvarH.Location = new global::System.Drawing.Point(763, 567);
			this.BtnsalvarH.Name = "BtnsalvarH";
			this.BtnsalvarH.Size = new global::System.Drawing.Size(90, 50);
			this.BtnsalvarH.TabIndex = 91;
			this.BtnsalvarH.Text = "Salvar";
			this.BtnsalvarH.UseVisualStyleBackColor = false;
			this.BtnsalvarH.Click += new global::System.EventHandler(this.button9_Click);
			this.BtncancelarH.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.BtncancelarH.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.BtncancelarH.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.BtncancelarH.ForeColor = global::System.Drawing.Color.FromArgb(9, 37, 60);
			this.BtncancelarH.Location = new global::System.Drawing.Point(763, 630);
			this.BtncancelarH.Name = "BtncancelarH";
			this.BtncancelarH.Size = new global::System.Drawing.Size(90, 54);
			this.BtncancelarH.TabIndex = 92;
			this.BtncancelarH.Text = "Cancelar";
			this.BtncancelarH.UseVisualStyleBackColor = false;
			this.BtncancelarH.Click += new global::System.EventHandler(this.button10_Click);
			this.label14.AutoSize = true;
			this.label14.BackColor = global::System.Drawing.Color.Transparent;
			this.label14.ForeColor = global::System.Drawing.Color.White;
			this.label14.Location = new global::System.Drawing.Point(591, 538);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(138, 15);
			this.label14.TabIndex = 93;
			this.label14.Text = "Controle de Temperatura";
			this.label15.AutoSize = true;
			this.label15.BackColor = global::System.Drawing.Color.Transparent;
			this.label15.ForeColor = global::System.Drawing.Color.White;
			this.label15.Location = new global::System.Drawing.Point(230, 538);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(121, 15);
			this.label15.TabIndex = 94;
			this.label15.Text = "Cadastro de produtos";
			this.label17.AutoSize = true;
			this.label17.BackColor = global::System.Drawing.Color.Transparent;
			this.label17.ForeColor = global::System.Drawing.Color.White;
			this.label17.Location = new global::System.Drawing.Point(898, 540);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(116, 15);
			this.label17.TabIndex = 95;
			this.label17.Text = "Cadastro de Receitas";
			this.pictureBox2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.pictureBox2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBox2.Image = (global::System.Drawing.Image)resources.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new global::System.Drawing.Point(1221, 0);
			this.pictureBox2.Margin = new global::System.Windows.Forms.Padding(0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(28, 29);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 96;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new global::System.EventHandler(this.pictureBox2_Click);
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(68, 180, 74);
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.button1.ForeColor = global::System.Drawing.Color.FromArgb(9, 37, 60);
			this.button1.Location = new global::System.Drawing.Point(7, 500);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(100, 30);
			this.button1.TabIndex = 104;
			this.button1.Text = "Recarregar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click_1);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackgroundImage = global::SupervisorioDana.Properties.Resources.CADASTRO;
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			base.ClientSize = new global::System.Drawing.Size(1280, 720);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.label17);
			base.Controls.Add(this.label15);
			base.Controls.Add(this.label14);
			base.Controls.Add(this.BtncancelarH);
			base.Controls.Add(this.BtnsalvarH);
			base.Controls.Add(this.Campohisabaixo);
			base.Controls.Add(this.Campohisacima);
			base.Controls.Add(this.HistAcima);
			base.Controls.Add(this.HistAbaixo);
			base.Controls.Add(this.TBoxTMaxReceita);
			base.Controls.Add(this.TBoxTMinReceita);
			base.Controls.Add(this.TBoxDescricaoReceita);
			base.Controls.Add(this.TBoxIDReceita);
			base.Controls.Add(this.BtncancelarP);
			base.Controls.Add(this.textBox6);
			base.Controls.Add(this.textBox8);
			base.Controls.Add(this.textBox7);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.ListaDadosReceita);
			base.Controls.Add(this.LabCBufferReceita);
			base.Controls.Add(this.LabCBufferCodigo);
			base.Controls.Add(this.LabCBufferProduto);
			base.Controls.Add(this.LabCBufferID);
			base.Controls.Add(this.label16);
			base.Controls.Add(this.LabCBufferTMin);
			base.Controls.Add(this.LabCBufferTMax);
			base.Controls.Add(this.LabCBufferDescricao);
			base.Controls.Add(this.LabCBufferIDR);
			base.Controls.Add(this.label20);
			base.Controls.Add(this.BtnSalvarR);
			base.Controls.Add(this.BtncancelarR);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.BtnsalvarP);
			base.Controls.Add(this.TBoxReceitaProdutos);
			base.Controls.Add(this.TBoxCodigoProdutos);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.TBoxDescricaoProdutos);
			base.Controls.Add(this.TBoxIDProdutos);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.ListaDadosCadastro);
			base.Controls.Add(this.BtnInicio);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textBox5);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "FrmCadastro";
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Show;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " Cadastro de Produtos e Receitas";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.FrmCadastro_FormClosing);
			base.Load += new global::System.EventHandler(this.Form1_Load);
			base.Shown += new global::System.EventHandler(this.FrmCadastro_Shown);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040001E8 RID: 488
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040001E9 RID: 489
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040001EA RID: 490
		private global::System.Windows.Forms.Button BtnInicio;

		// Token: 0x040001EB RID: 491
		private global::System.Windows.Forms.ListView ListaDadosCadastro;

		// Token: 0x040001EC RID: 492
		private global::System.Windows.Forms.ColumnHeader ColId;

		// Token: 0x040001ED RID: 493
		private global::System.Windows.Forms.ColumnHeader ColDescrição;

		// Token: 0x040001EE RID: 494
		private global::System.Windows.Forms.ColumnHeader ColCodigo;

		// Token: 0x040001EF RID: 495
		private global::System.Windows.Forms.ColumnHeader ColReceita;

		// Token: 0x040001F0 RID: 496
		private global::System.Windows.Forms.Button BtnsalvarP;

		// Token: 0x040001F1 RID: 497
		private global::System.Windows.Forms.TextBox TBoxReceitaProdutos;

		// Token: 0x040001F2 RID: 498
		private global::System.Windows.Forms.TextBox TBoxCodigoProdutos;

		// Token: 0x040001F3 RID: 499
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040001F4 RID: 500
		private global::System.Windows.Forms.TextBox TBoxDescricaoProdutos;

		// Token: 0x040001F5 RID: 501
		private global::System.Windows.Forms.TextBox TBoxIDProdutos;

		// Token: 0x040001F6 RID: 502
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040001F7 RID: 503
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040001F8 RID: 504
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040001F9 RID: 505
		private global::System.Windows.Forms.Label label13;

		// Token: 0x040001FA RID: 506
		private global::System.Windows.Forms.Label label12;

		// Token: 0x040001FB RID: 507
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040001FC RID: 508
		private global::System.Windows.Forms.Label label11;

		// Token: 0x040001FD RID: 509
		private global::System.Windows.Forms.Button BtnSalvarR;

		// Token: 0x040001FE RID: 510
		private global::System.Windows.Forms.Button BtncancelarR;

		// Token: 0x040001FF RID: 511
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000200 RID: 512
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000201 RID: 513
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000202 RID: 514
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000203 RID: 515
		private global::System.Windows.Forms.Label LabCBufferTMin;

		// Token: 0x04000204 RID: 516
		private global::System.Windows.Forms.Label LabCBufferTMax;

		// Token: 0x04000205 RID: 517
		private global::System.Windows.Forms.Label LabCBufferDescricao;

		// Token: 0x04000206 RID: 518
		private global::System.Windows.Forms.Label LabCBufferIDR;

		// Token: 0x04000207 RID: 519
		private global::System.Windows.Forms.Label label20;

		// Token: 0x04000208 RID: 520
		private global::System.Windows.Forms.Label LabCBufferReceita;

		// Token: 0x04000209 RID: 521
		private global::System.Windows.Forms.Label LabCBufferCodigo;

		// Token: 0x0400020A RID: 522
		private global::System.Windows.Forms.Label LabCBufferProduto;

		// Token: 0x0400020B RID: 523
		private global::System.Windows.Forms.Label LabCBufferID;

		// Token: 0x0400020C RID: 524
		private global::System.Windows.Forms.Label label16;

		// Token: 0x0400020D RID: 525
		private global::System.Windows.Forms.ListView ListaDadosReceita;

		// Token: 0x0400020E RID: 526
		private global::System.Windows.Forms.ColumnHeader columnHeader1;

		// Token: 0x0400020F RID: 527
		private global::System.Windows.Forms.ColumnHeader columnHeader2;

		// Token: 0x04000210 RID: 528
		private global::System.Windows.Forms.ColumnHeader columnHeader3;

		// Token: 0x04000211 RID: 529
		private global::System.Windows.Forms.ColumnHeader columnHeader4;

		// Token: 0x04000212 RID: 530
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000213 RID: 531
		private global::System.Windows.Forms.TextBox textBox5;

		// Token: 0x04000214 RID: 532
		private global::System.Windows.Forms.TextBox textBox7;

		// Token: 0x04000215 RID: 533
		private global::System.Windows.Forms.TextBox textBox8;

		// Token: 0x04000216 RID: 534
		private global::System.Windows.Forms.TextBox textBox6;

		// Token: 0x04000217 RID: 535
		private global::System.Windows.Forms.Button BtncancelarP;

		// Token: 0x04000218 RID: 536
		private global::System.Windows.Forms.TextBox TBoxTMaxReceita;

		// Token: 0x04000219 RID: 537
		private global::System.Windows.Forms.TextBox TBoxTMinReceita;

		// Token: 0x0400021A RID: 538
		private global::System.Windows.Forms.TextBox TBoxDescricaoReceita;

		// Token: 0x0400021B RID: 539
		private global::System.Windows.Forms.TextBox TBoxIDReceita;

		// Token: 0x0400021C RID: 540
		private global::System.Windows.Forms.TextBox Campohisabaixo;

		// Token: 0x0400021D RID: 541
		private global::System.Windows.Forms.TextBox Campohisacima;

		// Token: 0x0400021E RID: 542
		private global::System.Windows.Forms.Label HistAcima;

		// Token: 0x0400021F RID: 543
		private global::System.Windows.Forms.Label HistAbaixo;

		// Token: 0x04000220 RID: 544
		private global::System.Windows.Forms.Button BtnsalvarH;

		// Token: 0x04000221 RID: 545
		private global::System.Windows.Forms.Button BtncancelarH;

		// Token: 0x04000222 RID: 546
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000223 RID: 547
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04000224 RID: 548
		private global::System.Windows.Forms.Label label17;

		// Token: 0x04000225 RID: 549
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000226 RID: 550
		private global::System.Windows.Forms.Button button1;
	}
}
