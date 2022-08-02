using System;
using System.IO;
using System.IO.Pipes;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace ClubDarkAPI
{
	// Token: 0x02000014 RID: 20
	internal class Class3
	{
		// Token: 0x0600006E RID: 110 RVA: 0x00006CD4 File Offset: 0x00004ED4
		public static void LuaPipe(string script)
		{
			if (ExploitAPI.NamedPipeExist(Class3.luapipename))
			{
				new Thread(delegate()
				{
					try
					{
						using (NamedPipeClientStream namedPipeClientStream = new NamedPipeClientStream(".", Class3.luapipename, PipeDirection.Out))
						{
							namedPipeClientStream.Connect();
							using (StreamWriter streamWriter = new StreamWriter(namedPipeClientStream))
							{
								streamWriter.Write(script);
								streamWriter.Dispose();
							}
							namedPipeClientStream.Dispose();
						}
					}
					catch (IOException)
					{
						MessageBox.Show("Error occured connecting to the pipe.", "Connection Failed!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message.ToString());
					}
				}).Start();
				return;
			}
			MessageBox.Show("Inject " + ExploitAPI.exploitdllname + " before Using this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00006D3C File Offset: 0x00004F3C
		public static void RUNURL(string web)
		{
			if (ExploitAPI.NamedPipeExist(Class3.luapipename))
			{
				new Thread(delegate()
				{
					try
					{
						using (NamedPipeClientStream namedPipeClientStream = new NamedPipeClientStream(".", Class3.luapipename, PipeDirection.Out))
						{
							namedPipeClientStream.Connect();
							using (StreamWriter streamWriter = new StreamWriter(namedPipeClientStream))
							{
								streamWriter.Write(new WebClient().DownloadString(web));
								streamWriter.Dispose();
							}
							namedPipeClientStream.Dispose();
						}
					}
					catch (IOException)
					{
						MessageBox.Show("Error occured connecting to the pipe.", "Connection Failed!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message.ToString());
					}
				}).Start();
				return;
			}
			MessageBox.Show("Inject " + ExploitAPI.exploitdllname + " before Using this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x04000067 RID: 103
		public static string luapipename = "zxc";
	}
}
