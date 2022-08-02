using System;
using System.IO;
using System.Windows.Controls;

namespace ScriptHub_v3._4._1b
{
	// Token: 0x02000003 RID: 3
	internal class LocalFunctions
	{
		// Token: 0x06000004 RID: 4 RVA: 0x000020D0 File Offset: 0x000002D0
		public static void PopulateListBox(ListBox lsb, string Folder, string FileType)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Folder);
			FileInfo[] files = directoryInfo.GetFiles(FileType);
			int num = 0;
			foreach (FileInfo fileInfo in files)
			{
				string name = fileInfo.Name;
				ListBoxItem listBoxItem = new ListBoxItem();
				listBoxItem.Content = name;
				listBoxItem.ToolTip = new ToolTip
				{
					Content = name
				};
				lsb.Items.Add(listBoxItem);
				num++;
			}
		}
	}
}
