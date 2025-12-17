namespace SupervisorioDana
{
	// Token: 0x0200000E RID: 14
	public partial class FrmDadosDosCarros : global::System.Windows.Forms.Form
	{
		// Token: 0x06000188 RID: 392 RVA: 0x00028A74 File Offset: 0x00026C74
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00028AAC File Offset: 0x00026CAC
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDadosDosCarros));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAlarme = new System.Windows.Forms.Button();
            this.BtnCadastro = new System.Windows.Forms.Button();
            this.BtnConfiguracoes = new System.Windows.Forms.Button();
            this.btnEditarConfig = new System.Windows.Forms.Button();
            this.btnVerNotas = new System.Windows.Forms.Button();
            this.ListaDadosCarros = new System.Windows.Forms.ListView();
            this.ColId = new System.Windows.Forms.ColumnHeader();
            this.ColPosicao = new System.Windows.Forms.ColumnHeader();
            this.Setor = new System.Windows.Forms.ColumnHeader();
            this.ColProduto = new System.Windows.Forms.ColumnHeader();
            this.ColReceita = new System.Windows.Forms.ColumnHeader();
            this.ColCodigo = new System.Windows.Forms.ColumnHeader();
            this.ColQuantidade = new System.Windows.Forms.ColumnHeader();
            this.TBoxCodigoPecas = new System.Windows.Forms.TextBox();
            this.TBoxCodigoBarras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LabAviso = new System.Windows.Forms.Label();
            this.LabBufferSetor = new System.Windows.Forms.Label();
            this.LabBufferQuantidade = new System.Windows.Forms.Label();
            this.LabBufferCodigo = new System.Windows.Forms.Label();
            this.LabBufferReceita = new System.Windows.Forms.Label();
            this.LabBufferProduto = new System.Windows.Forms.Label();
            this.LabBufferPosicao = new System.Windows.Forms.Label();
            this.LabBufferID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LabCBufferSetor = new System.Windows.Forms.Label();
            this.LabCBufferQuantidade = new System.Windows.Forms.Label();
            this.LabCBufferCodigo = new System.Windows.Forms.Label();
            this.LabCBufferReceita = new System.Windows.Forms.Label();
            this.LabCBufferProduto = new System.Windows.Forms.Label();
            this.LabCBufferPosicao = new System.Windows.Forms.Label();
            this.LabCBufferID = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.BtnAtualizarCarro = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TBoxAtualizaCarro = new System.Windows.Forms.TextBox();
            this.LabelUltCarro = new System.Windows.Forms.Label();
            this.ListaAlarmesAtivos = new System.Windows.Forms.ListView();
            this.IDativo = new System.Windows.Forms.ColumnHeader();
            this.Descricaoativo = new System.Windows.Forms.ColumnHeader();
            this.HAtivo = new System.Windows.Forms.ColumnHeader();
            this.TxtModo = new System.Windows.Forms.Label();
            this.BtnAutoLigado = new System.Windows.Forms.Button();
            this.BtnAutoDesligado = new System.Windows.Forms.Button();
            this.Comunicacao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TBoxDescricaoReceita = new System.Windows.Forms.TextBox();
            this.TBoxIDReceita = new System.Windows.Forms.TextBox();
            this.Visual = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnConfirmarManutencao = new System.Windows.Forms.Button();
            this.LblStatusManutencao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "INICIO";
            // 
            // BtnAlarme
            // 
            this.BtnAlarme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            this.BtnAlarme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlarme.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAlarme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.BtnAlarme.Location = new System.Drawing.Point(7, 40);
            this.BtnAlarme.Name = "BtnAlarme";
            this.BtnAlarme.Size = new System.Drawing.Size(100, 30);
            this.BtnAlarme.TabIndex = 1;
            this.BtnAlarme.Text = "Alarme";
            this.BtnAlarme.UseVisualStyleBackColor = true;
            this.BtnAlarme.Click += new System.EventHandler(this.BtnAlarme_Click);
            // 
            // BtnCadastro
            // 
            this.BtnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            this.BtnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.BtnCadastro.Location = new System.Drawing.Point(7, 80);
            this.BtnCadastro.Name = "BtnCadastro";
            this.BtnCadastro.Size = new System.Drawing.Size(100, 30);
            this.BtnCadastro.TabIndex = 2;
            this.BtnCadastro.Text = "Cadastro";
            this.BtnCadastro.UseVisualStyleBackColor = false;
            this.BtnCadastro.Click += new System.EventHandler(this.BtnCadastro_Click);
            // 
            // BtnConfiguracoes
            // 
            this.BtnConfiguracoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.BtnConfiguracoes.Enabled = false;
            this.BtnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfiguracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnConfiguracoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.BtnConfiguracoes.Location = new System.Drawing.Point(8, 160);
            this.BtnConfiguracoes.Name = "BtnConfiguracoes";
            this.BtnConfiguracoes.Size = new System.Drawing.Size(100, 30);
            this.BtnConfiguracoes.TabIndex = 3;
            this.BtnConfiguracoes.Text = "Configurações";
            this.BtnConfiguracoes.UseVisualStyleBackColor = false;
            this.BtnConfiguracoes.Click += new System.EventHandler(this.BtnConfiguracoes_Click);
            // 
            // btnEditarConfig
            // 
            this.btnEditarConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            this.btnEditarConfig.Enabled = false;
            this.btnEditarConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarConfig.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditarConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.btnEditarConfig.Location = new System.Drawing.Point(7, 463);
            this.btnEditarConfig.Name = "btnEditarConfig";
            this.btnEditarConfig.Size = new System.Drawing.Size(100, 30);
            this.btnEditarConfig.TabIndex = 106;
            this.btnEditarConfig.Text = "Editar Horários";
            this.btnEditarConfig.UseVisualStyleBackColor = false;
            this.btnEditarConfig.Click += new System.EventHandler(this.btnEditarConfig_Click);
            // 
            // btnVerNotas
            // 
            this.btnVerNotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.btnVerNotas.Enabled = false;
            this.btnVerNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerNotas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerNotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.btnVerNotas.Location = new System.Drawing.Point(7, 500);
            this.btnVerNotas.Name = "btnVerNotas";
            this.btnVerNotas.Size = new System.Drawing.Size(100, 30);
            this.btnVerNotas.TabIndex = 107;
            this.btnVerNotas.Text = "Ver Notas Manut.";
            this.btnVerNotas.UseVisualStyleBackColor = false;
            this.btnVerNotas.Click += new System.EventHandler(this.btnVerNotas_Click);
            // 
            // ListaDadosCarros
            // 
            this.ListaDadosCarros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.ListaDadosCarros.BackgroundImageTiled = true;
            this.ListaDadosCarros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaDadosCarros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColId,
            this.ColPosicao,
            this.Setor,
            this.ColProduto,
            this.ColReceita,
            this.ColCodigo,
            this.ColQuantidade});
            this.ListaDadosCarros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListaDadosCarros.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListaDadosCarros.ForeColor = System.Drawing.Color.White;
            this.ListaDadosCarros.FullRowSelect = true;
            this.ListaDadosCarros.HideSelection = false;
            this.ListaDadosCarros.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ListaDadosCarros.Location = new System.Drawing.Point(128, 38);
            this.ListaDadosCarros.Name = "ListaDadosCarros";
            this.ListaDadosCarros.Scrollable = false;
            this.ListaDadosCarros.Size = new System.Drawing.Size(570, 590);
            this.ListaDadosCarros.TabIndex = 0;
            this.ListaDadosCarros.UseCompatibleStateImageBehavior = false;
            this.ListaDadosCarros.View = System.Windows.Forms.View.Details;
            this.ListaDadosCarros.SelectedIndexChanged += new System.EventHandler(this.ListaDadosCarros_SelectedIndexChanged);
            this.ListaDadosCarros.MouseEnter += new System.EventHandler(this.ListaDadosCarros_MouseEnter);
            this.ListaDadosCarros.MouseLeave += new System.EventHandler(this.ListaDadosCarros_MouseLeave);
            // 
            // ColId
            // 
            this.ColId.Text = "ID";
            this.ColId.Width = 30;
            // 
            // ColPosicao
            // 
            this.ColPosicao.Text = "Posição";
            this.ColPosicao.Width = 30;
            // 
            // Setor
            // 
            this.Setor.Text = "Setor";
            this.Setor.Width = 80;
            // 
            // ColProduto
            // 
            this.ColProduto.Text = "Produto";
            this.ColProduto.Width = 150;
            // 
            // ColReceita
            // 
            this.ColReceita.Text = "Receita";
            this.ColReceita.Width = 130;
            // 
            // ColCodigo
            // 
            this.ColCodigo.Text = "Código";
            this.ColCodigo.Width = 95;
            // 
            // ColQuantidade
            // 
            this.ColQuantidade.Text = "Quantidade";
            this.ColQuantidade.Width = 30;
            // 
            // TBoxCodigoPecas
            // 
            this.TBoxCodigoPecas.AcceptsTab = true;
            this.TBoxCodigoPecas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TBoxCodigoPecas.Location = new System.Drawing.Point(719, 348);
            this.TBoxCodigoPecas.Name = "TBoxCodigoPecas";
            this.TBoxCodigoPecas.Size = new System.Drawing.Size(230, 22);
            this.TBoxCodigoPecas.TabIndex = 101;
            // 
            // TBoxCodigoBarras
            // 
            this.TBoxCodigoBarras.AcceptsTab = true;
            this.TBoxCodigoBarras.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TBoxCodigoBarras.Location = new System.Drawing.Point(719, 300);
            this.TBoxCodigoBarras.Name = "TBoxCodigoBarras";
            this.TBoxCodigoBarras.Size = new System.Drawing.Size(230, 22);
            this.TBoxCodigoBarras.TabIndex = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(788, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Código de Barras";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.button2.Location = new System.Drawing.Point(719, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 40);
            this.button2.TabIndex = 102;
            this.button2.Text = "Carregar Carro";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LabAviso
            // 
            this.LabAviso.AutoSize = true;
            this.LabAviso.BackColor = System.Drawing.Color.Transparent;
            this.LabAviso.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabAviso.ForeColor = System.Drawing.Color.Tomato;
            this.LabAviso.Location = new System.Drawing.Point(721, 242);
            this.LabAviso.Name = "LabAviso";
            this.LabAviso.Size = new System.Drawing.Size(0, 13);
            this.LabAviso.TabIndex = 37;
            // 
            // LabBufferSetor
            // 
            this.LabBufferSetor.AutoSize = true;
            this.LabBufferSetor.BackColor = System.Drawing.Color.Transparent;
            this.LabBufferSetor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabBufferSetor.ForeColor = System.Drawing.Color.White;
            this.LabBufferSetor.Location = new System.Drawing.Point(719, 111);
            this.LabBufferSetor.Name = "LabBufferSetor";
            this.LabBufferSetor.Size = new System.Drawing.Size(40, 13);
            this.LabBufferSetor.TabIndex = 36;
            this.LabBufferSetor.Text = "Setor: ";
            // 
            // LabBufferQuantidade
            // 
            this.LabBufferQuantidade.AutoSize = true;
            this.LabBufferQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.LabBufferQuantidade.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabBufferQuantidade.ForeColor = System.Drawing.Color.White;
            this.LabBufferQuantidade.Location = new System.Drawing.Point(719, 206);
            this.LabBufferQuantidade.Name = "LabBufferQuantidade";
            this.LabBufferQuantidade.Size = new System.Drawing.Size(71, 13);
            this.LabBufferQuantidade.TabIndex = 35;
            this.LabBufferQuantidade.Text = "Quantidade:";
            // 
            // LabBufferCodigo
            // 
            this.LabBufferCodigo.AutoSize = true;
            this.LabBufferCodigo.BackColor = System.Drawing.Color.Transparent;
            this.LabBufferCodigo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabBufferCodigo.ForeColor = System.Drawing.Color.White;
            this.LabBufferCodigo.Location = new System.Drawing.Point(719, 183);
            this.LabBufferCodigo.Name = "LabBufferCodigo";
            this.LabBufferCodigo.Size = new System.Drawing.Size(48, 13);
            this.LabBufferCodigo.TabIndex = 34;
            this.LabBufferCodigo.Text = "Código:";
            // 
            // LabBufferReceita
            // 
            this.LabBufferReceita.AutoSize = true;
            this.LabBufferReceita.BackColor = System.Drawing.Color.Transparent;
            this.LabBufferReceita.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabBufferReceita.ForeColor = System.Drawing.Color.White;
            this.LabBufferReceita.Location = new System.Drawing.Point(719, 158);
            this.LabBufferReceita.Name = "LabBufferReceita";
            this.LabBufferReceita.Size = new System.Drawing.Size(47, 13);
            this.LabBufferReceita.TabIndex = 33;
            this.LabBufferReceita.Text = "Receita:";
            // 
            // LabBufferProduto
            // 
            this.LabBufferProduto.AutoSize = true;
            this.LabBufferProduto.BackColor = System.Drawing.Color.Transparent;
            this.LabBufferProduto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabBufferProduto.ForeColor = System.Drawing.Color.White;
            this.LabBufferProduto.Location = new System.Drawing.Point(719, 134);
            this.LabBufferProduto.Name = "LabBufferProduto";
            this.LabBufferProduto.Size = new System.Drawing.Size(56, 13);
            this.LabBufferProduto.TabIndex = 32;
            this.LabBufferProduto.Text = "Produto: ";
            // 
            // LabBufferPosicao
            // 
            this.LabBufferPosicao.AutoSize = true;
            this.LabBufferPosicao.BackColor = System.Drawing.Color.Transparent;
            this.LabBufferPosicao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabBufferPosicao.ForeColor = System.Drawing.Color.White;
            this.LabBufferPosicao.Location = new System.Drawing.Point(719, 89);
            this.LabBufferPosicao.Name = "LabBufferPosicao";
            this.LabBufferPosicao.Size = new System.Drawing.Size(53, 13);
            this.LabBufferPosicao.TabIndex = 31;
            this.LabBufferPosicao.Text = "Posição: ";
            // 
            // LabBufferID
            // 
            this.LabBufferID.AutoSize = true;
            this.LabBufferID.BackColor = System.Drawing.Color.Transparent;
            this.LabBufferID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabBufferID.ForeColor = System.Drawing.Color.White;
            this.LabBufferID.Location = new System.Drawing.Point(719, 70);
            this.LabBufferID.Name = "LabBufferID";
            this.LabBufferID.Size = new System.Drawing.Size(24, 13);
            this.LabBufferID.TabIndex = 30;
            this.LabBufferID.Text = "ID: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(776, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Carro Selecionado";
            // 
            // LabCBufferSetor
            // 
            this.LabCBufferSetor.AutoSize = true;
            this.LabCBufferSetor.BackColor = System.Drawing.Color.Transparent;
            this.LabCBufferSetor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabCBufferSetor.ForeColor = System.Drawing.Color.White;
            this.LabCBufferSetor.Location = new System.Drawing.Point(719, 542);
            this.LabCBufferSetor.Name = "LabCBufferSetor";
            this.LabCBufferSetor.Size = new System.Drawing.Size(40, 13);
            this.LabCBufferSetor.TabIndex = 45;
            this.LabCBufferSetor.Text = "Setor: ";
            // 
            // LabCBufferQuantidade
            // 
            this.LabCBufferQuantidade.AutoSize = true;
            this.LabCBufferQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.LabCBufferQuantidade.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabCBufferQuantidade.ForeColor = System.Drawing.Color.White;
            this.LabCBufferQuantidade.Location = new System.Drawing.Point(719, 634);
            this.LabCBufferQuantidade.Name = "LabCBufferQuantidade";
            this.LabCBufferQuantidade.Size = new System.Drawing.Size(71, 13);
            this.LabCBufferQuantidade.TabIndex = 44;
            this.LabCBufferQuantidade.Text = "Quantidade:";
            // 
            // LabCBufferCodigo
            // 
            this.LabCBufferCodigo.AutoSize = true;
            this.LabCBufferCodigo.BackColor = System.Drawing.Color.Transparent;
            this.LabCBufferCodigo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabCBufferCodigo.ForeColor = System.Drawing.Color.White;
            this.LabCBufferCodigo.Location = new System.Drawing.Point(719, 612);
            this.LabCBufferCodigo.Name = "LabCBufferCodigo";
            this.LabCBufferCodigo.Size = new System.Drawing.Size(48, 13);
            this.LabCBufferCodigo.TabIndex = 43;
            this.LabCBufferCodigo.Text = "Código:";
            // 
            // LabCBufferReceita
            // 
            this.LabCBufferReceita.AutoSize = true;
            this.LabCBufferReceita.BackColor = System.Drawing.Color.Transparent;
            this.LabCBufferReceita.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabCBufferReceita.ForeColor = System.Drawing.Color.White;
            this.LabCBufferReceita.Location = new System.Drawing.Point(719, 588);
            this.LabCBufferReceita.Name = "LabCBufferReceita";
            this.LabCBufferReceita.Size = new System.Drawing.Size(47, 13);
            this.LabCBufferReceita.TabIndex = 42;
            this.LabCBufferReceita.Text = "Receita:";
            // 
            // LabCBufferProduto
            // 
            this.LabCBufferProduto.AutoSize = true;
            this.LabCBufferProduto.BackColor = System.Drawing.Color.Transparent;
            this.LabCBufferProduto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabCBufferProduto.ForeColor = System.Drawing.Color.White;
            this.LabCBufferProduto.Location = new System.Drawing.Point(719, 565);
            this.LabCBufferProduto.Name = "LabCBufferProduto";
            this.LabCBufferProduto.Size = new System.Drawing.Size(56, 13);
            this.LabCBufferProduto.TabIndex = 41;
            this.LabCBufferProduto.Text = "Produto: ";
            // 
            // LabCBufferPosicao
            // 
            this.LabCBufferPosicao.AutoSize = true;
            this.LabCBufferPosicao.BackColor = System.Drawing.Color.Transparent;
            this.LabCBufferPosicao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabCBufferPosicao.ForeColor = System.Drawing.Color.White;
            this.LabCBufferPosicao.Location = new System.Drawing.Point(719, 519);
            this.LabCBufferPosicao.Name = "LabCBufferPosicao";
            this.LabCBufferPosicao.Size = new System.Drawing.Size(53, 13);
            this.LabCBufferPosicao.TabIndex = 40;
            this.LabCBufferPosicao.Text = "Posição: ";
            // 
            // LabCBufferID
            // 
            this.LabCBufferID.AutoSize = true;
            this.LabCBufferID.BackColor = System.Drawing.Color.Transparent;
            this.LabCBufferID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabCBufferID.ForeColor = System.Drawing.Color.White;
            this.LabCBufferID.Location = new System.Drawing.Point(719, 498);
            this.LabCBufferID.Name = "LabCBufferID";
            this.LabCBufferID.Size = new System.Drawing.Size(24, 13);
            this.LabCBufferID.TabIndex = 39;
            this.LabCBufferID.Text = "ID: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(757, 479);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(154, 17);
            this.label16.TabIndex = 38;
            this.label16.Text = "Último Carro Carregado";
            // 
            // BtnAtualizarCarro
            // 
            this.BtnAtualizarCarro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.BtnAtualizarCarro.Enabled = false;
            this.BtnAtualizarCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtualizarCarro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAtualizarCarro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.BtnAtualizarCarro.Location = new System.Drawing.Point(981, 606);
            this.BtnAtualizarCarro.Name = "BtnAtualizarCarro";
            this.BtnAtualizarCarro.Size = new System.Drawing.Size(260, 40);
            this.BtnAtualizarCarro.TabIndex = 49;
            this.BtnAtualizarCarro.Text = "Atualizar Carro";
            this.BtnAtualizarCarro.UseVisualStyleBackColor = false;
            this.BtnAtualizarCarro.Click += new System.EventHandler(this.BtnAtualizarCarro_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1047, 559);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 15);
            this.label8.TabIndex = 48;
            this.label8.Text = "Atualizar Último Carro";
            // 
            // TBoxAtualizaCarro
            // 
            this.TBoxAtualizaCarro.Enabled = false;
            this.TBoxAtualizaCarro.Location = new System.Drawing.Point(981, 577);
            this.TBoxAtualizaCarro.Name = "TBoxAtualizaCarro";
            this.TBoxAtualizaCarro.Size = new System.Drawing.Size(260, 20);
            this.TBoxAtualizaCarro.TabIndex = 47;
            // 
            // LabelUltCarro
            // 
            this.LabelUltCarro.AutoSize = true;
            this.LabelUltCarro.BackColor = System.Drawing.Color.Transparent;
            this.LabelUltCarro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelUltCarro.ForeColor = System.Drawing.Color.White;
            this.LabelUltCarro.Location = new System.Drawing.Point(981, 540);
            this.LabelUltCarro.Name = "LabelUltCarro";
            this.LabelUltCarro.Size = new System.Drawing.Size(90, 17);
            this.LabelUltCarro.TabIndex = 46;
            this.LabelUltCarro.Text = "Último Carro: ";
            // 
            // ListaAlarmesAtivos
            // 
            this.ListaAlarmesAtivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.ListaAlarmesAtivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaAlarmesAtivos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDativo,
            this.Descricaoativo,
            this.HAtivo});
            this.ListaAlarmesAtivos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListaAlarmesAtivos.ForeColor = System.Drawing.Color.White;
            this.ListaAlarmesAtivos.FullRowSelect = true;
            this.ListaAlarmesAtivos.HideSelection = false;
            this.ListaAlarmesAtivos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.ListaAlarmesAtivos.Location = new System.Drawing.Point(973, 192);
            this.ListaAlarmesAtivos.Name = "ListaAlarmesAtivos";
            this.ListaAlarmesAtivos.Size = new System.Drawing.Size(280, 310);
            this.ListaAlarmesAtivos.TabIndex = 50;
            this.ListaAlarmesAtivos.UseCompatibleStateImageBehavior = false;
            this.ListaAlarmesAtivos.View = System.Windows.Forms.View.Details;
            // 
            // IDativo
            // 
            this.IDativo.Text = "ID";
            this.IDativo.Width = 30;
            // 
            // Descricaoativo
            // 
            this.Descricaoativo.Text = "Descrição";
            this.Descricaoativo.Width = 150;
            // 
            // HAtivo
            // 
            this.HAtivo.Text = "Hora Ativo";
            this.HAtivo.Width = 80;
            // 
            // TxtModo
            // 
            this.TxtModo.AutoSize = true;
            this.TxtModo.BackColor = System.Drawing.Color.Transparent;
            this.TxtModo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtModo.ForeColor = System.Drawing.Color.White;
            this.TxtModo.Location = new System.Drawing.Point(978, 83);
            this.TxtModo.Name = "TxtModo";
            this.TxtModo.Size = new System.Drawing.Size(126, 17);
            this.TxtModo.TabIndex = 54;
            this.TxtModo.Text = "Modo de operação:";
            // 
            // BtnAutoLigado
            // 
            this.BtnAutoLigado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.BtnAutoLigado.Enabled = false;
            this.BtnAutoLigado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAutoLigado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAutoLigado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.BtnAutoLigado.Location = new System.Drawing.Point(1116, 108);
            this.BtnAutoLigado.Name = "BtnAutoLigado";
            this.BtnAutoLigado.Size = new System.Drawing.Size(130, 40);
            this.BtnAutoLigado.TabIndex = 53;
            this.BtnAutoLigado.Text = "Ligado";
            this.BtnAutoLigado.UseVisualStyleBackColor = false;
            this.BtnAutoLigado.Click += new System.EventHandler(this.BtnAutoLigado_Click_1);
            // 
            // BtnAutoDesligado
            // 
            this.BtnAutoDesligado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.BtnAutoDesligado.Enabled = false;
            this.BtnAutoDesligado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAutoDesligado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAutoDesligado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.BtnAutoDesligado.Location = new System.Drawing.Point(980, 108);
            this.BtnAutoDesligado.Name = "BtnAutoDesligado";
            this.BtnAutoDesligado.Size = new System.Drawing.Size(130, 40);
            this.BtnAutoDesligado.TabIndex = 52;
            this.BtnAutoDesligado.Text = "Desligado";
            this.BtnAutoDesligado.UseVisualStyleBackColor = false;
            this.BtnAutoDesligado.Click += new System.EventHandler(this.BtnAutoDesligado_Click_1);
            // 
            // Comunicacao
            // 
            this.Comunicacao.AutoSize = true;
            this.Comunicacao.BackColor = System.Drawing.Color.Transparent;
            this.Comunicacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Comunicacao.ForeColor = System.Drawing.Color.White;
            this.Comunicacao.Location = new System.Drawing.Point(978, 55);
            this.Comunicacao.Name = "Comunicacao";
            this.Comunicacao.Size = new System.Drawing.Size(89, 17);
            this.Comunicacao.TabIndex = 51;
            this.Comunicacao.Text = "Comunicação:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1250, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.MaximumSize = new System.Drawing.Size(0, 30);
            this.textBox1.MinimumSize = new System.Drawing.Size(0, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1280, 30);
            this.textBox1.TabIndex = 56;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(0, 6);
            this.textBox2.MaximumSize = new System.Drawing.Size(3, 1000);
            this.textBox2.MinimumSize = new System.Drawing.Size(3, 1000);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(3, 1000);
            this.textBox2.TabIndex = 57;
            // 
            // TBoxDescricaoReceita
            // 
            this.TBoxDescricaoReceita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.TBoxDescricaoReceita.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBoxDescricaoReceita.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TBoxDescricaoReceita.Enabled = false;
            this.TBoxDescricaoReceita.Location = new System.Drawing.Point(0, 717);
            this.TBoxDescricaoReceita.MaximumSize = new System.Drawing.Size(0, 3);
            this.TBoxDescricaoReceita.MinimumSize = new System.Drawing.Size(0, 3);
            this.TBoxDescricaoReceita.Name = "TBoxDescricaoReceita";
            this.TBoxDescricaoReceita.ReadOnly = true;
            this.TBoxDescricaoReceita.Size = new System.Drawing.Size(1280, 3);
            this.TBoxDescricaoReceita.TabIndex = 58;
            // 
            // TBoxIDReceita
            // 
            this.TBoxIDReceita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.TBoxIDReceita.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBoxIDReceita.Dock = System.Windows.Forms.DockStyle.Right;
            this.TBoxIDReceita.Enabled = false;
            this.TBoxIDReceita.Location = new System.Drawing.Point(1277, 30);
            this.TBoxIDReceita.MaximumSize = new System.Drawing.Size(3, 1000);
            this.TBoxIDReceita.MinimumSize = new System.Drawing.Size(3, 1000);
            this.TBoxIDReceita.Name = "TBoxIDReceita";
            this.TBoxIDReceita.ReadOnly = true;
            this.TBoxIDReceita.Size = new System.Drawing.Size(3, 13);
            this.TBoxIDReceita.TabIndex = 59;
            // 
            // Visual
            // 
            this.Visual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            this.Visual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Visual.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Visual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.Visual.Location = new System.Drawing.Point(7, 120);
            this.Visual.Name = "Visual";
            this.Visual.Size = new System.Drawing.Size(100, 30);
            this.Visual.TabIndex = 60;
            this.Visual.Text = "Visual";
            this.Visual.UseVisualStyleBackColor = true;
            this.Visual.Click += new System.EventHandler(this.Visual_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1221, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(778, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Quantidade de peças";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.button1.Location = new System.Drawing.Point(7, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 103;
            this.button1.Text = "Recarregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnConfirmarManutencao
            // 
            this.BtnConfirmarManutencao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            this.BtnConfirmarManutencao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmarManutencao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConfirmarManutencao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.BtnConfirmarManutencao.Location = new System.Drawing.Point(7, 537);
            this.BtnConfirmarManutencao.Name = "BtnConfirmarManutencao";
            this.BtnConfirmarManutencao.Size = new System.Drawing.Size(100, 37);
            this.BtnConfirmarManutencao.TabIndex = 104;
            this.BtnConfirmarManutencao.Text = "Confirmar Manutenção";
            this.BtnConfirmarManutencao.UseVisualStyleBackColor = false;
            this.BtnConfirmarManutencao.Click += new System.EventHandler(this.BtnConfirmarManutencao_Click);
            // 
            // LblStatusManutencao
            // 
            this.LblStatusManutencao.AutoSize = true;
            this.LblStatusManutencao.BackColor = System.Drawing.Color.Transparent;
            this.LblStatusManutencao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblStatusManutencao.ForeColor = System.Drawing.Color.White;
            this.LblStatusManutencao.Location = new System.Drawing.Point(7, 583);
            this.LblStatusManutencao.Name = "LblStatusManutencao";
            this.LblStatusManutencao.Size = new System.Drawing.Size(91, 15);
            this.LblStatusManutencao.TabIndex = 105;
            this.LblStatusManutencao.Text = "Manutenção: ...";
            // 
            // FrmDadosDosCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.BtnConfirmarManutencao);
            this.Controls.Add(this.LblStatusManutencao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnEditarConfig);
            this.Controls.Add(this.btnVerNotas);
            this.Controls.Add(this.Visual);
            this.Controls.Add(this.TBoxIDReceita);
            this.Controls.Add(this.TBoxDescricaoReceita);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TBoxCodigoPecas);
            this.Controls.Add(this.TxtModo);
            this.Controls.Add(this.BtnAutoLigado);
            this.Controls.Add(this.TBoxCodigoBarras);
            this.Controls.Add(this.BtnAutoDesligado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Comunicacao);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ListaAlarmesAtivos);
            this.Controls.Add(this.BtnAtualizarCarro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TBoxAtualizaCarro);
            this.Controls.Add(this.LabelUltCarro);
            this.Controls.Add(this.LabCBufferSetor);
            this.Controls.Add(this.LabCBufferQuantidade);
            this.Controls.Add(this.LabCBufferCodigo);
            this.Controls.Add(this.LabCBufferReceita);
            this.Controls.Add(this.LabCBufferProduto);
            this.Controls.Add(this.LabCBufferPosicao);
            this.Controls.Add(this.LabCBufferID);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.LabAviso);
            this.Controls.Add(this.LabBufferSetor);
            this.Controls.Add(this.LabBufferQuantidade);
            this.Controls.Add(this.LabBufferCodigo);
            this.Controls.Add(this.LabBufferReceita);
            this.Controls.Add(this.LabBufferProduto);
            this.Controls.Add(this.LabBufferPosicao);
            this.Controls.Add(this.LabBufferID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ListaDadosCarros);
            this.Controls.Add(this.BtnAlarme);
            this.Controls.Add(this.BtnConfiguracoes);
            this.Controls.Add(this.BtnCadastro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDadosDosCarros";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.TransparencyKey = System.Drawing.Color.SkyBlue;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDadosDosCarros_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.FrmDadosDosCarros_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000255 RID: 597
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000256 RID: 598
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000257 RID: 599
		private global::System.Windows.Forms.Button BtnAlarme;

		// Token: 0x04000258 RID: 600
		private global::System.Windows.Forms.Button BtnCadastro;

		// Token: 0x04000259 RID: 601
		private global::System.Windows.Forms.Button BtnConfiguracoes;

		// Token: 0x0400025A RID: 602
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x0400025B RID: 603
		private global::System.Windows.Forms.TextBox TBoxCodigoPecas;

		// Token: 0x0400025C RID: 604
		private global::System.Windows.Forms.TextBox TBoxCodigoBarras;

		// Token: 0x0400025D RID: 605
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400025E RID: 606
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400025F RID: 607
		private global::System.Windows.Forms.ListView ListaDadosCarros;

		// Token: 0x04000260 RID: 608
		private global::System.Windows.Forms.ColumnHeader ColId;

		// Token: 0x04000261 RID: 609
		private global::System.Windows.Forms.ColumnHeader ColPosicao;

		// Token: 0x04000262 RID: 610
		private global::System.Windows.Forms.ColumnHeader Setor;

		// Token: 0x04000263 RID: 611
		private global::System.Windows.Forms.ColumnHeader ColProduto;

		// Token: 0x04000264 RID: 612
		private global::System.Windows.Forms.ColumnHeader ColReceita;

		// Token: 0x04000265 RID: 613
		private global::System.Windows.Forms.ColumnHeader ColCodigo;

		// Token: 0x04000266 RID: 614
		private global::System.Windows.Forms.ColumnHeader ColQuantidade;

		// Token: 0x04000267 RID: 615
		private global::System.Windows.Forms.Label LabAviso;

		// Token: 0x04000268 RID: 616
		private global::System.Windows.Forms.Label LabBufferSetor;

		// Token: 0x04000269 RID: 617
		private global::System.Windows.Forms.Label LabBufferQuantidade;

		// Token: 0x0400026A RID: 618
		private global::System.Windows.Forms.Label LabBufferCodigo;

		// Token: 0x0400026B RID: 619
		private global::System.Windows.Forms.Label LabBufferReceita;

		// Token: 0x0400026C RID: 620
		private global::System.Windows.Forms.Label LabBufferProduto;

		// Token: 0x0400026D RID: 621
		private global::System.Windows.Forms.Label LabBufferPosicao;

		// Token: 0x0400026E RID: 622
		private global::System.Windows.Forms.Label LabBufferID;

		// Token: 0x0400026F RID: 623
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000270 RID: 624
		private global::System.Windows.Forms.Label LabCBufferSetor;

		// Token: 0x04000271 RID: 625
		private global::System.Windows.Forms.Label LabCBufferQuantidade;

		// Token: 0x04000272 RID: 626
		private global::System.Windows.Forms.Label LabCBufferCodigo;

		// Token: 0x04000273 RID: 627
		private global::System.Windows.Forms.Label LabCBufferReceita;

		// Token: 0x04000274 RID: 628
		private global::System.Windows.Forms.Label LabCBufferProduto;

		// Token: 0x04000275 RID: 629
		private global::System.Windows.Forms.Label LabCBufferPosicao;

		// Token: 0x04000276 RID: 630
		private global::System.Windows.Forms.Label LabCBufferID;

		// Token: 0x04000277 RID: 631
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04000278 RID: 632
		private global::System.Windows.Forms.Button BtnAtualizarCarro;

		// Token: 0x04000279 RID: 633
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400027A RID: 634
		private global::System.Windows.Forms.TextBox TBoxAtualizaCarro;

		// Token: 0x0400027B RID: 635
		private global::System.Windows.Forms.Label LabelUltCarro;

		// Token: 0x0400027C RID: 636
		private global::System.Windows.Forms.ListView ListaAlarmesAtivos;

		// Token: 0x0400027D RID: 637
		private global::System.Windows.Forms.ColumnHeader IDativo;

		// Token: 0x0400027E RID: 638
		private global::System.Windows.Forms.ColumnHeader Descricaoativo;

		// Token: 0x0400027F RID: 639
		private global::System.Windows.Forms.ColumnHeader HAtivo;

		// Token: 0x04000280 RID: 640
		private global::System.Windows.Forms.Label TxtModo;

		// Token: 0x04000281 RID: 641
		private global::System.Windows.Forms.Button BtnAutoLigado;

		// Token: 0x04000282 RID: 642
		private global::System.Windows.Forms.Button BtnAutoDesligado;

		// Token: 0x04000283 RID: 643
		private global::System.Windows.Forms.Label Comunicacao;

		// Token: 0x04000284 RID: 644
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000285 RID: 645
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000286 RID: 646
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x04000287 RID: 647
		private global::System.Windows.Forms.TextBox TBoxDescricaoReceita;

		// Token: 0x04000288 RID: 648
		private global::System.Windows.Forms.TextBox TBoxIDReceita;

		// Token: 0x04000289 RID: 649
		private global::System.Windows.Forms.Button Visual;

		// Token: 0x0400028A RID: 650
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x0400028B RID: 651
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400028C RID: 652
		private global::System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnConfirmarManutencao;
        private System.Windows.Forms.Label LblStatusManutencao; //
        private System.Windows.Forms.Button btnEditarConfig;
        private System.Windows.Forms.Button btnVerNotas;
    }
}
