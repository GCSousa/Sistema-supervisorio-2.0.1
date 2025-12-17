namespace SupervisorioDana
{
	// Token: 0x02000008 RID: 8
	public partial class FrmEntrada1920x1080 : global::System.Windows.Forms.Form
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x0001099C File Offset: 0x0000EB9C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000109D4 File Offset: 0x0000EBD4
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SupervisorioDana.FrmEntrada1920x1080));
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.TBoxLogin = new global::System.Windows.Forms.TextBox();
			this.TBoxSenha = new global::System.Windows.Forms.TextBox();
			this.BtnConectar = new global::System.Windows.Forms.Button();
			this.LabErro = new global::System.Windows.Forms.Label();
			this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(69, 328);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(63, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Login";
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(68, 409);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(66, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Senha";
			this.TBoxLogin.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.Suggest;
			this.TBoxLogin.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.TBoxLogin.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TBoxLogin.Font = new global::System.Drawing.Font("Segoe UI", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.TBoxLogin.ForeColor = global::System.Drawing.Color.White;
			this.TBoxLogin.Location = new global::System.Drawing.Point(68, 359);
			this.TBoxLogin.Margin = new global::System.Windows.Forms.Padding(10);
			this.TBoxLogin.MaximumSize = new global::System.Drawing.Size(300, 30);
			this.TBoxLogin.MinimumSize = new global::System.Drawing.Size(300, 30);
			this.TBoxLogin.Name = "TBoxLogin";
			this.TBoxLogin.Size = new global::System.Drawing.Size(300, 35);
			this.TBoxLogin.TabIndex = 2;
			this.TBoxLogin.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.TBoxLogin.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.TBoxLogin_MouseClick);
			this.TBoxLogin.TextChanged += new global::System.EventHandler(this.TBoxLogin_TextChanged);
			this.TBoxLogin.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.TBoxLogin_KeyUp);
			this.TBoxSenha.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.TBoxSenha.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TBoxSenha.Font = new global::System.Drawing.Font("Segoe UI", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.TBoxSenha.ForeColor = global::System.Drawing.Color.White;
			this.TBoxSenha.Location = new global::System.Drawing.Point(66, 440);
			this.TBoxSenha.Margin = new global::System.Windows.Forms.Padding(10);
			this.TBoxSenha.MaximumSize = new global::System.Drawing.Size(300, 30);
			this.TBoxSenha.MinimumSize = new global::System.Drawing.Size(300, 30);
			this.TBoxSenha.Name = "TBoxSenha";
			this.TBoxSenha.PasswordChar = '*';
			this.TBoxSenha.Size = new global::System.Drawing.Size(300, 35);
			this.TBoxSenha.TabIndex = 3;
			this.TBoxSenha.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.TBoxSenha.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.TBoxSenha_MouseClick);
			this.TBoxSenha.TextChanged += new global::System.EventHandler(this.TBoxSenha_TextChanged);
			this.TBoxSenha.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.TBoxSenha_KeyUp);
			this.BtnConectar.BackColor = global::System.Drawing.Color.FromArgb(68, 180, 74);
			this.BtnConectar.FlatAppearance.BorderSize = 0;
			this.BtnConectar.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.BtnConectar.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.BtnConectar.ForeColor = global::System.Drawing.Color.FromArgb(9, 37, 60);
			this.BtnConectar.Location = new global::System.Drawing.Point(65, 520);
			this.BtnConectar.Name = "BtnConectar";
			this.BtnConectar.Size = new global::System.Drawing.Size(300, 60);
			this.BtnConectar.TabIndex = 7;
			this.BtnConectar.Text = "Conectar";
			this.BtnConectar.UseVisualStyleBackColor = false;
			this.BtnConectar.Click += new global::System.EventHandler(this.BtnConectar_Click);
			this.LabErro.AutoSize = true;
			this.LabErro.BackColor = global::System.Drawing.Color.Transparent;
			this.LabErro.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.LabErro.ForeColor = global::System.Drawing.Color.Tomato;
			this.LabErro.Location = new global::System.Drawing.Point(67, 485);
			this.LabErro.Name = "LabErro";
			this.LabErro.Size = new global::System.Drawing.Size(0, 21);
			this.LabErro.TabIndex = 8;
			this.linkLabel1.ActiveLinkColor = global::System.Drawing.Color.White;
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.linkLabel1.Font = new global::System.Drawing.Font("Segoe UI", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point);
			this.linkLabel1.LinkColor = global::System.Drawing.Color.FromArgb(68, 180, 74);
			this.linkLabel1.Location = new global::System.Drawing.Point(340, 20);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new global::System.Drawing.Size(74, 30);
			this.linkLabel1.TabIndex = 9;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Fechar";
			this.linkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(96f, 96f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Dpi;
			base.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = global::System.Drawing.Color.FromArgb(9, 37, 61);
			this.BackgroundImage = (global::System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(440, 640);
			base.ControlBox = false;
			base.Controls.Add(this.linkLabel1);
			base.Controls.Add(this.LabErro);
			base.Controls.Add(this.BtnConectar);
			base.Controls.Add(this.TBoxSenha);
			base.Controls.Add(this.TBoxLogin);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FrmEntrada1920x1080";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Hide;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			base.Tag = "ListBox1";
			this.Text = "Login";
			base.TopMost = true;
			base.TransparencyKey = global::System.Drawing.Color.FromArgb(9, 37, 61);
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.Entrada_FormClosing);
			base.Load += new global::System.EventHandler(this.Entrada_Load);
			base.Shown += new global::System.EventHandler(this.FrmEntrada_Shown);
			base.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.Entrada_KeyUp);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000FC RID: 252
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000FD RID: 253
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000FE RID: 254
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000FF RID: 255
		private global::System.Windows.Forms.TextBox TBoxLogin;

		// Token: 0x04000100 RID: 256
		private global::System.Windows.Forms.TextBox TBoxSenha;

		// Token: 0x04000101 RID: 257
		private global::System.Windows.Forms.Button BtnConectar;

		// Token: 0x04000102 RID: 258
		private global::System.Windows.Forms.Label LabErro;

		// Token: 0x04000103 RID: 259
		private global::System.Windows.Forms.LinkLabel linkLabel1;
	}
}
