namespace SupervisorioDana
{
	// Token: 0x0200000A RID: 10
	public partial class Carregando : global::System.Windows.Forms.Form
	{
		// Token: 0x060000DF RID: 223 RVA: 0x0001D8E0 File Offset: 0x0001BAE0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0001D918 File Offset: 0x0001BB18
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SupervisorioDana.Carregando));
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			base.SuspendLayout();
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.BackColor = global::System.Drawing.Color.FromArgb(9, 37, 60);
			this.BackgroundImage = (global::System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			base.ClientSize = new global::System.Drawing.Size(1280, 720);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.ImeMode = global::System.Windows.Forms.ImeMode.On;
			base.Name = "Carregando";
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Show;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			base.TopMost = true;
			base.UseWaitCursor = true;
			base.ResumeLayout(false);
		}

		// Token: 0x0400019B RID: 411
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400019C RID: 412
		private global::System.Windows.Forms.Timer timer1;
	}
}
