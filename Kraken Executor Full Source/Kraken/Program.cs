using System;
using System.Windows.Forms;

namespace Kraken
{
	// Token: 0x02000005 RID: 5
	internal static class Program
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00004255 File Offset: 0x00002455
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
