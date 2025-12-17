using System;
using System.Windows.Forms;

namespace SupervisorioDana
{
	// Token: 0x02000010 RID: 16
	internal static class Program
	{
		// Token: 0x060001A1 RID: 417 RVA: 0x0002C26E File Offset: 0x0002A46E
		[STAThread]
		private static void Main()
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new conferencia_de_resolucao());
		}
	}
}
