using System;
using System.IO;
using System.Windows.Forms;

namespace Kraken
{
	// Token: 0x02000004 RID: 4
	internal class Functions
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00004204 File Offset: 0x00002404
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
