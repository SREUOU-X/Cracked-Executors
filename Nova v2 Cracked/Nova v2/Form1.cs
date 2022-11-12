using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Nova_v2
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002074 File Offset: 0x00000274
		private void timer1_Tick(object sender, EventArgs e)
		{
			bool flag = base.Opacity >= 1.0;
			if (flag)
			{
				this.panel1.Width += 2;
				bool flag2 = this.panel1.Width >= 300;
				if (flag2)
				{
					Form2 form = new Form2();
					form.Show();
					base.Hide();
					this.timer1.Stop();
				}
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020EC File Offset: 0x000002EC
		private void Form1_Load(object sender, EventArgs e)
		{
			this.panel1.Width = 0;
			base.Opacity = 0.0;
			this.t1.Interval = 10;
			this.t1.Tick += this.fadeIn;
			this.t1.Start();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000214C File Offset: 0x0000034C
		private void fadeIn(object sender, EventArgs e)
		{
			bool flag = base.Opacity >= 1.0;
			if (flag)
			{
				this.t1.Stop();
			}
			else
			{
				base.Opacity += 0.01;
			}
		}

		// Token: 0x04000001 RID: 1
		private Timer t1 = new Timer();
	}
}
