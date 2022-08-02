using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace AnemoAPI
{
	// Token: 0x0200000F RID: 15
	internal class DLLInjection
	{
		// Token: 0x0200001C RID: 28
		public enum DllInjectionResult
		{
			// Token: 0x0400008C RID: 140
			DllNotFound,
			// Token: 0x0400008D RID: 141
			GameProcessNotFound,
			// Token: 0x0400008E RID: 142
			InjectionFailed,
			// Token: 0x0400008F RID: 143
			Success
		}

		// Token: 0x0200001D RID: 29
		public sealed class DllInjector
		{
			// Token: 0x17000008 RID: 8
			// (get) Token: 0x060000CD RID: 205 RVA: 0x0000819C File Offset: 0x0000639C
			public static DLLInjection.DllInjector GetInstance
			{
				get
				{
					if (DLLInjection.DllInjector._instance == null)
					{
						DLLInjection.DllInjector._instance = new DLLInjection.DllInjector();
					}
					return DLLInjection.DllInjector._instance;
				}
			}

			// Token: 0x060000CF RID: 207 RVA: 0x000081C8 File Offset: 0x000063C8
			private DllInjector()
			{
			}

			// Token: 0x060000D0 RID: 208 RVA: 0x000081D0 File Offset: 0x000063D0
			private bool bInject(uint pToBeInjected, string sDllPath)
			{
				IntPtr intPtr = DLLInjection.DllInjector.OpenProcess(1082U, 1, pToBeInjected);
				if (intPtr == DLLInjection.DllInjector.INTPTR_ZERO)
				{
					return false;
				}
				IntPtr procAddress = DLLInjection.DllInjector.GetProcAddress(DLLInjection.DllInjector.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
				if (procAddress == DLLInjection.DllInjector.INTPTR_ZERO)
				{
					return false;
				}
				IntPtr intPtr2 = DLLInjection.DllInjector.VirtualAllocEx(intPtr, (IntPtr)0, (IntPtr)sDllPath.Length, 12288U, 64U);
				if (intPtr2 == DLLInjection.DllInjector.INTPTR_ZERO)
				{
					return false;
				}
				byte[] bytes = Encoding.ASCII.GetBytes(sDllPath);
				if (DLLInjection.DllInjector.WriteProcessMemory(intPtr, intPtr2, bytes, (uint)bytes.Length, 0) == 0)
				{
					return false;
				}
				if (DLLInjection.DllInjector.CreateRemoteThread(intPtr, (IntPtr)0, DLLInjection.DllInjector.INTPTR_ZERO, procAddress, intPtr2, 0U, (IntPtr)0) == DLLInjection.DllInjector.INTPTR_ZERO)
				{
					return false;
				}
				DLLInjection.DllInjector.CloseHandle(intPtr);
				return true;
			}

			// Token: 0x060000D1 RID: 209
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern int CloseHandle(IntPtr hObject);

			// Token: 0x060000D2 RID: 210
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttribute, IntPtr dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

			// Token: 0x060000D3 RID: 211
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern IntPtr GetModuleHandle(string lpModuleName);

			// Token: 0x060000D4 RID: 212
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

			// Token: 0x060000D5 RID: 213 RVA: 0x000082AC File Offset: 0x000064AC
			public DLLInjection.DllInjectionResult Inject(string sProcName, string sDllPath)
			{
				if (!File.Exists(sDllPath))
				{
					return DLLInjection.DllInjectionResult.DllNotFound;
				}
				uint num = 0U;
				Process[] processes = Process.GetProcesses();
				for (int i = 0; i < processes.Length; i++)
				{
					if (!(processes[i].ProcessName != sProcName))
					{
						num = (uint)processes[i].Id;
						break;
					}
				}
				if (num == 0U)
				{
					return DLLInjection.DllInjectionResult.GameProcessNotFound;
				}
				if (!this.bInject(num, sDllPath))
				{
					return DLLInjection.DllInjectionResult.InjectionFailed;
				}
				return DLLInjection.DllInjectionResult.Success;
			}

			// Token: 0x060000D6 RID: 214
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

			// Token: 0x060000D7 RID: 215
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, uint flProtect);

			// Token: 0x060000D8 RID: 216
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, int lpNumberOfBytesWritten);

			// Token: 0x04000090 RID: 144
			private static readonly IntPtr INTPTR_ZERO = (IntPtr)0;

			// Token: 0x04000091 RID: 145
			private static DLLInjection.DllInjector _instance;
		}
	}
}
