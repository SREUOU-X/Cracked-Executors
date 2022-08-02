using System;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CheatSquadAPI
{
	// Token: 0x02000010 RID: 16
	public class Module
	{
		// Token: 0x0600005D RID: 93 RVA: 0x000069C0 File Offset: 0x00004BC0
		private bool CheckForUpdates()
		{
			try
			{
				using (WebClient webClient = new WebClient())
				{
					if (!webClient.DownloadString("https://raw.githubusercontent.com/GianOfficial/CheatSquadAPI/master/Host").Contains("Updated https://github.com/GianOfficial/CheatSquadAPI/raw/master/csapi.dll"))
					{
						MessageBox.Show("CheatSquadAPI is down/patch for a moment, Please try again later.", "CheatSquadAPI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return false;
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Cannot read our host, Please check your internet connection.", "CheatSquadAPI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			return true;
		}

		// Token: 0x0600005E RID: 94
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool WaitNamedPipe(string name, int timeout);

		// Token: 0x0600005F RID: 95 RVA: 0x00006A58 File Offset: 0x00004C58
		private static bool NamedPipeExist(string pipeName)
		{
			bool result;
			try
			{
				if (!Module.WaitNamedPipe("\\\\.\\pipe\\" + pipeName, 0))
				{
					int lastWin32Error = Marshal.GetLastWin32Error();
					if (lastWin32Error == 0)
					{
						return false;
					}
					if (lastWin32Error == 2)
					{
						return false;
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

		// Token: 0x06000060 RID: 96 RVA: 0x00006AC8 File Offset: 0x00004CC8
		private static void LuaPipe(string ScriptToString)
		{
			if (Module.NamedPipeExist(Module.EntryPointPipe))
			{
				new Thread(delegate()
				{
					try
					{
						using (NamedPipeClientStream namedPipeClientStream = new NamedPipeClientStream(".", Module.EntryPointPipe, PipeDirection.Out))
						{
							namedPipeClientStream.Connect();
							using (StreamWriter streamWriter = new StreamWriter(namedPipeClientStream, Encoding.Default, 999999))
							{
								streamWriter.Write(ScriptToString);
								streamWriter.Dispose();
							}
							namedPipeClientStream.Dispose();
						}
					}
					catch (Exception)
					{
						MessageBox.Show("Failed to connect pipe on csapi", "CheatSquadAPI Exception Handler", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}).Start();
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00006B0C File Offset: 0x00004D0C
		public void Execute(string csstring)
		{
			Module.LuaPipe(csstring);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00006B14 File Offset: 0x00004D14
		public void Attach()
		{
			this.Inject();
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00006B20 File Offset: 0x00004D20
		private bool Inject()
		{
			if (Module.NamedPipeExist(Module.EntryPointPipe))
			{
				MessageBox.Show("The proccess is already attached.", "CheatSquadAPI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (this.CheckForUpdates())
			{
				using (WebClient webClient = new WebClient())
				{
					if (File.Exists("csapi.dll"))
					{
						File.Delete("csapi.dll");
					}
					webClient.DownloadFile("https://github.com/GianOfficial/CheatSquadAPI/raw/master/csapi.dll", "csapi.dll");
					Module.APIInjector.Result result = Module.APIInjector.GetInstance.Inject("RobloxPlayerBeta", AppDomain.CurrentDomain.BaseDirectory + Module.EntryPointDLL);
					if (result != Module.APIInjector.Result.RobloxNotFound)
					{
						if (result == Module.APIInjector.Result.AttachFailed)
						{
							MessageBox.Show("Failed to attach CheatSquadAPI.", "CheatSquadAPI", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						}
					}
					else
					{
						MessageBox.Show("Please open roblox to attach the exploit.", "CheatSquadAPI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
					Module.NamedPipeExist(Module.EntryPointPipe);
				}
				return File.Exists("csapi.dll");
			}
			return true;
		}

		// Token: 0x04000061 RID: 97
		private WebClient CSClientHost = new WebClient();

		// Token: 0x04000062 RID: 98
		public static string EntryPointPipe = "taStqdau1Ch1ee33";

		// Token: 0x04000063 RID: 99
		public static string EntryPointDLL = "csapi.dll";

		// Token: 0x0200001E RID: 30
		public sealed class APIInjector
		{
			// Token: 0x060000D9 RID: 217
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

			// Token: 0x060000DA RID: 218
			[DllImport("kernel32.dll")]
			public static extern IntPtr OpenProcessB(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

			// Token: 0x060000DB RID: 219
			[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
			public static extern IntPtr GetModuleHandle(string lpModuleName);

			// Token: 0x060000DC RID: 220
			[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
			private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

			// Token: 0x060000DD RID: 221
			[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
			private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, int flAllocationType, int flProtect);

			// Token: 0x060000DE RID: 222
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer, int nSize, out UIntPtr lpNumberOfBytesWritten);

			// Token: 0x060000DF RID: 223
			[DllImport("kernel32.dll")]
			public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

			// Token: 0x060000E0 RID: 224
			[DllImport("kernel32.dll")]
			private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, int dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, int dwCreationFlags, out IntPtr lpThreadId);

			// Token: 0x060000E1 RID: 225
			[DllImport("kernel32.dll")]
			private static extern IntPtr GetLastError();

			// Token: 0x060000E2 RID: 226
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern int CloseHandle(IntPtr hObject);

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x060000E3 RID: 227 RVA: 0x0000832C File Offset: 0x0000652C
			public static Module.APIInjector GetInstance
			{
				get
				{
					if (Module.APIInjector.Instance == null)
					{
						Module.APIInjector.Instance = new Module.APIInjector();
					}
					return Module.APIInjector.Instance;
				}
			}

			// Token: 0x060000E4 RID: 228 RVA: 0x0000834C File Offset: 0x0000654C
			private APIInjector()
			{
			}

			// Token: 0x060000E5 RID: 229 RVA: 0x00008354 File Offset: 0x00006554
			public Module.APIInjector.Result Inject(string Roblox, string DLLEntryPointPath)
			{
				Module.APIInjector.Result result;
				if (!File.Exists(DLLEntryPointPath))
				{
					result = Module.APIInjector.Result.RobloxNotFound;
				}
				else
				{
					uint num = 0U;
					Process[] processes = Process.GetProcesses();
					for (int i = 0; i < processes.Length; i++)
					{
						if (processes[i].ProcessName == Roblox)
						{
							num = (uint)processes[i].Id;
							break;
						}
					}
					if (num == 0U)
					{
						result = Module.APIInjector.Result.RobloxNotFound;
					}
					else if (!this.LoadLibrary(num, DLLEntryPointPath))
					{
						result = Module.APIInjector.Result.AttachFailed;
					}
					else
					{
						result = Module.APIInjector.Result.Attached;
					}
				}
				return result;
			}

			// Token: 0x060000E6 RID: 230 RVA: 0x000083E8 File Offset: 0x000065E8
			public static bool LoadLibraryB(string procId, string dllPath)
			{
				if (!File.Exists(dllPath))
				{
					return false;
				}
				IntPtr intPtr = Module.APIInjector.OpenProcessB(1082, true, int.Parse(procId));
				if (intPtr == (IntPtr)null)
				{
					return false;
				}
				IntPtr procAddress = Module.APIInjector.GetProcAddress(Module.APIInjector.GetModuleHandle("Kernel32"), "LoadLibraryW");
				if (procAddress == (IntPtr)null)
				{
					return false;
				}
				IntPtr lpBuffer = Marshal.StringToHGlobalUni(dllPath);
				int byteCount = Encoding.Unicode.GetByteCount(dllPath);
				IntPtr intPtr2 = Module.APIInjector.VirtualAllocEx(intPtr, IntPtr.Zero, byteCount, 12288, 4);
				if (intPtr2 == (IntPtr)null)
				{
					return false;
				}
				UIntPtr value = (UIntPtr)null;
				IntPtr intPtr3;
				return Module.APIInjector.WriteProcessMemory(intPtr, intPtr2, lpBuffer, byteCount, out value) && !(value == (UIntPtr)null) && !(Module.APIInjector.CreateRemoteThread(intPtr, IntPtr.Zero, 0, procAddress, intPtr2, 0, out intPtr3) == IntPtr.Zero);
			}

			// Token: 0x060000E7 RID: 231 RVA: 0x000084E4 File Offset: 0x000066E4
			private bool LoadLibrary(uint RobloxProcess, string EntryPointDLLPath)
			{
				if (!File.Exists(EntryPointDLLPath))
				{
					return false;
				}
				IntPtr intPtr = Module.APIInjector.OpenProcess(1082U, 1, RobloxProcess);
				if (intPtr == (IntPtr)null)
				{
					return false;
				}
				IntPtr procAddress = Module.APIInjector.GetProcAddress(Module.APIInjector.GetModuleHandle("Kernel32"), "LoadLibraryW");
				if (procAddress == (IntPtr)null)
				{
					return false;
				}
				IntPtr lpBuffer = Marshal.StringToHGlobalUni(EntryPointDLLPath);
				int byteCount = Encoding.Unicode.GetByteCount(EntryPointDLLPath);
				IntPtr intPtr2 = Module.APIInjector.VirtualAllocEx(intPtr, IntPtr.Zero, byteCount, 12288, 4);
				if (intPtr2 == (IntPtr)null)
				{
					return false;
				}
				UIntPtr value = (UIntPtr)null;
				IntPtr intPtr3;
				return Module.APIInjector.WriteProcessMemory(intPtr, intPtr2, lpBuffer, byteCount, out value) && !(value == (UIntPtr)null) && !(Module.APIInjector.CreateRemoteThread(intPtr, IntPtr.Zero, 0, procAddress, intPtr2, 0, out intPtr3) == IntPtr.Zero);
			}

			// Token: 0x04000092 RID: 146
			private static readonly IntPtr INTPTR_ZERO = (IntPtr)0;

			// Token: 0x04000093 RID: 147
			private const int PROCESS_CREATE_THREAD = 2;

			// Token: 0x04000094 RID: 148
			private const int PROCESS_QUERY_INFORMATION = 1024;

			// Token: 0x04000095 RID: 149
			private const int PROCESS_VM_OPERATION = 8;

			// Token: 0x04000096 RID: 150
			private const int PROCESS_VM_WRITE = 32;

			// Token: 0x04000097 RID: 151
			private const int PROCESS_VM_READ = 16;

			// Token: 0x04000098 RID: 152
			private const int MEM_COMMIT = 4096;

			// Token: 0x04000099 RID: 153
			private const int MEM_RESERVE = 8192;

			// Token: 0x0400009A RID: 154
			private const int PAGE_READWRITE = 4;

			// Token: 0x0400009B RID: 155
			private static Module.APIInjector Instance;

			// Token: 0x02000026 RID: 38
			public enum Result
			{
				// Token: 0x040000A8 RID: 168
				RobloxNotFound,
				// Token: 0x040000A9 RID: 169
				AttachFailed,
				// Token: 0x040000AA RID: 170
				Attached
			}
		}
	}
}
