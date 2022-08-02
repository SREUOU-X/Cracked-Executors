using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using FastColoredTextBoxNS;
using Kraken.Properties;
using VisualStudioTabControl;
using WeAreDevs_API;

namespace Kraken
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : Form
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002059 File Offset: 0x00000259
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000207C File Offset: 0x0000027C
		private void Form1_Load(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.txt");
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.lua");
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020BC File Offset: 0x000002BC
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020BF File Offset: 0x000002BF
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020C2 File Offset: 0x000002C2
		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020CD File Offset: 0x000002CD
		private void bunifuImageButton2_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020D7 File Offset: 0x000002D7
		private void panel3_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020DA File Offset: 0x000002DA
		private void bunifuImageButton3_Click(object sender, EventArgs e)
		{
			this.WRD.SendLuaScript(this.fastColoredTextBox1.Text);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020F4 File Offset: 0x000002F4
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020F7 File Offset: 0x000002F7
		private void bunifuImageButton4_Click(object sender, EventArgs e)
		{
			this.WRD.LaunchExploit();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002106 File Offset: 0x00000306
		private void bunifuImageButton6_Click(object sender, EventArgs e)
		{
			this.fastColoredTextBox1.Clear();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002118 File Offset: 0x00000318
		private void bunifuImageButton7_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				openFileDialog.Title = "Open";
				this.fastColoredTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002160 File Offset: 0x00000360
		private void bunifuImageButton5_Click(object sender, EventArgs e)
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

		// Token: 0x0600000F RID: 15 RVA: 0x000021E4 File Offset: 0x000003E4
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.fastColoredTextBox1.Text = File.ReadAllText(string.Format("./Scripts/{0}", this.listBox1.SelectedItem));
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000220D File Offset: 0x0000040D
		private void button1_Click(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.txt");
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.lua");
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000224D File Offset: 0x0000044D
		private void bunifuThinButton21_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002250 File Offset: 0x00000450
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x04000001 RID: 1
		private ExploitAPI WRD = new ExploitAPI();
	}
}
