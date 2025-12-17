namespace SupervisorioDana
{
	// Token: 0x02000002 RID: 2
	public partial class Carregando1920x1080 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020A0 File Offset: 0x000002A0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SupervisorioDana.Carregando1920x1080));
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			base.SuspendLayout();
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.BackColor = global::System.Drawing.Color.FromArgb(9, 37, 60);
			this.BackgroundImage = (global::System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			base.ClientSize = new global::System.Drawing.Size(1920, 1080);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.ImeMode = global::System.Windows.Forms.ImeMode.On;
			base.Name = "Carregando1920x1080";
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Show;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			base.TopMost = true;
			base.UseWaitCursor = true;
			base.ResumeLayout(false);
		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000002 RID: 2
		private global::System.Windows.Forms.Timer timer1;
	}
}
