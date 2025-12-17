using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SupervisorioDana
{
	// Token: 0x02000003 RID: 3
	public partial class conferencia_de_resolucao : Form
	{
		// Token: 0x06000004 RID: 4 RVA: 0x000021BD File Offset: 0x000003BD
		public conferencia_de_resolucao()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021D5 File Offset: 0x000003D5
		private void conferencia_de_resolucao_Load(object sender, EventArgs e)
		{
			this.resolucaoc = this.verificaresolucao();
			this.abreprimeiratela();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021EC File Offset: 0x000003EC
		private int verificaresolucao()
		{
			double height = (double)SystemInformation.PrimaryMonitorSize.Height;
			double width = (double)SystemInformation.PrimaryMonitorSize.Width;
			bool flag = width == 1920.0 && height == 1080.0;
			int res;
			if (flag)
			{
				res = 1;
			}
			else
			{
				res = 0;
			}
			return res;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000224C File Offset: 0x0000044C
		private void abreprimeiratela()
		{
			bool flag = this.resolucaoc == 1;
			if (flag)
				//if (flag)

				{
					base.Hide();
				FrmEntrada1920x1080 frmEntrada = new FrmEntrada1920x1080();
				frmEntrada.ShowDialog();
			}
			else
			{
				base.Hide();
				FrmEntrada frmEntrada2 = new FrmEntrada();
				frmEntrada2.ShowDialog();
			}
		}

		// Token: 0x04000003 RID: 3
		public int resolucaoc;
	}
}
