using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Nova_v2.Properties;

namespace Nova_v2
{
	// Token: 0x02000003 RID: 3
	public partial class Form2 : Form
	{
		// Token: 0x06000007 RID: 7 RVA: 0x0000244A File Offset: 0x0000064A
		public Form2()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002470 File Offset: 0x00000670
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			bool flag = this.TextBoxEmail.Text == "";
			if (flag)
			{
				MessageBox.Show("Please enter your Email Address!", "Warning");
			}
			else
			{
				bool flag2 = !this.TextBoxEmail.Text.Contains("@");
				if (flag2)
				{
					MessageBox.Show("Please enter a valid Email Address!", "Warning");
				}
				else
				{
					bool flag3 = this.TextBoxUsername.Text == "";
					if (flag3)
					{
						MessageBox.Show("Please enter your Username!", "Warning");
					}
					else
					{
						bool flag4 = this.TextBoxUsername.Text.Contains("!");
						if (flag4)
						{
							MessageBox.Show("You can onlu use Any Letters, Any Numbers and Underscores!", "Warning");
						}
						else
						{
							bool flag5 = this.TextBoxUsername.Text.Contains("@");
							if (flag5)
							{
								MessageBox.Show("You can onlu use Any Letters, Any Numbers and Underscores!", "Warning");
							}
							else
							{
								bool flag6 = this.TextBoxUsername.Text.Contains("#");
								if (flag6)
								{
									MessageBox.Show("You can onlu use Any Letters, Any Numbers and Underscores!", "Warning");
								}
								else
								{
									bool flag7 = this.TextBoxUsername.Text.Contains("$");
									if (flag7)
									{
										MessageBox.Show("You can onlu use Any Letters, Any Numbers and Underscores!", "Warning");
									}
									else
									{
										bool flag8 = this.TextBoxUsername.Text.Contains("%");
										if (flag8)
										{
											MessageBox.Show("You can onlu use Any Letters, Any Numbers and Underscores!", "Warning");
										}
										else
										{
											bool flag9 = this.TextBoxUsername.Text.Contains("^");
											if (flag9)
											{
												MessageBox.Show("You can onlu use Any Letters, Any Numbers and Underscores!", "Warning");
											}
											else
											{
												bool flag10 = this.TextBoxUsername.Text.Contains("&");
												if (flag10)
												{
													MessageBox.Show("You can onlu use Any Letters, Any Numbers and Underscores!", "Warning");
												}
												else
												{
													bool flag11 = this.TextBoxUsername.Text.Contains("*");
													if (flag11)
													{
														MessageBox.Show("You can onlu use Any Letters, Any Numbers and Underscores!", "Warning");
													}
													else
													{
														bool flag12 = this.TextBoxUsername.Text.Contains("(");
														if (flag12)
														{
															MessageBox.Show("You can onlu use Any Letters, Any Numbers and Underscores!", "Warning");
														}
														else
														{
															bool flag13 = this.TextBoxUsername.Text.Contains(")");
															if (flag13)
															{
																MessageBox.Show("You can onlu use Any Letters, Any Numbers and Underscores!", "Warning");
															}
															else
															{
																bool flag14 = this.TextBoxUsername.Text.Contains("-");
																if (flag14)
																{
																	MessageBox.Show("You can onlu use Any Letters, Any Numbers and Underscores!", "Warning");
																}
																else
																{
																	bool flag15 = this.TextBoxUsername.Text.Contains("=");
																	if (flag15)
																	{
																		MessageBox.Show("You can onlu use Any Letters, Any Numbers and Underscores!", "Warning");
																	}
																	else
																	{
																		bool flag16 = this.TextBoxUsername.Text.Contains("+");
																		if (flag16)
																		{
																			MessageBox.Show("You can onlu use Any Letters, Any Numbers and Underscores!", "Warning");
																		}
																		else
																		{
																			bool flag17 = this.TextBoxUsername.Text.Contains("[");
																			if (flag17)
																			{
																				MessageBox.Show("You can onlu use Any Letters, Any Numbers and Underscores!", "Warning");
																			}
																			else
																			{
																				bool flag18 = this.TextBoxUsername.Text.Contains("]");
																				if (flag18)
																				{
																					MessageBox.Show("You can onlu use Any Letters, Any Numbers and Underscores!", "Warning");
																				}
																				else
																				{
																					bool flag19 = this.TextBoxUsername.Text.Contains("{");
																					if (flag19)
																					{
																						MessageBox.Show("You can onlu use Any Letters, Any Numbers and Underscores!", "Warning");
																					}
																					else
																					{
																						bool flag20 = this.TextBoxUsername.Text.Contains("}");
																						if (flag20)
																						{
																							MessageBox.Show("You can onlu use Any Letters, Any Numbers and Underscores!", "Warning");
																						}
																						else
																						{
																							bool flag21 = this.TextBoxUsername.Text.Contains("|");
																							if (flag21)
																							{
																								MessageBox.Show("You can onlu use Any Letters, Any Numbers and Underscores!", "Warning");
																							}
																							else
																							{
																								bool flag22 = this.TextBoxUsername.Text.Contains(":");
																								if (flag22)
																								{
																									MessageBox.Show("You can onlu use Any Letters, Any Numbers and Underscores!", "Warning");
																								}
																								else
																								{
																									bool flag23 = this.TextBoxUsername.Text.Contains(";");
																									if (flag23)
																									{
																										MessageBox.Show("You can onlu use Any Letters, Any Numbers and Underscores!", "Warning");
																									}
																									else
																									{
																										bool flag24 = this.TextBoxUsername.Text.Contains("'");
																										if (flag24)
																										{
																											MessageBox.Show("You can onlu use Any Letters, Any Numbers and Underscores!", "Warning");
																										}
																										else
																										{
																											bool flag25 = this.TextBoxUsername.Text.Contains(",");
																											if (flag25)
																											{
																												MessageBox.Show("You can onlu use Any Letters, Any Numbers and Underscores!", "Warning");
																											}
																											else
																											{
																												bool flag26 = this.TextBoxUsername.Text.Contains("<");
																												if (flag26)
																												{
																													MessageBox.Show("You can onlu use Any Letters, Any Numbers and Underscores!", "Warning");
																												}
																												else
																												{
																													bool flag27 = this.TextBoxUsername.Text.Contains(">");
																													if (flag27)
																													{
																														MessageBox.Show("You can onlu use Any Letters, Any Numbers and Underscores!", "Warning");
																													}
																													else
																													{
																														bool flag28 = this.TextBoxUsername.Text.Contains("/");
																														if (flag28)
																														{
																															MessageBox.Show("You can onlu use Any Letters, Any Numbers and Underscores!", "Warning");
																														}
																														else
																														{
																															bool flag29 = this.TextBoxUsername.Text.Contains("?");
																															if (flag29)
																															{
																																MessageBox.Show("You can onlu use Any Letters, Any Numbers and Underscores!", "Warning");
																															}
																															else
																															{
																																bool flag30 = this.TextBoxPassword.Text == "";
																																if (flag30)
																																{
																																	MessageBox.Show("Please enter your Password", "Warning");
																																}
																																else
																																{
																																	this.TextBoxEmail.Text = Settings.Default.Email;
																																	this.TextBoxUsername.Text = Settings.Default.User;
																																	this.TextBoxPassword.Text = Settings.Default.Pass;
																																	Guid guid = Guid.NewGuid();
																																	Settings.Default.TokenID = guid.ToString();
																																	Settings.Default.LogCheck = "2";
																																	Settings.Default.Save();
																																	Application.Restart();
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002ADC File Offset: 0x00000CDC
		private void guna2Button4_Click(object sender, EventArgs e)
		{
			bool flag = this.TextBoxEmail.Text == Settings.Default.Email;
			if (flag)
			{
				MessageBox.Show("Email already used!", "Error");
			}
			else
			{
				bool flag2 = this.TextBoxUsername.Text == Settings.Default.User;
				if (flag2)
				{
					MessageBox.Show("Username already used!", "Error");
				}
				else
				{
					bool flag3 = this.TextBoxEmail.Text == Settings.Default.TokenID;
					if (flag3)
					{
						this.main.Show();
						base.Hide();
						Settings.Default.LogCheck = "2";
						Settings.Default.Save();
						Application.Restart();
					}
					else
					{
						bool flag4 = this.TextBoxUsername.Text == Settings.Default.User & this.TextBoxPassword.Text == Settings.Default.Pass;
						if (flag4)
						{
							Settings.Default.LogCheck = "2";
							Settings.Default.Save();
							Application.Restart();
						}
						else
						{
							MessageBox.Show("Invalid Credentials", "Error");
						}
					}
				}
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002C1A File Offset: 0x00000E1A
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002C24 File Offset: 0x00000E24
		private void Form2_Shown(object sender, EventArgs e)
		{
			bool flag = Settings.Default.LogCheck == "2";
			if (flag)
			{
				this.main.Show();
				base.Hide();
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002C5F File Offset: 0x00000E5F
		private void Form2_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002C62 File Offset: 0x00000E62
		private void Form2_MouseDown_1(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002C7C File Offset: 0x00000E7C
		private void Form2_MouseMove_1(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002CDD File Offset: 0x00000EDD
		private void panel1_MouseDown_1(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002CF8 File Offset: 0x00000EF8
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x04000007 RID: 7
		private Form3 main = new Form3();

		// Token: 0x04000008 RID: 8
		private Point lastPoint;
	}
}
