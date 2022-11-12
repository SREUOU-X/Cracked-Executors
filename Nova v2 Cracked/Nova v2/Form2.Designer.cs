namespace Nova_v2
{
	// Token: 0x02000003 RID: 3
	public partial class Form2 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002D5C File Offset: 0x00000F5C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002D94 File Offset: 0x00000F94
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Nova_v2.Form2));
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.FormElipse = new global::Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.TextBoxEmail = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.guna2Button4 = new global::Guna.UI2.WinForms.Guna2Button();
			this.label3 = new global::System.Windows.Forms.Label();
			this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.TextBoxPassword = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.TextBoxUsername = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.guna2Button2 = new global::Guna.UI2.WinForms.Guna2Button();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(424, 102);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(183, 176);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			this.FormElipse.BorderRadius = 5;
			this.FormElipse.TargetControl = this;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(13, 24, 35);
			this.panel1.Controls.Add(this.TextBoxEmail);
			this.panel1.Controls.Add(this.guna2Button4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.guna2Button1);
			this.panel1.Controls.Add(this.TextBoxPassword);
			this.panel1.Controls.Add(this.TextBoxUsername);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(343, 390);
			this.panel1.TabIndex = 3;
			this.panel1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.TextBoxEmail.Animated = true;
			this.TextBoxEmail.BorderColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.TextBoxEmail.BorderRadius = 3;
			this.TextBoxEmail.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.TextBoxEmail.DefaultText = "";
			this.TextBoxEmail.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.TextBoxEmail.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.TextBoxEmail.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.TextBoxEmail.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.TextBoxEmail.FillColor = global::System.Drawing.Color.FromArgb(10, 16, 21);
			this.TextBoxEmail.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.TextBoxEmail.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.TextBoxEmail.ForeColor = global::System.Drawing.Color.DarkGray;
			this.TextBoxEmail.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.TextBoxEmail.Location = new global::System.Drawing.Point(10, 168);
			this.TextBoxEmail.Name = "TextBoxEmail";
			this.TextBoxEmail.PasswordChar = '\0';
			this.TextBoxEmail.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.TextBoxEmail.PlaceholderText = "Email*";
			this.TextBoxEmail.SelectedText = "";
			this.TextBoxEmail.Size = new global::System.Drawing.Size(323, 28);
			this.TextBoxEmail.TabIndex = 7;
			this.guna2Button4.Animated = true;
			this.guna2Button4.BorderColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.guna2Button4.BorderRadius = 3;
			this.guna2Button4.BorderThickness = 1;
			this.guna2Button4.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.guna2Button4.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button4.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button4.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button4.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button4.FillColor = global::System.Drawing.Color.FromArgb(10, 16, 21);
			this.guna2Button4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f);
			this.guna2Button4.ForeColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button4.Location = new global::System.Drawing.Point(10, 304);
			this.guna2Button4.Name = "guna2Button4";
			this.guna2Button4.Size = new global::System.Drawing.Size(323, 28);
			this.guna2Button4.TabIndex = 6;
			this.guna2Button4.Text = "Login";
			this.guna2Button4.Click += new global::System.EventHandler(this.guna2Button4_Click);
			this.label3.AutoSize = true;
			this.label3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.label3.ForeColor = global::System.Drawing.Color.FromArgb(62, 146, 255);
			this.label3.Location = new global::System.Drawing.Point(219, 335);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(114, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Forgot your password?";
			this.guna2Button1.Animated = true;
			this.guna2Button1.BorderColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.guna2Button1.BorderRadius = 3;
			this.guna2Button1.BorderThickness = 1;
			this.guna2Button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.guna2Button1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button1.FillColor = global::System.Drawing.Color.FromArgb(10, 16, 21);
			this.guna2Button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f);
			this.guna2Button1.ForeColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.Location = new global::System.Drawing.Point(10, 270);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new global::System.Drawing.Size(323, 28);
			this.guna2Button1.TabIndex = 4;
			this.guna2Button1.Text = "Register";
			this.guna2Button1.Click += new global::System.EventHandler(this.guna2Button1_Click);
			this.TextBoxPassword.Animated = true;
			this.TextBoxPassword.BorderColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.TextBoxPassword.BorderRadius = 3;
			this.TextBoxPassword.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.TextBoxPassword.DefaultText = "";
			this.TextBoxPassword.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.TextBoxPassword.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.TextBoxPassword.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.TextBoxPassword.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.TextBoxPassword.FillColor = global::System.Drawing.Color.FromArgb(10, 16, 21);
			this.TextBoxPassword.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.TextBoxPassword.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.TextBoxPassword.ForeColor = global::System.Drawing.Color.DarkGray;
			this.TextBoxPassword.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.TextBoxPassword.Location = new global::System.Drawing.Point(10, 236);
			this.TextBoxPassword.Name = "TextBoxPassword";
			this.TextBoxPassword.PasswordChar = '*';
			this.TextBoxPassword.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.TextBoxPassword.PlaceholderText = "Password";
			this.TextBoxPassword.SelectedText = "";
			this.TextBoxPassword.Size = new global::System.Drawing.Size(323, 28);
			this.TextBoxPassword.TabIndex = 3;
			this.TextBoxUsername.Animated = true;
			this.TextBoxUsername.BorderColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.TextBoxUsername.BorderRadius = 3;
			this.TextBoxUsername.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.TextBoxUsername.DefaultText = "";
			this.TextBoxUsername.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.TextBoxUsername.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.TextBoxUsername.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.TextBoxUsername.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.TextBoxUsername.FillColor = global::System.Drawing.Color.FromArgb(10, 16, 21);
			this.TextBoxUsername.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.TextBoxUsername.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.TextBoxUsername.ForeColor = global::System.Drawing.Color.DarkGray;
			this.TextBoxUsername.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.TextBoxUsername.Location = new global::System.Drawing.Point(10, 202);
			this.TextBoxUsername.Name = "TextBoxUsername";
			this.TextBoxUsername.PasswordChar = '\0';
			this.TextBoxUsername.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.TextBoxUsername.PlaceholderText = "Username";
			this.TextBoxUsername.SelectedText = "";
			this.TextBoxUsername.Size = new global::System.Drawing.Size(323, 28);
			this.TextBoxUsername.TabIndex = 2;
			this.label2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new global::System.Drawing.Font("Consolas", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(3, 63);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(337, 61);
			this.label2.TabIndex = 1;
			this.label2.Text = "Enter your credentials below to begin scripting using Nova.";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new global::System.Drawing.Font("Consolas", 18f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(3, 25);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(337, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "Welcome to Nova v2.9!";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
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
			this.guna2Button2.Location = new global::System.Drawing.Point(653, 12);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.Size = new global::System.Drawing.Size(20, 20);
			this.guna2Button2.TabIndex = 5;
			this.guna2Button2.UseTransparentBackground = true;
			this.guna2Button2.Click += new global::System.EventHandler(this.guna2Button2_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(10, 16, 24);
			base.ClientSize = new global::System.Drawing.Size(686, 390);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.guna2Button2);
			base.Controls.Add(this.pictureBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form2";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			base.Load += new global::System.EventHandler(this.Form2_Load);
			base.Shown += new global::System.EventHandler(this.Form2_Shown);
			base.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown_1);
			base.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove_1);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000009 RID: 9
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400000B RID: 11
		private global::Guna.UI2.WinForms.Guna2Elipse FormElipse;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400000D RID: 13
		private global::Guna.UI2.WinForms.Guna2TextBox TextBoxEmail;

		// Token: 0x0400000E RID: 14
		private global::Guna.UI2.WinForms.Guna2Button guna2Button4;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000010 RID: 16
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;

		// Token: 0x04000011 RID: 17
		private global::Guna.UI2.WinForms.Guna2TextBox TextBoxPassword;

		// Token: 0x04000012 RID: 18
		private global::Guna.UI2.WinForms.Guna2TextBox TextBoxUsername;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000015 RID: 21
		private global::Guna.UI2.WinForms.Guna2Button guna2Button2;
	}
}
