using System;
using System.IO;
using System.Runtime.InteropServices;

namespace ScriptHub_v3._4._1b
{
	// Token: 0x02000004 RID: 4
	internal class DllPipes
	{
		// Token: 0x06000006 RID: 6
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool WaitNamedPipe(string name, int timeout);

		// Token: 0x06000007 RID: 7 RVA: 0x00002168 File Offset: 0x00000368
		public static bool NamedPipeExist(string pipeName)
		{
			bool result;
			try
			{
				bool flag = !DllPipes.WaitNamedPipe(Path.GetFullPath(string.Format("\\\\.\\pipe\\{0}", pipeName)), 0);
				if (flag)
				{
					int lastWin32Error = Marshal.GetLastWin32Error();
					int num = lastWin32Error;
					if (num == 0)
					{
						return false;
					}
					if (num == 2)
					{
						return false;
					}
				}
				result = true;
			}
			catch (Exception ex)
			{
				result = false;
			}
			return result;
		}
	}
}
