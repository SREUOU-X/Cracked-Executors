using System;
using System.IO;
using System.IO.Pipes;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace AnemoAPI
{
	// Token: 0x0200000E RID: 14
	public class Anemo
	{
		// Token: 0x06000050 RID: 80 RVA: 0x000064F0 File Offset: 0x000046F0
		private string CurrentVersion()
		{
			if (!File.Exists(".versionanemo"))
			{
				File.WriteAllText(".versionanemo", "0");
			}
			return File.ReadAllText(".versionanemo");
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000651C File Offset: 0x0000471C
		private void SetVersion(string NewVer)
		{
			File.WriteAllText(".versionanemo", NewVer);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000652C File Offset: 0x0000472C
		private void Init()
		{
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			this.InitFunction = true;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00006548 File Offset: 0x00004748
		private bool CheckLastestDll()
		{
			if (!this.InitFunction)
			{
				this.Init();
			}
			string[] array = this.wc.DownloadString("https://anemo.solutions/api/Update.txt").Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
			if (!(array[2] != "NO"))
			{
				return false;
			}
			if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Roblox\\Versions\\" + array[3]))
			{
				this.SetVersion(array[3]);
				return true;
			}
			return false;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000065D8 File Offset: 0x000047D8
		private bool CheckDllUpdate()
		{
			if (!this.InitFunction)
			{
				this.Init();
			}
			string[] array = this.wc.DownloadString("https://anemo.solutions/api/Update.txt").Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
			string a = this.CurrentVersion();
			if (a != array[0])
			{
				this.SetVersion(array[0]);
				return true;
			}
			return (a != array[3] && this.CheckLastestDll()) || !File.Exists("AnemoDLL.dll");
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00006670 File Offset: 0x00004870
		private bool DownloadDLL()
		{
			if (!this.InitFunction)
			{
				this.Init();
			}
			string[] array = this.wc.DownloadString("https://anemo.solutions/api/Update.txt").Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
			if (this.CurrentVersion() == array[3] && this.CheckLastestDll())
			{
				this.wc.DownloadFile(array[4], "AnemoDLL.dll");
			}
			else
			{
				this.wc.DownloadFile(array[1], "AnemoDLL.dll");
			}
			return File.Exists("AnemoDLL.dll");
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00006714 File Offset: 0x00004914
		public bool IsInjected()
		{
			return Anemo.namedPipeExist("AnemoPIPE");
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00006720 File Offset: 0x00004920
		public void ExecuteScript(string Script)
		{
			if (Anemo.namedPipeExist("AnemoPIPE"))
			{
				using (NamedPipeClientStream namedPipeClientStream = new NamedPipeClientStream(".", "AnemoPIPE", PipeDirection.Out))
				{
					namedPipeClientStream.Connect();
					using (StreamWriter streamWriter = new StreamWriter(namedPipeClientStream, Encoding.Default, 999999))
					{
						streamWriter.Write(Script);
						streamWriter.Dispose();
					}
					namedPipeClientStream.Dispose();
				}
				return;
			}
			if (File.Exists("AnemoDLL.dll"))
			{
				MessageBox.Show("Please inject!", "AnemoAPI Cant Find Roblox", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000067DC File Offset: 0x000049DC
		public void InjectAnemo()
		{
			if (Anemo.namedPipeExist("AnemoPIPE"))
			{
				MessageBox.Show("Already Injected!", "AnemoAPI", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			if (!this.CheckDllUpdate() && File.Exists("AnemoDLL.dll"))
			{
				DLLInjection.DllInjectionResult dllInjectionResult = DLLInjection.DllInjector.GetInstance.Inject("RobloxPlayerBeta", Application.StartupPath + "\\AnemoDLL.dll");
				if (dllInjectionResult == DLLInjection.DllInjectionResult.Success)
				{
					return;
				}
				switch (dllInjectionResult)
				{
				case DLLInjection.DllInjectionResult.DllNotFound:
					MessageBox.Show("Couldn't find the dll!", "Error: Dll Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				case DLLInjection.DllInjectionResult.GameProcessNotFound:
					MessageBox.Show("No ROBLOX process found!", "Game Process Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				case DLLInjection.DllInjectionResult.InjectionFailed:
					MessageBox.Show("Injection failed!", "Injection Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				default:
					return;
				}
			}
			else
			{
				if (!this.DownloadDLL())
				{
					MessageBox.Show("Cant download the lastest version!", "AnemoAPI", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
				DLLInjection.DllInjectionResult dllInjectionResult2 = DLLInjection.DllInjector.GetInstance.Inject("RobloxPlayerBeta", Application.StartupPath + "\\AnemoDLL.dll");
				if (dllInjectionResult2 == DLLInjection.DllInjectionResult.Success)
				{
					return;
				}
				switch (dllInjectionResult2)
				{
				case DLLInjection.DllInjectionResult.DllNotFound:
					MessageBox.Show("Couldn't find the dll!", "Error: Dll Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				case DLLInjection.DllInjectionResult.GameProcessNotFound:
					MessageBox.Show("No ROBLOX process found!", "Game Process Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				case DLLInjection.DllInjectionResult.InjectionFailed:
					MessageBox.Show("Injection failed!", "Injection Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00006934 File Offset: 0x00004B34
		private static bool namedPipeExist(string pipeName)
		{
			bool result;
			try
			{
				if (!Anemo.WaitNamedPipe(Path.GetFullPath(string.Format("\\\\.\\pipe\\{0}", pipeName)), 0))
				{
					int lastWin32Error = Marshal.GetLastWin32Error();
					if (lastWin32Error == 0)
					{
						result = false;
						return result;
					}
					if (lastWin32Error == 2)
					{
						result = false;
						return result;
					}
				}
				result = true;
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600005A RID: 90
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool WaitNamedPipe(string name, int timeout);

		// Token: 0x0400005F RID: 95
		private WebClient wc = new WebClient();

		// Token: 0x04000060 RID: 96
		private bool InitFunction;
	}
}
