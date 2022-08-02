using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace ScriptHub_v3._4._1b
{
	// Token: 0x02000005 RID: 5
	internal class BasicInject
	{
		// Token: 0x06000009 RID: 9
		[DllImport("kernel32.dll")]
		public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

		// Token: 0x0600000A RID: 10
		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr GetModuleHandle(string lpModuleName);

		// Token: 0x0600000B RID: 11
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

		// Token: 0x0600000C RID: 12
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

		// Token: 0x0600000D RID: 13
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);

		// Token: 0x0600000E RID: 14
		[DllImport("kernel32.dll")]
		private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

		// Token: 0x0600000F RID: 15 RVA: 0x000021F4 File Offset: 0x000003F4
		public static int InjectDLL(int procId, string dllDir)
		{
			Process processById = Process.GetProcessById(procId);
			IntPtr hProcess = BasicInject.OpenProcess(1082, false, processById.Id);
			IntPtr procAddress = BasicInject.GetProcAddress(BasicInject.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
			IntPtr intPtr = BasicInject.VirtualAllocEx(hProcess, IntPtr.Zero, (uint)((dllDir.Length + 1) * Marshal.SizeOf(typeof(char))), 12288U, 4U);
			UIntPtr uintPtr;
			BasicInject.WriteProcessMemory(hProcess, intPtr, Encoding.Default.GetBytes(dllDir), (uint)((dllDir.Length + 1) * Marshal.SizeOf(typeof(char))), out uintPtr);
			BasicInject.CreateRemoteThread(hProcess, IntPtr.Zero, 0U, procAddress, intPtr, 0U, IntPtr.Zero);
			return 0;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000022AC File Offset: 0x000004AC
		public static BasicInject.MachineType GetDllMachineType(string dllPath)
		{
			FileStream fileStream = new FileStream(dllPath, FileMode.Open, FileAccess.Read);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			fileStream.Seek(60L, SeekOrigin.Begin);
			int num = binaryReader.ReadInt32();
			fileStream.Seek((long)num, SeekOrigin.Begin);
			uint num2 = binaryReader.ReadUInt32();
			bool flag = num2 != 17744U;
			if (flag)
			{
				throw new Exception("Can't find PE header");
			}
			BasicInject.MachineType result = (BasicInject.MachineType)binaryReader.ReadUInt16();
			binaryReader.Close();
			fileStream.Close();
			return result;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002334 File Offset: 0x00000534
		public static bool? UnmanagedDllIs64Bit(string dllPath)
		{
			BasicInject.MachineType dllMachineType = BasicInject.GetDllMachineType(dllPath);
			BasicInject.MachineType machineType = dllMachineType;
			bool? result;
			if (machineType != BasicInject.MachineType.IMAGE_FILE_MACHINE_I386)
			{
				if (machineType != BasicInject.MachineType.IMAGE_FILE_MACHINE_IA64 && machineType != BasicInject.MachineType.IMAGE_FILE_MACHINE_AMD64)
				{
					result = null;
				}
				else
				{
					result = new bool?(true);
				}
			}
			else
			{
				result = new bool?(false);
			}
			return result;
		}

		// Token: 0x04000002 RID: 2
		private const int PROCESS_CREATE_THREAD = 2;

		// Token: 0x04000003 RID: 3
		private const int PROCESS_QUERY_INFORMATION = 1024;

		// Token: 0x04000004 RID: 4
		private const int PROCESS_VM_OPERATION = 8;

		// Token: 0x04000005 RID: 5
		private const int PROCESS_VM_WRITE = 32;

		// Token: 0x04000006 RID: 6
		private const int PROCESS_VM_READ = 16;

		// Token: 0x04000007 RID: 7
		private const uint MEM_COMMIT = 4096U;

		// Token: 0x04000008 RID: 8
		private const uint MEM_RESERVE = 8192U;

		// Token: 0x04000009 RID: 9
		private const uint PAGE_READWRITE = 4U;

		// Token: 0x02000019 RID: 25
		public enum MachineType : ushort
		{
			// Token: 0x04000072 RID: 114
			IMAGE_FILE_MACHINE_UNKNOWN,
			// Token: 0x04000073 RID: 115
			IMAGE_FILE_MACHINE_AM33 = 467,
			// Token: 0x04000074 RID: 116
			IMAGE_FILE_MACHINE_AMD64 = 34404,
			// Token: 0x04000075 RID: 117
			IMAGE_FILE_MACHINE_ARM = 448,
			// Token: 0x04000076 RID: 118
			IMAGE_FILE_MACHINE_EBC = 3772,
			// Token: 0x04000077 RID: 119
			IMAGE_FILE_MACHINE_I386 = 332,
			// Token: 0x04000078 RID: 120
			IMAGE_FILE_MACHINE_IA64 = 512,
			// Token: 0x04000079 RID: 121
			IMAGE_FILE_MACHINE_M32R = 36929,
			// Token: 0x0400007A RID: 122
			IMAGE_FILE_MACHINE_MIPS16 = 614,
			// Token: 0x0400007B RID: 123
			IMAGE_FILE_MACHINE_MIPSFPU = 870,
			// Token: 0x0400007C RID: 124
			IMAGE_FILE_MACHINE_MIPSFPU16 = 1126,
			// Token: 0x0400007D RID: 125
			IMAGE_FILE_MACHINE_POWERPC = 496,
			// Token: 0x0400007E RID: 126
			IMAGE_FILE_MACHINE_POWERPCFP,
			// Token: 0x0400007F RID: 127
			IMAGE_FILE_MACHINE_R4000 = 358,
			// Token: 0x04000080 RID: 128
			IMAGE_FILE_MACHINE_SH3 = 418,
			// Token: 0x04000081 RID: 129
			IMAGE_FILE_MACHINE_SH3DSP,
			// Token: 0x04000082 RID: 130
			IMAGE_FILE_MACHINE_SH4 = 422,
			// Token: 0x04000083 RID: 131
			IMAGE_FILE_MACHINE_SH5 = 424,
			// Token: 0x04000084 RID: 132
			IMAGE_FILE_MACHINE_THUMB = 450,
			// Token: 0x04000085 RID: 133
			IMAGE_FILE_MACHINE_WCEMIPSV2 = 361
		}
	}
}
