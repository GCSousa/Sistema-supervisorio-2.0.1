namespace SupervisorioDana
{
	// Token: 0x02000007 RID: 7
	public partial class FrmDadosDosCarros1920x1080 : global::System.Windows.Forms.Form
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x0000D994 File Offset: 0x0000BB94
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000D9CC File Offset: 0x0000BBCC
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDadosDosCarros1920x1080));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAlarme = new System.Windows.Forms.Button();
            this.BtnCadastro = new System.Windows.Forms.Button();
            this.BtnConfiguracoes = new System.Windows.Forms.Button();
            this.btnEditarConfig = new System.Windows.Forms.Button();
            this.LblStatusManutencao = new System.Windows.Forms.Label();
            this.BtnConfirmarManutencao = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(53, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "INICIO";
            // 
            // BtnAlarme
            // 
            this.BtnAlarme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            this.BtnAlarme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlarme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAlarme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.BtnAlarme.Location = new System.Drawing.Point(10, 50);
            this.BtnAlarme.Name = "BtnAlarme";
            this.BtnAlarme.Size = new System.Drawing.Size(150, 40);
            this.BtnAlarme.TabIndex = 1;
            this.BtnAlarme.Text = "Alarme";
            this.BtnAlarme.UseVisualStyleBackColor = true;
            this.BtnAlarme.Click += new System.EventHandler(this.BtnAlarme_Click);
            // 
            // BtnCadastro
            // 
            this.BtnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            this.BtnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.BtnCadastro.Location = new System.Drawing.Point(10, 100);
            this.BtnCadastro.Name = "BtnCadastro";
            this.BtnCadastro.Size = new System.Drawing.Size(150, 40);
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
            this.BtnConfiguracoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConfiguracoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.BtnConfiguracoes.Location = new System.Drawing.Point(10, 200);
            this.BtnConfiguracoes.Name = "BtnConfiguracoes";
            this.BtnConfiguracoes.Size = new System.Drawing.Size(150, 40);
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
            this.btnEditarConfig.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditarConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.btnEditarConfig.Location = new System.Drawing.Point(9, 277);
            this.btnEditarConfig.Name = "btnEditarConfig";
            this.btnEditarConfig.Size = new System.Drawing.Size(150, 40);
            this.btnEditarConfig.TabIndex = 106;
            this.btnEditarConfig.Text = "Editar Horários";
            this.btnEditarConfig.UseVisualStyleBackColor = false;
            this.btnEditarConfig.Click += new System.EventHandler(this.btnEditarConfig_Click);
            // 
            // LblStatusManutencao
            // 
            this.LblStatusManutencao.AutoSize = true;
            this.LblStatusManutencao.BackColor = System.Drawing.Color.Transparent;
            this.LblStatusManutencao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblStatusManutencao.ForeColor = System.Drawing.Color.White;
            this.LblStatusManutencao.Location = new System.Drawing.Point(10, 400);
            this.LblStatusManutencao.Name = "LblStatusManutencao";
            this.LblStatusManutencao.Size = new System.Drawing.Size(126, 21);
            this.LblStatusManutencao.TabIndex = 105;
            this.LblStatusManutencao.Text = "Manutenção: ...";
            // 
            // BtnConfirmarManutencao
            // 
            this.BtnConfirmarManutencao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            this.BtnConfirmarManutencao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmarManutencao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConfirmarManutencao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.BtnConfirmarManutencao.Location = new System.Drawing.Point(10, 331);
            this.BtnConfirmarManutencao.Name = "BtnConfirmarManutencao";
            this.BtnConfirmarManutencao.Size = new System.Drawing.Size(150, 60);
            this.BtnConfirmarManutencao.TabIndex = 193;
            this.BtnConfirmarManutencao.Text = "Confirmar Análise";
            this.BtnConfirmarManutencao.UseVisualStyleBackColor = false;
            this.BtnConfirmarManutencao.Click += new System.EventHandler(this.BtnConfirmarManutencao_Click);
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
            this.ListaDadosCarros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListaDadosCarros.ForeColor = System.Drawing.Color.White;
            this.ListaDadosCarros.FullRowSelect = true;
            this.ListaDadosCarros.HideSelection = false;
            this.ListaDadosCarros.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ListaDadosCarros.Location = new System.Drawing.Point(190, 64);
            this.ListaDadosCarros.Name = "ListaDadosCarros";
            this.ListaDadosCarros.Scrollable = false;
            this.ListaDadosCarros.Size = new System.Drawing.Size(856, 861);
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
            // 
            // ColPosicao
            // 
            this.ColPosicao.Text = "Posição";
            this.ColPosicao.Width = 80;
            // 
            // Setor
            // 
            this.Setor.Text = "Setor";
            this.Setor.Width = 150;
            // 
            // ColProduto
            // 
            this.ColProduto.Text = "Produto";
            this.ColProduto.Width = 180;
            // 
            // ColReceita
            // 
            this.ColReceita.Text = "Receita";
            this.ColReceita.Width = 160;
            // 
            // ColCodigo
            // 
            this.ColCodigo.Text = "Código";
            this.ColCodigo.Width = 120;
            // 
            // ColQuantidade
            // 
            this.ColQuantidade.Text = "Quantidade";
            this.ColQuantidade.Width = 80;
            // 
            // TBoxCodigoPecas
            // 
            this.TBoxCodigoPecas.AcceptsTab = true;
            this.TBoxCodigoPecas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TBoxCodigoPecas.Location = new System.Drawing.Point(1080, 535);
            this.TBoxCodigoPecas.Name = "TBoxCodigoPecas";
            this.TBoxCodigoPecas.Size = new System.Drawing.Size(350, 29);
            this.TBoxCodigoPecas.TabIndex = 101;
            // 
            // TBoxCodigoBarras
            // 
            this.TBoxCodigoBarras.AcceptsTab = true;
            this.TBoxCodigoBarras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TBoxCodigoBarras.Location = new System.Drawing.Point(1080, 468);
            this.TBoxCodigoBarras.Name = "TBoxCodigoBarras";
            this.TBoxCodigoBarras.Size = new System.Drawing.Size(350, 29);
            this.TBoxCodigoBarras.TabIndex = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(1184, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Código de Barras";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.button2.Location = new System.Drawing.Point(1080, 584);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(350, 60);
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
            this.LabAviso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabAviso.ForeColor = System.Drawing.Color.Tomato;
            this.LabAviso.Location = new System.Drawing.Point(1100, 370);
            this.LabAviso.Name = "LabAviso";
            this.LabAviso.Size = new System.Drawing.Size(0, 21);
            this.LabAviso.TabIndex = 37;
            // 
            // LabBufferSetor
            // 
            this.LabBufferSetor.AutoSize = true;
            this.LabBufferSetor.BackColor = System.Drawing.Color.Transparent;
            this.LabBufferSetor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabBufferSetor.ForeColor = System.Drawing.Color.White;
            this.LabBufferSetor.Location = new System.Drawing.Point(1100, 187);
            this.LabBufferSetor.Name = "LabBufferSetor";
            this.LabBufferSetor.Size = new System.Drawing.Size(59, 21);
            this.LabBufferSetor.TabIndex = 36;
            this.LabBufferSetor.Text = "Setor: ";
            // 
            // LabBufferQuantidade
            // 
            this.LabBufferQuantidade.AutoSize = true;
            this.LabBufferQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.LabBufferQuantidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabBufferQuantidade.ForeColor = System.Drawing.Color.White;
            this.LabBufferQuantidade.Location = new System.Drawing.Point(1100, 307);
            this.LabBufferQuantidade.Name = "LabBufferQuantidade";
            this.LabBufferQuantidade.Size = new System.Drawing.Size(104, 21);
            this.LabBufferQuantidade.TabIndex = 35;
            this.LabBufferQuantidade.Text = "Quantidade:";
            // 
            // LabBufferCodigo
            // 
            this.LabBufferCodigo.AutoSize = true;
            this.LabBufferCodigo.BackColor = System.Drawing.Color.Transparent;
            this.LabBufferCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabBufferCodigo.ForeColor = System.Drawing.Color.White;
            this.LabBufferCodigo.Location = new System.Drawing.Point(1100, 277);
            this.LabBufferCodigo.Name = "LabBufferCodigo";
            this.LabBufferCodigo.Size = new System.Drawing.Size(69, 21);
            this.LabBufferCodigo.TabIndex = 34;
            this.LabBufferCodigo.Text = "Código:";
            // 
            // LabBufferReceita
            // 
            this.LabBufferReceita.AutoSize = true;
            this.LabBufferReceita.BackColor = System.Drawing.Color.Transparent;
            this.LabBufferReceita.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabBufferReceita.ForeColor = System.Drawing.Color.White;
            this.LabBufferReceita.Location = new System.Drawing.Point(1100, 247);
            this.LabBufferReceita.Name = "LabBufferReceita";
            this.LabBufferReceita.Size = new System.Drawing.Size(70, 21);
            this.LabBufferReceita.TabIndex = 33;
            this.LabBufferReceita.Text = "Receita:";
            // 
            // LabBufferProduto
            // 
            this.LabBufferProduto.AutoSize = true;
            this.LabBufferProduto.BackColor = System.Drawing.Color.Transparent;
            this.LabBufferProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabBufferProduto.ForeColor = System.Drawing.Color.White;
            this.LabBufferProduto.Location = new System.Drawing.Point(1100, 217);
            this.LabBufferProduto.Name = "LabBufferProduto";
            this.LabBufferProduto.Size = new System.Drawing.Size(80, 21);
            this.LabBufferProduto.TabIndex = 32;
            this.LabBufferProduto.Text = "Produto: ";
            // 
            // LabBufferPosicao
            // 
            this.LabBufferPosicao.AutoSize = true;
            this.LabBufferPosicao.BackColor = System.Drawing.Color.Transparent;
            this.LabBufferPosicao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabBufferPosicao.ForeColor = System.Drawing.Color.White;
            this.LabBufferPosicao.Location = new System.Drawing.Point(1100, 157);
            this.LabBufferPosicao.Name = "LabBufferPosicao";
            this.LabBufferPosicao.Size = new System.Drawing.Size(77, 21);
            this.LabBufferPosicao.TabIndex = 31;
            this.LabBufferPosicao.Text = "Posição: ";
            // 
            // LabBufferID
            // 
            this.LabBufferID.AutoSize = true;
            this.LabBufferID.BackColor = System.Drawing.Color.Transparent;
            this.LabBufferID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabBufferID.ForeColor = System.Drawing.Color.White;
            this.LabBufferID.Location = new System.Drawing.Point(1100, 127);
            this.LabBufferID.Name = "LabBufferID";
            this.LabBufferID.Size = new System.Drawing.Size(35, 21);
            this.LabBufferID.TabIndex = 30;
            this.LabBufferID.Text = "ID: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1176, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 25);
            this.label9.TabIndex = 29;
            this.label9.Text = "Carro Selecionado";
            // 
            // LabCBufferSetor
            // 
            this.LabCBufferSetor.AutoSize = true;
            this.LabCBufferSetor.BackColor = System.Drawing.Color.Transparent;
            this.LabCBufferSetor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabCBufferSetor.ForeColor = System.Drawing.Color.White;
            this.LabCBufferSetor.Location = new System.Drawing.Point(1100, 830);
            this.LabCBufferSetor.Name = "LabCBufferSetor";
            this.LabCBufferSetor.Size = new System.Drawing.Size(59, 21);
            this.LabCBufferSetor.TabIndex = 45;
            this.LabCBufferSetor.Text = "Setor: ";
            // 
            // LabCBufferQuantidade
            // 
            this.LabCBufferQuantidade.AutoSize = true;
            this.LabCBufferQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.LabCBufferQuantidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabCBufferQuantidade.ForeColor = System.Drawing.Color.White;
            this.LabCBufferQuantidade.Location = new System.Drawing.Point(1100, 950);
            this.LabCBufferQuantidade.Name = "LabCBufferQuantidade";
            this.LabCBufferQuantidade.Size = new System.Drawing.Size(104, 21);
            this.LabCBufferQuantidade.TabIndex = 44;
            this.LabCBufferQuantidade.Text = "Quantidade:";
            // 
            // LabCBufferCodigo
            // 
            this.LabCBufferCodigo.AutoSize = true;
            this.LabCBufferCodigo.BackColor = System.Drawing.Color.Transparent;
            this.LabCBufferCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabCBufferCodigo.ForeColor = System.Drawing.Color.White;
            this.LabCBufferCodigo.Location = new System.Drawing.Point(1100, 920);
            this.LabCBufferCodigo.Name = "LabCBufferCodigo";
            this.LabCBufferCodigo.Size = new System.Drawing.Size(69, 21);
            this.LabCBufferCodigo.TabIndex = 43;
            this.LabCBufferCodigo.Text = "Código:";
            // 
            // LabCBufferReceita
            // 
            this.LabCBufferReceita.AutoSize = true;
            this.LabCBufferReceita.BackColor = System.Drawing.Color.Transparent;
            this.LabCBufferReceita.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabCBufferReceita.ForeColor = System.Drawing.Color.White;
            this.LabCBufferReceita.Location = new System.Drawing.Point(1100, 890);
            this.LabCBufferReceita.Name = "LabCBufferReceita";
            this.LabCBufferReceita.Size = new System.Drawing.Size(70, 21);
            this.LabCBufferReceita.TabIndex = 42;
            this.LabCBufferReceita.Text = "Receita:";
            // 
            // LabCBufferProduto
            // 
            this.LabCBufferProduto.AutoSize = true;
            this.LabCBufferProduto.BackColor = System.Drawing.Color.Transparent;
            this.LabCBufferProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabCBufferProduto.ForeColor = System.Drawing.Color.White;
            this.LabCBufferProduto.Location = new System.Drawing.Point(1100, 860);
            this.LabCBufferProduto.Name = "LabCBufferProduto";
            this.LabCBufferProduto.Size = new System.Drawing.Size(80, 21);
            this.LabCBufferProduto.TabIndex = 41;
            this.LabCBufferProduto.Text = "Produto: ";
            // 
            // LabCBufferPosicao
            // 
            this.LabCBufferPosicao.AutoSize = true;
            this.LabCBufferPosicao.BackColor = System.Drawing.Color.Transparent;
            this.LabCBufferPosicao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabCBufferPosicao.ForeColor = System.Drawing.Color.White;
            this.LabCBufferPosicao.Location = new System.Drawing.Point(1100, 800);
            this.LabCBufferPosicao.Name = "LabCBufferPosicao";
            this.LabCBufferPosicao.Size = new System.Drawing.Size(77, 21);
            this.LabCBufferPosicao.TabIndex = 40;
            this.LabCBufferPosicao.Text = "Posição: ";
            // 
            // LabCBufferID
            // 
            this.LabCBufferID.AutoSize = true;
            this.LabCBufferID.BackColor = System.Drawing.Color.Transparent;
            this.LabCBufferID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabCBufferID.ForeColor = System.Drawing.Color.White;
            this.LabCBufferID.Location = new System.Drawing.Point(1100, 770);
            this.LabCBufferID.Name = "LabCBufferID";
            this.LabCBufferID.Size = new System.Drawing.Size(35, 21);
            this.LabCBufferID.TabIndex = 39;
            this.LabCBufferID.Text = "ID: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(1145, 734);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(226, 25);
            this.label16.TabIndex = 38;
            this.label16.Text = "Último Carro Carregado";
            // 
            // BtnAtualizarCarro
            // 
            this.BtnAtualizarCarro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.BtnAtualizarCarro.Enabled = false;
            this.BtnAtualizarCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtualizarCarro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAtualizarCarro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.BtnAtualizarCarro.Location = new System.Drawing.Point(1473, 922);
            this.BtnAtualizarCarro.Name = "BtnAtualizarCarro";
            this.BtnAtualizarCarro.Size = new System.Drawing.Size(400, 60);
            this.BtnAtualizarCarro.TabIndex = 49;
            this.BtnAtualizarCarro.Text = "Atualizar Carro";
            this.BtnAtualizarCarro.UseVisualStyleBackColor = false;
            this.BtnAtualizarCarro.Click += new System.EventHandler(this.BtnAtualizarCarro_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1592, 854);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 21);
            this.label8.TabIndex = 48;
            this.label8.Text = "Atualizar Último Carro";
            // 
            // TBoxAtualizaCarro
            // 
            this.TBoxAtualizaCarro.Enabled = false;
            this.TBoxAtualizaCarro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBoxAtualizaCarro.Location = new System.Drawing.Point(1473, 883);
            this.TBoxAtualizaCarro.Name = "TBoxAtualizaCarro";
            this.TBoxAtualizaCarro.Size = new System.Drawing.Size(400, 29);
            this.TBoxAtualizaCarro.TabIndex = 47;
            // 
            // LabelUltCarro
            // 
            this.LabelUltCarro.AutoSize = true;
            this.LabelUltCarro.BackColor = System.Drawing.Color.Transparent;
            this.LabelUltCarro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelUltCarro.ForeColor = System.Drawing.Color.White;
            this.LabelUltCarro.Location = new System.Drawing.Point(1477, 820);
            this.LabelUltCarro.Name = "LabelUltCarro";
            this.LabelUltCarro.Size = new System.Drawing.Size(107, 21);
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
            this.ListaAlarmesAtivos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListaAlarmesAtivos.ForeColor = System.Drawing.Color.White;
            this.ListaAlarmesAtivos.FullRowSelect = true;
            this.ListaAlarmesAtivos.HideSelection = false;
            this.ListaAlarmesAtivos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.ListaAlarmesAtivos.Location = new System.Drawing.Point(1464, 290);
            this.ListaAlarmesAtivos.Name = "ListaAlarmesAtivos";
            this.ListaAlarmesAtivos.Size = new System.Drawing.Size(422, 465);
            this.ListaAlarmesAtivos.TabIndex = 50;
            this.ListaAlarmesAtivos.UseCompatibleStateImageBehavior = false;
            this.ListaAlarmesAtivos.View = System.Windows.Forms.View.Details;
            // 
            // IDativo
            // 
            this.IDativo.Text = "ID";
            // 
            // Descricaoativo
            // 
            this.Descricaoativo.Text = "Descrição";
            this.Descricaoativo.Width = 210;
            // 
            // HAtivo
            // 
            this.HAtivo.Text = "Hora Ativo";
            this.HAtivo.Width = 120;
            // 
            // TxtModo
            // 
            this.TxtModo.AutoSize = true;
            this.TxtModo.BackColor = System.Drawing.Color.Transparent;
            this.TxtModo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtModo.ForeColor = System.Drawing.Color.White;
            this.TxtModo.Location = new System.Drawing.Point(1485, 123);
            this.TxtModo.Name = "TxtModo";
            this.TxtModo.Size = new System.Drawing.Size(143, 21);
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
            this.BtnAutoLigado.Location = new System.Drawing.Point(1680, 159);
            this.BtnAutoLigado.Name = "BtnAutoLigado";
            this.BtnAutoLigado.Size = new System.Drawing.Size(190, 60);
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
            this.BtnAutoDesligado.Location = new System.Drawing.Point(1479, 160);
            this.BtnAutoDesligado.Name = "BtnAutoDesligado";
            this.BtnAutoDesligado.Size = new System.Drawing.Size(190, 60);
            this.BtnAutoDesligado.TabIndex = 52;
            this.BtnAutoDesligado.Text = "Desligado";
            this.BtnAutoDesligado.UseVisualStyleBackColor = false;
            this.BtnAutoDesligado.Click += new System.EventHandler(this.BtnAutoDesligado_Click_1);
            // 
            // Comunicacao
            // 
            this.Comunicacao.AutoSize = true;
            this.Comunicacao.BackColor = System.Drawing.Color.Transparent;
            this.Comunicacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Comunicacao.ForeColor = System.Drawing.Color.White;
            this.Comunicacao.Location = new System.Drawing.Point(1485, 89);
            this.Comunicacao.Name = "Comunicacao";
            this.Comunicacao.Size = new System.Drawing.Size(107, 21);
            this.Comunicacao.TabIndex = 51;
            this.Comunicacao.Text = "Comunicação:";
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
            this.textBox1.MinimumSize = new System.Drawing.Size(0, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1370, 40);
            this.textBox1.TabIndex = 56;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(0, 29);
            this.textBox2.MaximumSize = new System.Drawing.Size(3, 1920);
            this.textBox2.MinimumSize = new System.Drawing.Size(3, 1920);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(3, 1920);
            this.textBox2.TabIndex = 57;
            // 
            // TBoxDescricaoReceita
            // 
            this.TBoxDescricaoReceita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.TBoxDescricaoReceita.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBoxDescricaoReceita.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TBoxDescricaoReceita.Enabled = false;
            this.TBoxDescricaoReceita.Location = new System.Drawing.Point(0, 746);
            this.TBoxDescricaoReceita.MaximumSize = new System.Drawing.Size(0, 3);
            this.TBoxDescricaoReceita.MinimumSize = new System.Drawing.Size(0, 3);
            this.TBoxDescricaoReceita.Name = "TBoxDescricaoReceita";
            this.TBoxDescricaoReceita.ReadOnly = true;
            this.TBoxDescricaoReceita.Size = new System.Drawing.Size(1370, 3);
            this.TBoxDescricaoReceita.TabIndex = 58;
            // 
            // TBoxIDReceita
            // 
            this.TBoxIDReceita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.TBoxIDReceita.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBoxIDReceita.Dock = System.Windows.Forms.DockStyle.Right;
            this.TBoxIDReceita.Enabled = false;
            this.TBoxIDReceita.Location = new System.Drawing.Point(1367, 40);
            this.TBoxIDReceita.MaximumSize = new System.Drawing.Size(3, 1000);
            this.TBoxIDReceita.MinimumSize = new System.Drawing.Size(3, 1000);
            this.TBoxIDReceita.Name = "TBoxIDReceita";
            this.TBoxIDReceita.ReadOnly = true;
            this.TBoxIDReceita.Size = new System.Drawing.Size(3, 1000);
            this.TBoxIDReceita.TabIndex = 59;
            // 
            // Visual
            // 
            this.Visual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            this.Visual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Visual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Visual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.Visual.Location = new System.Drawing.Point(10, 150);
            this.Visual.Name = "Visual";
            this.Visual.Size = new System.Drawing.Size(150, 40);
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
            this.pictureBox2.Location = new System.Drawing.Point(1850, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(1169, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 21);
            this.label2.TabIndex = 62;
            this.label2.Text = "Quantidade de peças";
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmDadosDosCarros1920x1080
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnConfirmarManutencao);
            this.Controls.Add(this.LblStatusManutencao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
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
            this.Controls.Add(this.btnEditarConfig);
            this.Controls.Add(this.BtnCadastro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDadosDosCarros1920x1080";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.TransparencyKey = System.Drawing.Color.SkyBlue;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDadosDosCarros_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.FrmDadosDosCarros_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x040000BE RID: 190
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000BF RID: 191
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000C0 RID: 192
		private global::System.Windows.Forms.Button BtnAlarme;

		// Token: 0x040000C1 RID: 193
		private global::System.Windows.Forms.Button BtnCadastro;

		// Token: 0x040000C2 RID: 194
		private global::System.Windows.Forms.Button BtnConfiguracoes;

		// Token: 0x040000C3 RID: 195
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x040000C4 RID: 196
		private global::System.Windows.Forms.TextBox TBoxCodigoPecas;

		// Token: 0x040000C5 RID: 197
		private global::System.Windows.Forms.TextBox TBoxCodigoBarras;

		// Token: 0x040000C6 RID: 198
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040000C7 RID: 199
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040000C8 RID: 200
		private global::System.Windows.Forms.ListView ListaDadosCarros;

		// Token: 0x040000C9 RID: 201
		private global::System.Windows.Forms.ColumnHeader ColId;

		// Token: 0x040000CA RID: 202
		private global::System.Windows.Forms.ColumnHeader ColPosicao;

		// Token: 0x040000CB RID: 203
		private global::System.Windows.Forms.ColumnHeader Setor;

		// Token: 0x040000CC RID: 204
		private global::System.Windows.Forms.ColumnHeader ColProduto;

		// Token: 0x040000CD RID: 205
		private global::System.Windows.Forms.ColumnHeader ColReceita;

		// Token: 0x040000CE RID: 206
		private global::System.Windows.Forms.ColumnHeader ColCodigo;

		// Token: 0x040000CF RID: 207
		private global::System.Windows.Forms.ColumnHeader ColQuantidade;

		// Token: 0x040000D0 RID: 208
		private global::System.Windows.Forms.Label LabAviso;

		// Token: 0x040000D1 RID: 209
		private global::System.Windows.Forms.Label LabBufferSetor;

		// Token: 0x040000D2 RID: 210
		private global::System.Windows.Forms.Label LabBufferQuantidade;

		// Token: 0x040000D3 RID: 211
		private global::System.Windows.Forms.Label LabBufferCodigo;

		// Token: 0x040000D4 RID: 212
		private global::System.Windows.Forms.Label LabBufferReceita;

		// Token: 0x040000D5 RID: 213
		private global::System.Windows.Forms.Label LabBufferProduto;

		// Token: 0x040000D6 RID: 214
		private global::System.Windows.Forms.Label LabBufferPosicao;

		// Token: 0x040000D7 RID: 215
		private global::System.Windows.Forms.Label LabBufferID;

		// Token: 0x040000D8 RID: 216
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040000D9 RID: 217
		private global::System.Windows.Forms.Label LabCBufferSetor;

		// Token: 0x040000DA RID: 218
		private global::System.Windows.Forms.Label LabCBufferQuantidade;

		// Token: 0x040000DB RID: 219
		private global::System.Windows.Forms.Label LabCBufferCodigo;

		// Token: 0x040000DC RID: 220
		private global::System.Windows.Forms.Label LabCBufferReceita;

		// Token: 0x040000DD RID: 221
		private global::System.Windows.Forms.Label LabCBufferProduto;

		// Token: 0x040000DE RID: 222
		private global::System.Windows.Forms.Label LabCBufferPosicao;

		// Token: 0x040000DF RID: 223
		private global::System.Windows.Forms.Label LabCBufferID;

		// Token: 0x040000E0 RID: 224
		private global::System.Windows.Forms.Label label16;

		// Token: 0x040000E1 RID: 225
		private global::System.Windows.Forms.Button BtnAtualizarCarro;

		// Token: 0x040000E2 RID: 226
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040000E3 RID: 227
		private global::System.Windows.Forms.TextBox TBoxAtualizaCarro;

		// Token: 0x040000E4 RID: 228
		private global::System.Windows.Forms.Label LabelUltCarro;

		// Token: 0x040000E5 RID: 229
		private global::System.Windows.Forms.ListView ListaAlarmesAtivos;

		// Token: 0x040000E6 RID: 230
		private global::System.Windows.Forms.ColumnHeader IDativo;

		// Token: 0x040000E7 RID: 231
		private global::System.Windows.Forms.ColumnHeader Descricaoativo;

		// Token: 0x040000E8 RID: 232
		private global::System.Windows.Forms.ColumnHeader HAtivo;

		// Token: 0x040000E9 RID: 233
		private global::System.Windows.Forms.Label TxtModo;

		// Token: 0x040000EA RID: 234
		private global::System.Windows.Forms.Button BtnAutoLigado;

		// Token: 0x040000EB RID: 235
		private global::System.Windows.Forms.Button BtnAutoDesligado;

		// Token: 0x040000EC RID: 236
		private global::System.Windows.Forms.Label Comunicacao;

		// Token: 0x040000ED RID: 237
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040000EE RID: 238
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x040000EF RID: 239
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x040000F0 RID: 240
		private global::System.Windows.Forms.TextBox TBoxDescricaoReceita;

		// Token: 0x040000F1 RID: 241
		private global::System.Windows.Forms.TextBox TBoxIDReceita;

		// Token: 0x040000F2 RID: 242
		private global::System.Windows.Forms.Button Visual;

		// Token: 0x040000F3 RID: 243
		private global::System.Windows.Forms.PictureBox pictureBox2;

        // Token: 0x040000F4 RID: 244
        private global::System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button btnEditarConfig;

        private System.Windows.Forms.Button BtnConfirmarManutencao;
        private System.Windows.Forms.Label LblStatusManutencao;

        // Token: 0x040000F5 RID: 245
        private global::System.Windows.Forms.Button button1;
	}
}
