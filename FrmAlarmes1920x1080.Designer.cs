namespace SupervisorioDana
{
	// Token: 0x02000004 RID: 4
	public partial class FrmAlarmes1920x1080 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000041 RID: 65 RVA: 0x000041C0 File Offset: 0x000023C0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000041F8 File Offset: 0x000023F8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.ListViewItem listViewItem = new global::System.Windows.Forms.ListViewItem("");
			global::System.Windows.Forms.ListViewItem listViewItem2 = new global::System.Windows.Forms.ListViewItem("");
			global::System.Windows.Forms.ListViewItem listViewItem3 = new global::System.Windows.Forms.ListViewItem("");
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SupervisorioDana.FrmAlarmes1920x1080));
			this.BtnAlarme = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Comunicacao = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.ListaJustificava = new global::System.Windows.Forms.ListView();
			this.IDHistorico = new global::System.Windows.Forms.ColumnHeader();
			this.ColDescrição = new global::System.Windows.Forms.ColumnHeader();
			this.DataLigado = new global::System.Windows.Forms.ColumnHeader();
			this.Datadesligado = new global::System.Windows.Forms.ColumnHeader();
			this.ResponsavelHistorico = new global::System.Windows.Forms.ColumnHeader();
			this.BtnAtualizarCarro = new global::System.Windows.Forms.Button();
			this.label8 = new global::System.Windows.Forms.Label();
			this.TBoxAtualizaCarro = new global::System.Windows.Forms.TextBox();
			this.LabelUltCarro = new global::System.Windows.Forms.Label();
			this.Tboxjustificativa = new global::System.Windows.Forms.ComboBox();
			this.TBoxAlarmesdiag = new global::System.Windows.Forms.TextBox();
			this.BtnRearmar = new global::System.Windows.Forms.Button();
			this.BtnSalvar = new global::System.Windows.Forms.Button();
			this.ListaAlarmesAtivos = new global::System.Windows.Forms.ListView();
			this.IDativo = new global::System.Windows.Forms.ColumnHeader();
			this.Descricaoativo = new global::System.Windows.Forms.ColumnHeader();
			this.HAtivo = new global::System.Windows.Forms.ColumnHeader();
			this.ListaAlarmes = new global::System.Windows.Forms.ListView();
			this.ID = new global::System.Windows.Forms.ColumnHeader();
			this.Descriçao = new global::System.Windows.Forms.ColumnHeader();
			this.Estado = new global::System.Windows.Forms.ColumnHeader();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.textBox4 = new global::System.Windows.Forms.TextBox();
			this.textBox5 = new global::System.Windows.Forms.TextBox();
			this.textBox3 = new global::System.Windows.Forms.TextBox();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			base.SuspendLayout();
			this.BtnAlarme.BackColor = global::System.Drawing.Color.FromArgb(68, 180, 74);
			this.BtnAlarme.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.BtnAlarme.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.BtnAlarme.ForeColor = global::System.Drawing.Color.FromArgb(9, 37, 60);
			this.BtnAlarme.Location = new global::System.Drawing.Point(10, 50);
			this.BtnAlarme.Name = "BtnAlarme";
			this.BtnAlarme.Size = new global::System.Drawing.Size(150, 40);
			this.BtnAlarme.TabIndex = 22;
			this.BtnAlarme.Text = "Inicio";
			this.BtnAlarme.UseVisualStyleBackColor = false;
			this.BtnAlarme.Click += new global::System.EventHandler(this.BtnAlarme_Click);
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(42, 7);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(99, 25);
			this.label1.TabIndex = 21;
			this.label1.Text = "ALARMES";
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.Comunicacao.AutoSize = true;
			this.Comunicacao.BackColor = global::System.Drawing.Color.Transparent;
			this.Comunicacao.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point);
			this.Comunicacao.ForeColor = global::System.Drawing.Color.White;
			this.Comunicacao.Location = new global::System.Drawing.Point(20, 905);
			this.Comunicacao.Name = "Comunicacao";
			this.Comunicacao.Size = new global::System.Drawing.Size(0, 21);
			this.Comunicacao.TabIndex = 28;
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.label3.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(20, 890);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(111, 21);
			this.label3.TabIndex = 31;
			this.label3.Text = "Comunicação: ";
			this.ListaJustificava.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.ListaJustificava.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.ListaJustificava.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[] { this.IDHistorico, this.ColDescrição, this.DataLigado, this.Datadesligado, this.ResponsavelHistorico });
			this.ListaJustificava.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point);
			this.ListaJustificava.ForeColor = global::System.Drawing.Color.White;
			this.ListaJustificava.FullRowSelect = true;
			this.ListaJustificava.HideSelection = false;
			this.ListaJustificava.Items.AddRange(new global::System.Windows.Forms.ListViewItem[] { listViewItem });
			this.ListaJustificava.Location = new global::System.Drawing.Point(185, 64);
			this.ListaJustificava.Name = "ListaJustificava";
			this.ListaJustificava.Size = new global::System.Drawing.Size(654, 851);
			this.ListaJustificava.TabIndex = 32;
			this.ListaJustificava.UseCompatibleStateImageBehavior = false;
			this.ListaJustificava.View = global::System.Windows.Forms.View.Details;
			this.IDHistorico.Text = "ID";
			this.ColDescrição.Text = "Descrição";
			this.ColDescrição.Width = 310;
			this.DataLigado.Text = "Data I";
			this.DataLigado.Width = 80;
			this.Datadesligado.Text = "Duração";
			this.Datadesligado.Width = 80;
			this.ResponsavelHistorico.Text = "Responsável";
			this.ResponsavelHistorico.Width = 100;
			this.BtnAtualizarCarro.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.BtnAtualizarCarro.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.BtnAtualizarCarro.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.BtnAtualizarCarro.ForeColor = global::System.Drawing.Color.FromArgb(9, 37, 60);
			this.BtnAtualizarCarro.Location = new global::System.Drawing.Point(873, 952);
			this.BtnAtualizarCarro.Name = "BtnAtualizarCarro";
			this.BtnAtualizarCarro.Size = new global::System.Drawing.Size(500, 60);
			this.BtnAtualizarCarro.TabIndex = 36;
			this.BtnAtualizarCarro.Text = "Atualizar Carro";
			this.BtnAtualizarCarro.UseVisualStyleBackColor = false;
			this.BtnAtualizarCarro.Click += new global::System.EventHandler(this.button5_Click);
			this.label8.AutoSize = true;
			this.label8.BackColor = global::System.Drawing.Color.Transparent;
			this.label8.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point);
			this.label8.ForeColor = global::System.Drawing.Color.White;
			this.label8.Location = new global::System.Drawing.Point(1032, 879);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(169, 21);
			this.label8.TabIndex = 35;
			this.label8.Text = "Atualizar Último Carro ";
			this.TBoxAtualizaCarro.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point);
			this.TBoxAtualizaCarro.Location = new global::System.Drawing.Point(873, 908);
			this.TBoxAtualizaCarro.Name = "TBoxAtualizaCarro";
			this.TBoxAtualizaCarro.Size = new global::System.Drawing.Size(500, 29);
			this.TBoxAtualizaCarro.TabIndex = 34;
			this.LabelUltCarro.AutoSize = true;
			this.LabelUltCarro.BackColor = global::System.Drawing.Color.Transparent;
			this.LabelUltCarro.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point);
			this.LabelUltCarro.ForeColor = global::System.Drawing.Color.White;
			this.LabelUltCarro.Location = new global::System.Drawing.Point(873, 854);
			this.LabelUltCarro.Name = "LabelUltCarro";
			this.LabelUltCarro.Size = new global::System.Drawing.Size(107, 21);
			this.LabelUltCarro.TabIndex = 33;
			this.LabelUltCarro.Text = "Último Carro: ";
			this.Tboxjustificativa.BackColor = global::System.Drawing.Color.White;
			this.Tboxjustificativa.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Tboxjustificativa.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point);
			this.Tboxjustificativa.ForeColor = global::System.Drawing.Color.Black;
			this.Tboxjustificativa.Location = new global::System.Drawing.Point(873, 86);
			this.Tboxjustificativa.Name = "Tboxjustificativa";
			this.Tboxjustificativa.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.Tboxjustificativa.Size = new global::System.Drawing.Size(500, 29);
			this.Tboxjustificativa.TabIndex = 40;
			this.TBoxAlarmesdiag.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.TBoxAlarmesdiag.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.TBoxAlarmesdiag.Font = new global::System.Drawing.Font("Segoe UI", 18f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point);
			this.TBoxAlarmesdiag.ForeColor = global::System.Drawing.Color.White;
			this.TBoxAlarmesdiag.Location = new global::System.Drawing.Point(960, 154);
			this.TBoxAlarmesdiag.Name = "TBoxAlarmesdiag";
			this.TBoxAlarmesdiag.ReadOnly = true;
			this.TBoxAlarmesdiag.Size = new global::System.Drawing.Size(330, 32);
			this.TBoxAlarmesdiag.TabIndex = 39;
			this.TBoxAlarmesdiag.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.BtnRearmar.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.BtnRearmar.Enabled = false;
			this.BtnRearmar.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.BtnRearmar.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.BtnRearmar.ForeColor = global::System.Drawing.Color.FromArgb(9, 37, 60);
			this.BtnRearmar.Location = new global::System.Drawing.Point(1223, 230);
			this.BtnRearmar.Name = "BtnRearmar";
			this.BtnRearmar.Size = new global::System.Drawing.Size(150, 50);
			this.BtnRearmar.TabIndex = 38;
			this.BtnRearmar.Text = "Rearmar";
			this.BtnRearmar.UseVisualStyleBackColor = false;
			this.BtnRearmar.Click += new global::System.EventHandler(this.BtnRearmar_Click);
			this.BtnSalvar.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.BtnSalvar.Enabled = false;
			this.BtnSalvar.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.BtnSalvar.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.BtnSalvar.ForeColor = global::System.Drawing.Color.FromArgb(9, 37, 60);
			this.BtnSalvar.Location = new global::System.Drawing.Point(873, 230);
			this.BtnSalvar.Name = "BtnSalvar";
			this.BtnSalvar.Size = new global::System.Drawing.Size(150, 50);
			this.BtnSalvar.TabIndex = 37;
			this.BtnSalvar.Text = "Salvar";
			this.BtnSalvar.UseVisualStyleBackColor = false;
			this.BtnSalvar.Click += new global::System.EventHandler(this.BtnSalvar_Click);
			this.ListaAlarmesAtivos.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.ListaAlarmesAtivos.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.ListaAlarmesAtivos.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[] { this.IDativo, this.Descricaoativo, this.HAtivo });
			this.ListaAlarmesAtivos.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point);
			this.ListaAlarmesAtivos.ForeColor = global::System.Drawing.Color.White;
			this.ListaAlarmesAtivos.FullRowSelect = true;
			this.ListaAlarmesAtivos.HideSelection = false;
			this.ListaAlarmesAtivos.Items.AddRange(new global::System.Windows.Forms.ListViewItem[] { listViewItem2 });
			this.ListaAlarmesAtivos.Location = new global::System.Drawing.Point(861, 340);
			this.ListaAlarmesAtivos.Name = "ListaAlarmesAtivos";
			this.ListaAlarmesAtivos.Size = new global::System.Drawing.Size(522, 458);
			this.ListaAlarmesAtivos.TabIndex = 41;
			this.ListaAlarmesAtivos.UseCompatibleStateImageBehavior = false;
			this.ListaAlarmesAtivos.View = global::System.Windows.Forms.View.Details;
			this.IDativo.Text = "ID";
			this.Descricaoativo.Text = "Descrição";
			this.Descricaoativo.Width = 310;
			this.HAtivo.Text = "Hora Ativo";
			this.HAtivo.Width = 120;
			this.ListaAlarmes.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.ListaAlarmes.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.ListaAlarmes.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[] { this.ID, this.Descriçao, this.Estado });
			this.ListaAlarmes.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point);
			this.ListaAlarmes.ForeColor = global::System.Drawing.Color.White;
			this.ListaAlarmes.FullRowSelect = true;
			this.ListaAlarmes.HideSelection = false;
			this.ListaAlarmes.Items.AddRange(new global::System.Windows.Forms.ListViewItem[] { listViewItem3 });
			this.ListaAlarmes.Location = new global::System.Drawing.Point(1403, 73);
			this.ListaAlarmes.Name = "ListaAlarmes";
			this.ListaAlarmes.Size = new global::System.Drawing.Size(502, 960);
			this.ListaAlarmes.TabIndex = 42;
			this.ListaAlarmes.UseCompatibleStateImageBehavior = false;
			this.ListaAlarmes.View = global::System.Windows.Forms.View.Details;
			this.ID.Text = "ID";
			this.Descriçao.Text = "Descriçao";
			this.Descriçao.Width = 360;
			this.Estado.Text = "Estado";
			this.pictureBox1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = (global::System.Drawing.Image)resources.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(1880, 1);
			this.pictureBox1.Margin = new global::System.Windows.Forms.Padding(0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(35, 35);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 43;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.textBox1.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.textBox1.Enabled = false;
			this.textBox1.Location = new global::System.Drawing.Point(0, 0);
			this.textBox1.MaximumSize = new global::System.Drawing.Size(0, 30);
			this.textBox1.MinimumSize = new global::System.Drawing.Size(0, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new global::System.Drawing.Size(1920, 40);
			this.textBox1.TabIndex = 57;
			this.textBox4.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.textBox4.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBox4.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.textBox4.Enabled = false;
			this.textBox4.Location = new global::System.Drawing.Point(1917, 40);
			this.textBox4.MaximumSize = new global::System.Drawing.Size(3, 1920);
			this.textBox4.MinimumSize = new global::System.Drawing.Size(3, 1920);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new global::System.Drawing.Size(3, 16);
			this.textBox4.TabIndex = 60;
			this.textBox5.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.textBox5.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBox5.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.textBox5.Enabled = false;
			this.textBox5.Location = new global::System.Drawing.Point(0, 1077);
			this.textBox5.MaximumSize = new global::System.Drawing.Size(0, 3);
			this.textBox5.MinimumSize = new global::System.Drawing.Size(0, 3);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new global::System.Drawing.Size(1917, 3);
			this.textBox5.TabIndex = 61;
			this.textBox3.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.textBox3.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.textBox3.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBox3.Enabled = false;
			this.textBox3.Location = new global::System.Drawing.Point(0, 0);
			this.textBox3.MaximumSize = new global::System.Drawing.Size(4, 1920);
			this.textBox3.MinimumSize = new global::System.Drawing.Size(4, 1920);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new global::System.Drawing.Size(4, 16);
			this.textBox3.TabIndex = 62;
			this.pictureBox2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.pictureBox2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBox2.Image = (global::System.Drawing.Image)resources.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new global::System.Drawing.Point(1850, 1);
			this.pictureBox2.Margin = new global::System.Windows.Forms.Padding(0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(35, 35);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 63;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new global::System.EventHandler(this.pictureBox2_Click);
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.label2.Location = new global::System.Drawing.Point(873, 128);
			this.label2.MinimumSize = new global::System.Drawing.Size(500, 90);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(500, 90);
			this.label2.TabIndex = 64;
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(68, 180, 74);
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.button1.ForeColor = global::System.Drawing.Color.FromArgb(9, 37, 60);
			this.button1.Location = new global::System.Drawing.Point(10, 800);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(150, 40);
			this.button1.TabIndex = 192;
			this.button1.Text = "Recarregar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = (global::System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			base.ClientSize = new global::System.Drawing.Size(1920, 1080);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.textBox3);
			base.Controls.Add(this.textBox5);
			base.Controls.Add(this.textBox4);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.ListaAlarmes);
			base.Controls.Add(this.ListaAlarmesAtivos);
			base.Controls.Add(this.Tboxjustificativa);
			base.Controls.Add(this.TBoxAlarmesdiag);
			base.Controls.Add(this.BtnRearmar);
			base.Controls.Add(this.BtnSalvar);
			base.Controls.Add(this.BtnAtualizarCarro);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.TBoxAtualizaCarro);
			base.Controls.Add(this.LabelUltCarro);
			base.Controls.Add(this.ListaJustificava);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.Comunicacao);
			base.Controls.Add(this.BtnAlarme);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.label2);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FrmAlarmes1920x1080";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Alarme";
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.FrmAlarmes_FormClosing);
			base.Load += new global::System.EventHandler(this.FrmAlarmes_Load);
			base.Shown += new global::System.EventHandler(this.FrmAlarmes_Shown);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400001B RID: 27
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Button BtnAlarme;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.Label Comunicacao;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.ListView ListaJustificava;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.ColumnHeader IDHistorico;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.ColumnHeader ColDescrição;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.ColumnHeader Datadesligado;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.ColumnHeader ResponsavelHistorico;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Button BtnAtualizarCarro;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.TextBox TBoxAtualizaCarro;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Label LabelUltCarro;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.ComboBox Tboxjustificativa;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.TextBox TBoxAlarmesdiag;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.Button BtnRearmar;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.Button BtnSalvar;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.ListView ListaAlarmesAtivos;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.ColumnHeader IDativo;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.ColumnHeader Descricaoativo;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.ColumnHeader HAtivo;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.ListView ListaAlarmes;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.ColumnHeader ID;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.ColumnHeader Descriçao;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.ColumnHeader Estado;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.TextBox textBox4;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.TextBox textBox5;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.TextBox textBox3;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.ColumnHeader DataLigado;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.Button button1;
	}
}
