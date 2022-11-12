using System;
using System.IO;
using System.Windows.Forms;

namespace Nova_v2
{
	// Token: 0x02000005 RID: 5
	internal class Functions
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00006D30 File Offset: 0x00004F30
		public static void PopulateListBox(ListBox lsb, string Folder, string FileType)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Folder);
			FileInfo[] files = directoryInfo.GetFiles(FileType);
			foreach (FileInfo fileInfo in files)
			{
				lsb.Items.Add(fileInfo.Name);
			}
		}
	}
}
