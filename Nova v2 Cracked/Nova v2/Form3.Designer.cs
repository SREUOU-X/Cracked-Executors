namespace Nova_v2
{
	// Token: 0x02000004 RID: 4
	public partial class Form3 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000029 RID: 41 RVA: 0x000044A0 File Offset: 0x000026A0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000044D8 File Offset: 0x000026D8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Nova_v2.Form3));
			this.panel6 = new global::System.Windows.Forms.Panel();
			this.guna2Button17 = new global::Guna.UI2.WinForms.Guna2Button();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.guna2Elipse1 = new global::Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.guna2Button5 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button15 = new global::Guna.UI2.WinForms.Guna2Button();
			this.label3 = new global::System.Windows.Forms.Label();
			this.guna2Button14 = new global::Guna.UI2.WinForms.Guna2Button();
			this.panel5 = new global::System.Windows.Forms.Panel();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.guna2Button11 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button6 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button9 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button7 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button8 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button10 = new global::Guna.UI2.WinForms.Guna2Button();
			this.panel7 = new global::System.Windows.Forms.Panel();
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.guna2Button4 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button3 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.chatlab = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.guna2Button13 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button12 = new global::Guna.UI2.WinForms.Guna2Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.guna2Button2 = new global::Guna.UI2.WinForms.Guna2Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.fastColoredTextBox1 = new global::FastColoredTextBoxNS.FastColoredTextBox();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.fastColoredTextBox1).BeginInit();
			base.SuspendLayout();
			this.panel6.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panel6.AutoScroll = true;
			this.panel6.Location = new global::System.Drawing.Point(44, 438);
			this.panel6.Name = "panel6";
			this.panel6.Size = new global::System.Drawing.Size(648, 383);
			this.panel6.TabIndex = 33;
			this.panel6.Visible = false;
			this.guna2Button17.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2Button17.Animated = true;
			this.guna2Button17.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button17.BorderRadius = 5;
			this.guna2Button17.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.guna2Button17.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button17.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button17.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button17.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button17.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Button17.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button17.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button17.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("guna2Button17.Image");
			this.guna2Button17.ImageSize = new global::System.Drawing.Size(15, 15);
			this.guna2Button17.IndicateFocus = true;
			this.guna2Button17.Location = new global::System.Drawing.Point(645, 2);
			this.guna2Button17.Name = "guna2Button17";
			this.guna2Button17.Size = new global::System.Drawing.Size(30, 30);
			this.guna2Button17.TabIndex = 12;
			this.guna2Button17.UseTransparentBackground = true;
			this.guna2Button17.Click += new global::System.EventHandler(this.guna2Button17_Click);
			this.timer1.Enabled = true;
			this.timer1.Interval = 10;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.guna2Elipse1.BorderRadius = 5;
			this.guna2Elipse1.TargetControl = this;
			this.panel4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panel4.Controls.Add(this.guna2Button5);
			this.panel4.Controls.Add(this.guna2Button15);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.guna2Button14);
			this.panel4.Controls.Add(this.panel5);
			this.panel4.Location = new global::System.Drawing.Point(706, 43);
			this.panel4.Name = "panel4";
			this.panel4.Size = new global::System.Drawing.Size(648, 346);
			this.panel4.TabIndex = 32;
			this.panel4.Visible = false;
			this.panel4.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
			this.guna2Button5.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2Button5.Animated = true;
			this.guna2Button5.BorderColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.guna2Button5.BorderRadius = 3;
			this.guna2Button5.BorderThickness = 1;
			this.guna2Button5.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.guna2Button5.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button5.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button5.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button5.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button5.Enabled = false;
			this.guna2Button5.FillColor = global::System.Drawing.Color.FromArgb(10, 16, 21);
			this.guna2Button5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f);
			this.guna2Button5.ForeColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button5.Location = new global::System.Drawing.Point(471, 315);
			this.guna2Button5.Name = "guna2Button5";
			this.guna2Button5.Size = new global::System.Drawing.Size(173, 28);
			this.guna2Button5.TabIndex = 17;
			this.guna2Button5.Text = "Delete Account";
			this.guna2Button15.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2Button15.Animated = true;
			this.guna2Button15.BorderColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.guna2Button15.BorderRadius = 3;
			this.guna2Button15.BorderThickness = 1;
			this.guna2Button15.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.guna2Button15.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button15.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button15.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button15.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button15.Enabled = false;
			this.guna2Button15.FillColor = global::System.Drawing.Color.FromArgb(10, 16, 21);
			this.guna2Button15.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f);
			this.guna2Button15.ForeColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button15.Location = new global::System.Drawing.Point(292, 315);
			this.guna2Button15.Name = "guna2Button15";
			this.guna2Button15.Size = new global::System.Drawing.Size(173, 28);
			this.guna2Button15.TabIndex = 16;
			this.guna2Button15.Text = "Delete Account";
			this.label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.label3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label3.Font = new global::System.Drawing.Font("Consolas", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.DarkGray;
			this.label3.Location = new global::System.Drawing.Point(5, 315);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(99, 20);
			this.label3.TabIndex = 15;
			this.label3.Text = "About";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.guna2Button14.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.guna2Button14.Animated = true;
			this.guna2Button14.BorderColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.guna2Button14.BorderRadius = 3;
			this.guna2Button14.BorderThickness = 1;
			this.guna2Button14.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.guna2Button14.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button14.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button14.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button14.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button14.FillColor = global::System.Drawing.Color.FromArgb(10, 16, 21);
			this.guna2Button14.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f);
			this.guna2Button14.ForeColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button14.Location = new global::System.Drawing.Point(113, 315);
			this.guna2Button14.Name = "guna2Button14";
			this.guna2Button14.Size = new global::System.Drawing.Size(173, 28);
			this.guna2Button14.TabIndex = 14;
			this.guna2Button14.Text = "Logout";
			this.guna2Button14.Click += new global::System.EventHandler(this.guna2Button14_Click);
			this.panel5.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.panel5.BackColor = global::System.Drawing.Color.White;
			this.panel5.Location = new global::System.Drawing.Point(108, 1);
			this.panel5.Name = "panel5";
			this.panel5.Size = new global::System.Drawing.Size(1, 345);
			this.panel5.TabIndex = 4;
			this.panel3.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panel3.BackColor = global::System.Drawing.Color.FromArgb(15, 20, 35);
			this.panel3.Controls.Add(this.guna2Button17);
			this.panel3.Controls.Add(this.guna2Button11);
			this.panel3.Controls.Add(this.guna2Button6);
			this.panel3.Controls.Add(this.guna2Button9);
			this.panel3.Controls.Add(this.guna2Button7);
			this.panel3.Controls.Add(this.guna2Button8);
			this.panel3.Controls.Add(this.guna2Button10);
			this.panel3.Location = new global::System.Drawing.Point(20, 394);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(680, 38);
			this.panel3.TabIndex = 30;
			this.guna2Button11.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.guna2Button11.Animated = true;
			this.guna2Button11.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button11.BorderRadius = 5;
			this.guna2Button11.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.guna2Button11.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button11.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button11.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button11.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button11.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Button11.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button11.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button11.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("guna2Button11.Image");
			this.guna2Button11.ImageSize = new global::System.Drawing.Size(15, 15);
			this.guna2Button11.IndicateFocus = true;
			this.guna2Button11.Location = new global::System.Drawing.Point(204, 2);
			this.guna2Button11.Name = "guna2Button11";
			this.guna2Button11.Size = new global::System.Drawing.Size(30, 30);
			this.guna2Button11.TabIndex = 11;
			this.guna2Button11.UseTransparentBackground = true;
			this.guna2Button11.Click += new global::System.EventHandler(this.guna2Button11_Click);
			this.guna2Button6.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.guna2Button6.Animated = true;
			this.guna2Button6.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button6.BorderRadius = 5;
			this.guna2Button6.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.guna2Button6.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button6.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button6.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button6.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button6.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Button6.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button6.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button6.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("guna2Button6.Image");
			this.guna2Button6.ImageSize = new global::System.Drawing.Size(15, 15);
			this.guna2Button6.IndicateFocus = true;
			this.guna2Button6.Location = new global::System.Drawing.Point(24, 2);
			this.guna2Button6.Name = "guna2Button6";
			this.guna2Button6.Size = new global::System.Drawing.Size(30, 30);
			this.guna2Button6.TabIndex = 6;
			this.guna2Button6.UseTransparentBackground = true;
			this.guna2Button6.Click += new global::System.EventHandler(this.guna2Button6_Click);
			this.guna2Button9.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.guna2Button9.Animated = true;
			this.guna2Button9.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button9.BorderRadius = 5;
			this.guna2Button9.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.guna2Button9.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button9.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button9.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button9.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button9.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Button9.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button9.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button9.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("guna2Button9.Image");
			this.guna2Button9.ImageSize = new global::System.Drawing.Size(15, 15);
			this.guna2Button9.IndicateFocus = true;
			this.guna2Button9.Location = new global::System.Drawing.Point(132, 2);
			this.guna2Button9.Name = "guna2Button9";
			this.guna2Button9.Size = new global::System.Drawing.Size(30, 30);
			this.guna2Button9.TabIndex = 9;
			this.guna2Button9.UseTransparentBackground = true;
			this.guna2Button9.Click += new global::System.EventHandler(this.guna2Button9_Click);
			this.guna2Button7.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.guna2Button7.Animated = true;
			this.guna2Button7.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button7.BorderRadius = 5;
			this.guna2Button7.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.guna2Button7.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button7.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button7.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button7.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button7.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Button7.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button7.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button7.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("guna2Button7.Image");
			this.guna2Button7.IndicateFocus = true;
			this.guna2Button7.Location = new global::System.Drawing.Point(60, 2);
			this.guna2Button7.Name = "guna2Button7";
			this.guna2Button7.Size = new global::System.Drawing.Size(30, 30);
			this.guna2Button7.TabIndex = 7;
			this.guna2Button7.UseTransparentBackground = true;
			this.guna2Button7.Click += new global::System.EventHandler(this.guna2Button7_Click);
			this.guna2Button8.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.guna2Button8.Animated = true;
			this.guna2Button8.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button8.BorderRadius = 5;
			this.guna2Button8.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.guna2Button8.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button8.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button8.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button8.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button8.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Button8.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button8.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button8.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("guna2Button8.Image");
			this.guna2Button8.ImageSize = new global::System.Drawing.Size(15, 15);
			this.guna2Button8.IndicateFocus = true;
			this.guna2Button8.Location = new global::System.Drawing.Point(96, 2);
			this.guna2Button8.Name = "guna2Button8";
			this.guna2Button8.Size = new global::System.Drawing.Size(30, 30);
			this.guna2Button8.TabIndex = 8;
			this.guna2Button8.UseTransparentBackground = true;
			this.guna2Button8.Click += new global::System.EventHandler(this.guna2Button8_Click);
			this.guna2Button10.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.guna2Button10.Animated = true;
			this.guna2Button10.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button10.BorderRadius = 5;
			this.guna2Button10.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.guna2Button10.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button10.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button10.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button10.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button10.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Button10.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button10.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button10.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("guna2Button10.Image");
			this.guna2Button10.ImageSize = new global::System.Drawing.Size(15, 15);
			this.guna2Button10.IndicateFocus = true;
			this.guna2Button10.Location = new global::System.Drawing.Point(168, 2);
			this.guna2Button10.Name = "guna2Button10";
			this.guna2Button10.Size = new global::System.Drawing.Size(30, 30);
			this.guna2Button10.TabIndex = 10;
			this.guna2Button10.UseTransparentBackground = true;
			this.guna2Button10.Click += new global::System.EventHandler(this.guna2Button10_Click);
			this.panel7.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panel7.Location = new global::System.Drawing.Point(710, 45);
			this.panel7.Name = "panel7";
			this.panel7.Size = new global::System.Drawing.Size(651, 344);
			this.panel7.TabIndex = 34;
			this.listBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.listBox1.BackColor = global::System.Drawing.Color.FromArgb(15, 20, 35);
			this.listBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.listBox1.Font = new global::System.Drawing.Font("Consolas", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.listBox1.ForeColor = global::System.Drawing.Color.White;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 15;
			this.listBox1.Location = new global::System.Drawing.Point(535, 44);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(160, 345);
			this.listBox1.TabIndex = 31;
			this.listBox1.SelectedIndexChanged += new global::System.EventHandler(this.listBox1_SelectedIndexChanged);
			this.panel1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(15, 20, 35);
			this.panel1.Controls.Add(this.guna2Button4);
			this.panel1.Controls.Add(this.guna2Button3);
			this.panel1.Controls.Add(this.guna2Button1);
			this.panel1.Location = new global::System.Drawing.Point(0, 39);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(38, 394);
			this.panel1.TabIndex = 27;
			this.guna2Button4.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.guna2Button4.Animated = true;
			this.guna2Button4.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button4.BorderRadius = 5;
			this.guna2Button4.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.guna2Button4.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button4.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button4.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button4.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button4.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Button4.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button4.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button4.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("guna2Button4.Image");
			this.guna2Button4.IndicateFocus = true;
			this.guna2Button4.Location = new global::System.Drawing.Point(3, 355);
			this.guna2Button4.Name = "guna2Button4";
			this.guna2Button4.Size = new global::System.Drawing.Size(32, 32);
			this.guna2Button4.TabIndex = 4;
			this.guna2Button4.UseTransparentBackground = true;
			this.guna2Button4.Click += new global::System.EventHandler(this.guna2Button4_Click);
			this.guna2Button3.Animated = true;
			this.guna2Button3.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button3.BorderRadius = 5;
			this.guna2Button3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.guna2Button3.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button3.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button3.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Button3.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button3.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button3.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("guna2Button3.Image");
			this.guna2Button3.IndicateFocus = true;
			this.guna2Button3.Location = new global::System.Drawing.Point(3, 43);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.Size = new global::System.Drawing.Size(32, 32);
			this.guna2Button3.TabIndex = 3;
			this.guna2Button3.UseTransparentBackground = true;
			this.guna2Button3.Click += new global::System.EventHandler(this.guna2Button3_Click);
			this.guna2Button1.Animated = true;
			this.guna2Button1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button1.BorderRadius = 5;
			this.guna2Button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.guna2Button1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button1.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Button1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button1.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("guna2Button1.Image");
			this.guna2Button1.IndicateFocus = true;
			this.guna2Button1.Location = new global::System.Drawing.Point(3, 5);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new global::System.Drawing.Size(32, 32);
			this.guna2Button1.TabIndex = 2;
			this.guna2Button1.UseTransparentBackground = true;
			this.guna2Button1.Click += new global::System.EventHandler(this.guna2Button1_Click);
			this.panel2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panel2.BackColor = global::System.Drawing.Color.FromArgb(15, 20, 35);
			this.panel2.Controls.Add(this.chatlab);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.guna2Button13);
			this.panel2.Controls.Add(this.guna2Button12);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.guna2Button2);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new global::System.Drawing.Point(0, 1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(700, 38);
			this.panel2.TabIndex = 28;
			this.panel2.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
			this.panel2.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
			this.chatlab.AutoSize = true;
			this.chatlab.ForeColor = global::System.Drawing.Color.White;
			this.chatlab.Location = new global::System.Drawing.Point(233, 13);
			this.chatlab.Name = "chatlab";
			this.chatlab.Size = new global::System.Drawing.Size(13, 13);
			this.chatlab.TabIndex = 15;
			this.chatlab.Text = "1";
			this.chatlab.Visible = false;
			this.label7.AutoSize = true;
			this.label7.ForeColor = global::System.Drawing.Color.White;
			this.label7.Location = new global::System.Drawing.Point(214, 13);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(13, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "1";
			this.label7.Visible = false;
			this.guna2Button13.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2Button13.Animated = true;
			this.guna2Button13.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button13.BorderRadius = 5;
			this.guna2Button13.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.guna2Button13.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button13.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button13.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button13.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button13.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Button13.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button13.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button13.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("guna2Button13.Image");
			this.guna2Button13.ImageSize = new global::System.Drawing.Size(10, 10);
			this.guna2Button13.Location = new global::System.Drawing.Point(620, 9);
			this.guna2Button13.Name = "guna2Button13";
			this.guna2Button13.Size = new global::System.Drawing.Size(20, 20);
			this.guna2Button13.TabIndex = 5;
			this.guna2Button13.UseTransparentBackground = true;
			this.guna2Button13.Click += new global::System.EventHandler(this.guna2Button13_Click);
			this.guna2Button12.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2Button12.Animated = true;
			this.guna2Button12.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button12.BorderRadius = 5;
			this.guna2Button12.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.guna2Button12.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button12.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button12.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button12.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button12.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Button12.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button12.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button12.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("guna2Button12.Image");
			this.guna2Button12.ImageSize = new global::System.Drawing.Size(15, 15);
			this.guna2Button12.Location = new global::System.Drawing.Point(646, 9);
			this.guna2Button12.Name = "guna2Button12";
			this.guna2Button12.Size = new global::System.Drawing.Size(20, 20);
			this.guna2Button12.TabIndex = 4;
			this.guna2Button12.UseTransparentBackground = true;
			this.guna2Button12.Click += new global::System.EventHandler(this.guna2Button12_Click);
			this.label1.AutoSize = true;
			this.label1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new global::System.Drawing.Font("Consolas", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(4, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(135, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nova - Waiting";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.guna2Button2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2Button2.Animated = true;
			this.guna2Button2.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button2.BorderRadius = 5;
			this.guna2Button2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.guna2Button2.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button2.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Button2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button2.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("guna2Button2.Image");
			this.guna2Button2.ImageSize = new global::System.Drawing.Size(15, 15);
			this.guna2Button2.Location = new global::System.Drawing.Point(672, 9);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.Size = new global::System.Drawing.Size(20, 20);
			this.guna2Button2.TabIndex = 3;
			this.guna2Button2.UseTransparentBackground = true;
			this.guna2Button2.Click += new global::System.EventHandler(this.guna2Button2_Click);
			this.label2.AutoSize = true;
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(195, 13);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(13, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "1";
			this.label2.Visible = false;
			this.fastColoredTextBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.fastColoredTextBox1.AutoCompleteBrackets = true;
			this.fastColoredTextBox1.AutoCompleteBracketsList = new char[]
			{
				'(',
				')',
				'{',
				'}',
				'[',
				']',
				'"',
				'"',
				'\'',
				'\''
			};
			this.fastColoredTextBox1.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
			this.fastColoredTextBox1.AutoScrollMinSize = new global::System.Drawing.Size(27, 17);
			this.fastColoredTextBox1.BackBrush = null;
			this.fastColoredTextBox1.BackColor = global::System.Drawing.Color.FromArgb(15, 20, 35);
			this.fastColoredTextBox1.CaretColor = global::System.Drawing.Color.White;
			this.fastColoredTextBox1.CharHeight = 17;
			this.fastColoredTextBox1.CharWidth = 8;
			this.fastColoredTextBox1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.fastColoredTextBox1.DisabledColor = global::System.Drawing.Color.FromArgb(100, 180, 180, 180);
			this.fastColoredTextBox1.Font = new global::System.Drawing.Font("Consolas", 11.25f);
			this.fastColoredTextBox1.ForeColor = global::System.Drawing.Color.White;
			this.fastColoredTextBox1.IndentBackColor = global::System.Drawing.Color.Transparent;
			this.fastColoredTextBox1.IsReplaceMode = false;
			this.fastColoredTextBox1.LineNumberColor = global::System.Drawing.Color.White;
			this.fastColoredTextBox1.Location = new global::System.Drawing.Point(44, 44);
			this.fastColoredTextBox1.Name = "fastColoredTextBox1";
			this.fastColoredTextBox1.Paddings = new global::System.Windows.Forms.Padding(0);
			this.fastColoredTextBox1.SelectionColor = global::System.Drawing.Color.FromArgb(60, 173, 216, 230);
			this.fastColoredTextBox1.ServiceColors = (global::FastColoredTextBoxNS.ServiceColors)componentResourceManager.GetObject("fastColoredTextBox1.ServiceColors");
			this.fastColoredTextBox1.Size = new global::System.Drawing.Size(485, 345);
			this.fastColoredTextBox1.TabIndex = 29;
			this.fastColoredTextBox1.Zoom = 100;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(11, 15, 26);
			base.ClientSize = new global::System.Drawing.Size(700, 430);
			base.Controls.Add(this.panel6);
			base.Controls.Add(this.panel4);
			base.Controls.Add(this.panel7);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.fastColoredTextBox1);
			base.Controls.Add(this.listBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form3";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form3";
			base.Load += new global::System.EventHandler(this.Form3_Load);
			base.Shown += new global::System.EventHandler(this.Form3_Shown);
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.fastColoredTextBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000019 RID: 25
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.Panel panel6;

		// Token: 0x0400001B RID: 27
		private global::Guna.UI2.WinForms.Guna2Button guna2Button17;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x0400001D RID: 29
		private global::Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x0400001F RID: 31
		private global::Guna.UI2.WinForms.Guna2Button guna2Button15;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000021 RID: 33
		private global::Guna.UI2.WinForms.Guna2Button guna2Button14;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.Panel panel5;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Panel panel7;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000025 RID: 37
		private global::Guna.UI2.WinForms.Guna2Button guna2Button4;

		// Token: 0x04000026 RID: 38
		private global::Guna.UI2.WinForms.Guna2Button guna2Button3;

		// Token: 0x04000027 RID: 39
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.Label chatlab;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400002B RID: 43
		private global::Guna.UI2.WinForms.Guna2Button guna2Button13;

		// Token: 0x0400002C RID: 44
		private global::Guna.UI2.WinForms.Guna2Button guna2Button12;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400002E RID: 46
		private global::Guna.UI2.WinForms.Guna2Button guna2Button2;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000031 RID: 49
		private global::Guna.UI2.WinForms.Guna2Button guna2Button11;

		// Token: 0x04000032 RID: 50
		private global::Guna.UI2.WinForms.Guna2Button guna2Button6;

		// Token: 0x04000033 RID: 51
		private global::Guna.UI2.WinForms.Guna2Button guna2Button9;

		// Token: 0x04000034 RID: 52
		private global::Guna.UI2.WinForms.Guna2Button guna2Button7;

		// Token: 0x04000035 RID: 53
		private global::Guna.UI2.WinForms.Guna2Button guna2Button8;

		// Token: 0x04000036 RID: 54
		private global::Guna.UI2.WinForms.Guna2Button guna2Button10;

		// Token: 0x04000037 RID: 55
		private global::FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x04000039 RID: 57
		private global::Guna.UI2.WinForms.Guna2Button guna2Button5;
	}
}
