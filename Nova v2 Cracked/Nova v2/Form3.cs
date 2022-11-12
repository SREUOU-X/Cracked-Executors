using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CefSharp.WinForms;
using FastColoredTextBoxNS;
using Guna.UI2.WinForms;
using Nova_v2.Properties;
using WeAreDevs_API;

namespace Nova_v2
{
	// Token: 0x02000004 RID: 4
	public partial class Form3 : Form
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00003DEA File Offset: 0x00001FEA
		public Form3()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003E10 File Offset: 0x00002010
		private void Form3_Load(object sender, EventArgs e)
		{
			this.browser = new ChromiumWebBrowser("https://beta.hack.chat/", null)
			{
				Dock = DockStyle.Fill,
				Size = new Size(600, 600),
				Location = new Point(200, 200)
			};
			this.fastColoredTextBox1.Language = Language.Lua;
			this.panel7.Controls.Add(this.browser);
			this.listBox1.Items.Clear();
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.txt");
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.lua");
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003EC4 File Offset: 0x000020C4
		private void Form3_Shown(object sender, EventArgs e)
		{
			this.fastColoredTextBox1.Language = Language.Lua;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00003ED4 File Offset: 0x000020D4
		private void panel2_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = this.label2.Text == "2";
			if (flag)
			{
				this.label2.Text = "1";
			}
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003F28 File Offset: 0x00002128
		private void panel2_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003F89 File Offset: 0x00002189
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003F94 File Offset: 0x00002194
		private void guna2Button12_Click(object sender, EventArgs e)
		{
			bool flag = this.label2.Text == "1";
			if (flag)
			{
				base.Height = Screen.PrimaryScreen.WorkingArea.Height;
				base.Width = Screen.PrimaryScreen.WorkingArea.Width;
				base.Location = Screen.PrimaryScreen.WorkingArea.Location;
				this.guna2Elipse1.BorderRadius = 0;
				this.label2.Text = "2";
			}
			else
			{
				bool flag2 = this.label2.Text == "2";
				if (flag2)
				{
					base.Height = 430;
					base.Width = 700;
					base.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - base.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - base.Height) / 2);
					this.guna2Elipse1.BorderRadius = 5;
					this.label2.Text = "1";
				}
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000040BE File Offset: 0x000022BE
		private void guna2Button13_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000040CC File Offset: 0x000022CC
		private void guna2Button17_Click(object sender, EventArgs e)
		{
			bool flag = this.chatlab.Text == "1";
			if (flag)
			{
				this.panel7.Visible = true;
				this.panel7.Location = new Point(44, 44);
				this.chatlab.Text = "2";
			}
			else
			{
				bool flag2 = this.chatlab.Text == "2";
				if (flag2)
				{
					this.panel7.Visible = false;
					this.panel7.Location = new Point(710, 44);
					this.chatlab.Text = "1";
				}
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000417C File Offset: 0x0000237C
		private void guna2Button11_Click(object sender, EventArgs e)
		{
			foreach (Process process in Process.GetProcessesByName("RobloxPlayerBeta"))
			{
				this.ExploitAPI.LaunchExploit();
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000041B8 File Offset: 0x000023B8
		private void guna2Button10_Click(object sender, EventArgs e)
		{
			foreach (Process process in Process.GetProcessesByName("RobloxPlayerBeta"))
			{
				process.Kill();
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000041F0 File Offset: 0x000023F0
		private void guna2Button9_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			bool flag = saveFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(this.fastColoredTextBox1.Text);
					}
				}
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00004274 File Offset: 0x00002474
		private void guna2Button8_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				openFileDialog.Title = "Open";
				this.fastColoredTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000042BA File Offset: 0x000024BA
		private void guna2Button7_Click(object sender, EventArgs e)
		{
			this.fastColoredTextBox1.Clear();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000042C9 File Offset: 0x000024C9
		private void guna2Button6_Click(object sender, EventArgs e)
		{
			this.ExploitAPI.SendLuaScript(this.fastColoredTextBox1.Text);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000042E4 File Offset: 0x000024E4
		private void guna2Button4_Click(object sender, EventArgs e)
		{
			bool flag = this.label7.Text == "1";
			if (flag)
			{
				this.panel4.Location = new Point(44, 43);
				this.panel4.Visible = true;
				this.label7.Text = "2";
			}
			else
			{
				bool flag2 = this.label7.Text == "2";
				if (flag2)
				{
					this.panel4.Visible = false;
					this.label7.Text = "1";
				}
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000437C File Offset: 0x0000257C
		private void guna2Button3_Click(object sender, EventArgs e)
		{
			this.listBox1.Visible = true;
			this.panel3.Visible = true;
			this.panel6.Visible = false;
			this.panel6.Location = new Point(708, 43);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000043C9 File Offset: 0x000025C9
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			this.listBox1.Visible = false;
			this.panel3.Visible = false;
			this.panel6.Visible = true;
			this.panel6.Location = new Point(44, 42);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00004408 File Offset: 0x00002608
		private void timer1_Tick(object sender, EventArgs e)
		{
			bool flag = this.ExploitAPI.isAPIAttached();
			if (flag)
			{
				this.label1.Text = "Nova v2.9 - Attached";
			}
			else
			{
				this.label1.Text = "Nova v2.9 - Waiting";
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000444D File Offset: 0x0000264D
		private void guna2Button14_Click(object sender, EventArgs e)
		{
			Settings.Default.LogCheck = "1";
			Settings.Default.Save();
			Application.Restart();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00004471 File Offset: 0x00002671
		private void panel4_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00004474 File Offset: 0x00002674
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.fastColoredTextBox1.Text = File.ReadAllText(string.Format("./Scripts/{0}", this.listBox1.SelectedItem));
		}

		// Token: 0x04000016 RID: 22
		private ExploitAPI ExploitAPI = new ExploitAPI();

		// Token: 0x04000017 RID: 23
		public ChromiumWebBrowser browser;

		// Token: 0x04000018 RID: 24
		private Point lastPoint;
	}
}
