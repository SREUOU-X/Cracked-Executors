using System;
using System.Windows.Forms;

namespace Nova_v2
{
	// Token: 0x02000006 RID: 6
	internal static class Program
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00006D81 File Offset: 0x00004F81
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
