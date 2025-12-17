namespace SupervisorioDana
{
	// Token: 0x0200000D RID: 13
	public partial class FrmConfiguracoes : global::System.Windows.Forms.Form
	{
		// Token: 0x06000147 RID: 327 RVA: 0x0002520C File Offset: 0x0002340C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00025244 File Offset: 0x00023444
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SupervisorioDana.FrmConfiguracoes1920x1080));
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.TBoxSenha = new global::System.Windows.Forms.TextBox();
			this.TBoxNome = new global::System.Windows.Forms.TextBox();
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.RBobservador = new global::System.Windows.Forms.RadioButton();
			this.RBoperador = new global::System.Windows.Forms.RadioButton();
			this.RBsupervisor = new global::System.Windows.Forms.RadioButton();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.label3.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(92, 139);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(90, 17);
			this.label3.TabIndex = 18;
			this.label3.Text = "Alterar Senha";
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(93, 88);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(90, 17);
			this.label2.TabIndex = 17;
			this.label2.Text = "Alterar Nome";
			this.checkBox1.AutoSize = true;
			this.checkBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.checkBox1.Font = new global::System.Drawing.Font("Segoe UI Semibold", 8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.checkBox1.ForeColor = global::System.Drawing.Color.White;
			this.checkBox1.Location = new global::System.Drawing.Point(259, 47);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new global::System.Drawing.Size(123, 17);
			this.checkBox1.TabIndex = 16;
			this.checkBox1.Text = "Criar Novo Usuario";
			this.checkBox1.UseVisualStyleBackColor = false;
			this.checkBox1.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged);
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(74, 38);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(126, 17);
			this.label1.TabIndex = 15;
			this.label1.Text = "Selecione o Usuário";
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(68, 180, 74);
			this.button1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.button1.ForeColor = global::System.Drawing.Color.FromArgb(9, 37, 60);
			this.button1.Location = new global::System.Drawing.Point(34, 196);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(343, 38);
			this.button1.TabIndex = 14;
			this.button1.Text = "Modificar ou Criar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.TBoxSenha.Location = new global::System.Drawing.Point(34, 160);
			this.TBoxSenha.Name = "TBoxSenha";
			this.TBoxSenha.Size = new global::System.Drawing.Size(202, 23);
			this.TBoxSenha.TabIndex = 12;
			this.TBoxNome.Location = new global::System.Drawing.Point(34, 107);
			this.TBoxNome.Name = "TBoxNome";
			this.TBoxNome.Size = new global::System.Drawing.Size(202, 23);
			this.TBoxNome.TabIndex = 11;
			this.comboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new global::System.Drawing.Point(34, 58);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(202, 23);
			this.comboBox1.TabIndex = 10;
			this.comboBox1.SelectedIndexChanged += new global::System.EventHandler(this.comboBox1_SelectedIndexChanged);
			this.textBox1.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.textBox1.Location = new global::System.Drawing.Point(0, 0);
			this.textBox1.MaximumSize = new global::System.Drawing.Size(0, 30);
			this.textBox1.MinimumSize = new global::System.Drawing.Size(0, 30);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new global::System.Drawing.Size(408, 30);
			this.textBox1.TabIndex = 20;
			this.pictureBox1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = (global::System.Drawing.Image)resources.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(373, -3);
			this.pictureBox1.Margin = new global::System.Windows.Forms.Padding(0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(33, 33);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 21;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click_1);
			this.label5.AutoSize = true;
			this.label5.BackColor = global::System.Drawing.Color.FromArgb(56, 79, 97);
			this.label5.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Location = new global::System.Drawing.Point(15, 7);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(71, 17);
			this.label5.TabIndex = 22;
			this.label5.Text = "USUÁRIOS";
			this.RBobservador.AutoSize = true;
			this.RBobservador.BackColor = global::System.Drawing.Color.Transparent;
			this.RBobservador.Font = new global::System.Drawing.Font("Segoe UI Semibold", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.RBobservador.ForeColor = global::System.Drawing.Color.White;
			this.RBobservador.Location = new global::System.Drawing.Point(16, 26);
			this.RBobservador.Name = "RBobservador";
			this.RBobservador.Size = new global::System.Drawing.Size(85, 17);
			this.RBobservador.TabIndex = 23;
			this.RBobservador.TabStop = true;
			this.RBobservador.Text = "Observador";
			this.RBobservador.UseVisualStyleBackColor = false;
			this.RBoperador.AutoSize = true;
			this.RBoperador.BackColor = global::System.Drawing.Color.Transparent;
			this.RBoperador.Font = new global::System.Drawing.Font("Segoe UI Semibold", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.RBoperador.ForeColor = global::System.Drawing.Color.White;
			this.RBoperador.Location = new global::System.Drawing.Point(15, 54);
			this.RBoperador.Name = "RBoperador";
			this.RBoperador.Size = new global::System.Drawing.Size(74, 17);
			this.RBoperador.TabIndex = 24;
			this.RBoperador.TabStop = true;
			this.RBoperador.Text = "Operador";
			this.RBoperador.UseVisualStyleBackColor = false;
			this.RBsupervisor.AutoSize = true;
			this.RBsupervisor.BackColor = global::System.Drawing.Color.Transparent;
			this.RBsupervisor.Font = new global::System.Drawing.Font("Segoe UI Semibold", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point);
			this.RBsupervisor.ForeColor = global::System.Drawing.Color.White;
			this.RBsupervisor.Location = new global::System.Drawing.Point(15, 81);
			this.RBsupervisor.Name = "RBsupervisor";
			this.RBsupervisor.Size = new global::System.Drawing.Size(79, 17);
			this.RBsupervisor.TabIndex = 25;
			this.RBsupervisor.TabStop = true;
			this.RBsupervisor.Text = "Supervisor";
			this.RBsupervisor.UseVisualStyleBackColor = false;
			this.groupBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.RBobservador);
			this.groupBox1.Controls.Add(this.RBsupervisor);
			this.groupBox1.Controls.Add(this.RBoperador);
			this.groupBox1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.ForeColor = global::System.Drawing.Color.White;
			this.groupBox1.Location = new global::System.Drawing.Point(266, 75);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(109, 110);
			this.groupBox1.TabIndex = 26;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Nivel de Acesso";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::SupervisorioDana.Properties.Resources.CONFIGURAÇÕES;
			base.ClientSize = new global::System.Drawing.Size(408, 253);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.checkBox1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.TBoxSenha);
			base.Controls.Add(this.TBoxNome);
			base.Controls.Add(this.comboBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "FrmConfiguracoes";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " ";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.FrmConfiguracoes_FormClosing);
			base.Load += new global::System.EventHandler(this.FrmConfiguracoes_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400022D RID: 557
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400022E RID: 558
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400022F RID: 559
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000230 RID: 560
		private global::System.Windows.Forms.CheckBox checkBox1;

		// Token: 0x04000231 RID: 561
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000232 RID: 562
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000233 RID: 563
		private global::System.Windows.Forms.TextBox TBoxSenha;

		// Token: 0x04000234 RID: 564
		private global::System.Windows.Forms.TextBox TBoxNome;

		// Token: 0x04000235 RID: 565
		private global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x04000236 RID: 566
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000237 RID: 567
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000238 RID: 568
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000239 RID: 569
		private global::System.Windows.Forms.RadioButton RBobservador;

		// Token: 0x0400023A RID: 570
		private global::System.Windows.Forms.RadioButton RBoperador;

		// Token: 0x0400023B RID: 571
		private global::System.Windows.Forms.RadioButton RBsupervisor;

		// Token: 0x0400023C RID: 572
		private global::System.Windows.Forms.GroupBox groupBox1;
	}
}
