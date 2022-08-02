using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Threading;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Shapes;
using AnemoAPI;
using CheatSquadAPI;
using ClubDarkAPI;
using EasyExploits;
using ICSharpCode.AvalonEdit;
using Magma_IaE;
using MaterialDesignThemes.Wpf.Transitions;
using Microsoft.Win32;
using WeAreDevs_API;

namespace ScriptHub_v3._4._1b
{
	// Token: 0x0200000A RID: 10
	public partial class MainWindow : Window
	{
		// Token: 0x06000013 RID: 19
		[DllImport("user32.dll")]
		internal static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000023B4 File Offset: 0x000005B4
		// (set) Token: 0x06000015 RID: 21 RVA: 0x000023D8 File Offset: 0x000005D8
		public double BlurOpacity
		{
			get
			{
				return this._blurOpacity;
			}
			set
			{
				this._blurOpacity = (uint)value;
				this.EnableBlur();
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000023EC File Offset: 0x000005EC
		public MainWindow()
		{
			base.DataContext = this;
			try
			{
				this.InitializeComponent();
			}
			catch (Exception ex)
			{
				System.Windows.MessageBox.Show(ex.InnerException.ToString());
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000024B0 File Offset: 0x000006B0
		private void ScriptsListBox_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
		{
			try
			{
				string str = this.ScriptsListBox.Items[this.ScriptsListBox.SelectedIndex].ToString().Replace("System.Windows.Controls.ListBoxItem: ", "");
				this.ScriptTextBox.Text = File.ReadAllText(System.IO.Path.GetFullPath(this.ScriptsDirectory.Text) + "/" + str);
			}
			catch
			{
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000253C File Offset: 0x0000073C
		private static string GetUrl(string url)
		{
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.CreateDefault(new Uri(url));
			string result;
			using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
			{
				bool flag = httpWebResponse.StatusCode != HttpStatusCode.OK;
				if (flag)
				{
					throw new ServerException("Server returned an error code (" + ((int)httpWebResponse.StatusCode).ToString() + ") while trying to retrieve a new key: " + httpWebResponse.StatusDescription);
				}
				using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
				{
					result = streamReader.ReadToEnd();
				}
			}
			return result;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002614 File Offset: 0x00000814
		private void Window_Initialized(object sender, EventArgs e)
		{
			bool flag = MainWindow.GetUrl("https://raw.githubusercontent.com/Not316tb/Magma/main/version.txt") != "2.0.9s\n";
			if (flag)
			{
				DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("A new version of Magma is available! Download it now?", "Auto-Updater", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
				bool flag2 = dialogResult == System.Windows.Forms.DialogResult.Yes;
				if (flag2)
				{
					Process.Start("http://github.com/Not316tb/Magma/releases");
					System.Windows.Application.Current.Shutdown();
				}
			}
			base.Title = "Magma IaE";
			this.ScriptTextBox.Text = "--[[                                        /\\\n\t                                       /__\\\n\tHi! My name's Not316tb. Welcome         ||\n\tto the Magma Injector & Executor!       ||\n\t                                        ||\n    Use the firework button to              ||\n    Execute your scripts                    ||\n                                            ||\nChange Log:                                 ||\n                                            ||\n  [*] Removed Malware DLLs          ________||_______\n  [*] Removed Some Dependencies    |                 |\n  [*] Updated This \"Guide\"\t       |    Click the    |\n\t                               |  Attach Button  |\n\t                               | To Get Started! |\n\t                               |_________________|\n]]--";
			this.ScriptTextBox.SyntaxHighlighting = ResourceLoader.LoadHighlightingDefinition("Lua.xshd");
			bool flag3 = !File.Exists(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"));
			if (flag3)
			{
				File.WriteAllText(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"), "classic\nanmo\nfalse\nfalse\n./Scripts\nfalse");
			}
			bool flag4 = File.ReadLines(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt")).Count<string>() <= 5;
			if (flag4)
			{
				File.WriteAllText(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"), "classic\nezxp\nfalse\nfalse\n./Scripts\nfalse");
			}
			this.config = File.ReadAllLines(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"));
			bool flag5 = this.config[1] == "ezxp";
			if (flag5)
			{
				this.ApiType.SelectedIndex = 2;
			}
			else
			{
				bool flag6 = this.config[1] == "anmo";
				if (flag6)
				{
					this.ApiType.SelectedIndex = 1;
				}
				else
				{
					bool flag7 = this.config[1] == "cdrk";
					if (flag7)
					{
						this.ApiType.SelectedIndex = 6;
					}
					else
					{
						bool flag8 = this.config[1] == "wrd";
						if (flag8)
						{
							this.ApiType.SelectedIndex = 3;
						}
						else
						{
							bool flag9 = this.config[1] == "csq";
							if (flag9)
							{
								this.ApiType.SelectedIndex = 4;
							}
						}
					}
				}
			}
			bool flag10 = this.config[2] == "false";
			if (flag10)
			{
				this.AcrylicEffect.IsChecked = new bool?(false);
			}
			else
			{
				bool flag11 = this.config[2] == "true";
				if (flag11)
				{
					this.AcrylicEffect.IsChecked = new bool?(true);
				}
			}
			bool flag12 = this.config[3] == "false";
			if (flag12)
			{
				this.AdvUnfocus.IsChecked = new bool?(false);
			}
			else
			{
				bool flag13 = this.config[3] == "true";
				if (flag13)
				{
					this.AdvUnfocus.IsChecked = new bool?(true);
				}
			}
			bool flag14 = this.config[5] == "false";
			if (flag14)
			{
				this.AttachFromHome.IsChecked = new bool?(false);
			}
			else
			{
				bool flag15 = this.config[5] == "true";
				if (flag15)
				{
					this.AttachFromHome.IsChecked = new bool?(true);
				}
			}
			bool flag16 = Directory.Exists(System.IO.Path.GetFullPath(this.config[4]));
			if (flag16)
			{
				bool flag17 = System.IO.Path.GetFileName(System.IO.Path.GetFullPath(this.config[4])).Length >= 11;
				string text;
				if (flag17)
				{
					text = System.IO.Path.GetFileName(System.IO.Path.GetFullPath(this.config[4])).Substring(0, 10) + "...";
				}
				else
				{
					text = (System.IO.Path.GetFileName(System.IO.Path.GetFullPath(this.config[4])) ?? "");
				}
				this.ScriptsDirLabel.Content = (text ?? "");
				this.ScriptsDirectory.Text = this.config[4];
				this.ScriptsDirLabel.Content = text;
				LocalFunctions.PopulateListBox(this.ScriptsListBox, this.ScriptsDirectory.Text, "*.txt");
				LocalFunctions.PopulateListBox(this.ScriptsListBox, this.ScriptsDirectory.Text, "*.lua");
			}
			this.window = (Window)sender;
			System.Timers.Timer timer = new System.Timers.Timer();
			timer.Elapsed += this.CheckRobloxOpen;
			timer.Interval = 2500.0;
			timer.Enabled = true;
			this.dllButton.ToolTip = new System.Windows.Controls.ToolTip
			{
				Content = "DLL Injector"
			};
			this.ButtonClose.ToolTip = new System.Windows.Controls.ToolTip
			{
				Content = "Exit Magma IaE"
			};
			this.luaButton.ToolTip = new System.Windows.Controls.ToolTip
			{
				Content = "Roblox Lua Executor"
			};
			this.ButtonMinimize.ToolTip = new System.Windows.Controls.ToolTip
			{
				Content = "Minimize Window"
			};
			this.ButtonKeepTop.ToolTip = new System.Windows.Controls.ToolTip
			{
				Content = "Keep On Top (No)"
			};
			this.ButtonKillTask.ToolTip = new System.Windows.Controls.ToolTip
			{
				Content = "Kill Roblox"
			};
			this.ButtonClearText.ToolTip = new System.Windows.Controls.ToolTip
			{
				Content = "Clear Textbox"
			};
			this.ButtonSaveScript.ToolTip = new System.Windows.Controls.ToolTip
			{
				Content = "Save Script"
			};
			this.ButtonReAttach.ToolTip = new System.Windows.Controls.ToolTip
			{
				Content = "Attach API (Configure in Settings)"
			};
			this.ButtonLoadScript.ToolTip = new System.Windows.Controls.ToolTip
			{
				Content = "Load Script from File"
			};
			this.ButtonExecuteScript.ToolTip = new System.Windows.Controls.ToolTip
			{
				Content = "Execute Script (Lua)"
			};
			this.AcrylicEffect.ToolTip = new System.Windows.Controls.ToolTip
			{
				Content = "Blurs Application Background ( Laggy )"
			};
			this.AdvUnfocus.ToolTip = new System.Windows.Controls.ToolTip
			{
				Content = "Enable / Disable Transparency When Leaving The Window"
			};
			this.AttachFromHome.ToolTip = new System.Windows.Controls.ToolTip
			{
				Content = "Attach API When Clicking 'Lua' Button On Home Screen"
			};
			this.addDll.ToolTip = new System.Windows.Controls.ToolTip
			{
				Content = "Add A DLL File To Inject"
			};
			this.clrDlls.ToolTip = new System.Windows.Controls.ToolTip
			{
				Content = "Clear Current DLLs List"
			};
			this.refProcList.ToolTip = new System.Windows.Controls.ToolTip
			{
				Content = "Refresh Processes List"
			};
			this.rmvDll.ToolTip = new System.Windows.Controls.ToolTip
			{
				Content = "Remove Currently Selected DLL from the list"
			};
			this.about.ToolTip = new System.Windows.Controls.ToolTip
			{
				Content = "View GitHub Documentation"
			};
			this.configInjector.ToolTip = new System.Windows.Controls.ToolTip
			{
				Content = "Configure Injector Settings"
			};
			this.injectButton.ToolTip = new System.Windows.Controls.ToolTip
			{
				Content = "Inject DLL"
			};
			this.discUrl.ToolTip = new System.Windows.Controls.ToolTip
			{
				Content = "Join The Studio7 Discord"
			};
			this.webSite.ToolTip = new System.Windows.Controls.ToolTip
			{
				Content = "Visit My Website"
			};
			this.gitHub.ToolTip = new System.Windows.Controls.ToolTip
			{
				Content = "Visit My GitHub"
			};
			this.MoveMenuCursor(0);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002D8C File Offset: 0x00000F8C
		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			bool flag = this.config[2] == "true";
			if (flag)
			{
				this.EnableBlur();
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002DC4 File Offset: 0x00000FC4
		private void ButtonClose_Click(object sender, RoutedEventArgs e)
		{
			System.Windows.Application.Current.Shutdown();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002DD4 File Offset: 0x00000FD4
		private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
		{
			base.WindowState = WindowState.Minimized;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002DE0 File Offset: 0x00000FE0
		private void ButtonKeepTop_Click(object sender, RoutedEventArgs e)
		{
			bool flag = !this.setTopClicked;
			if (flag)
			{
				this.window.Topmost = true;
				this.ButtonKeepTop.ToolTip = new System.Windows.Controls.ToolTip
				{
					Content = "Keep On Top (Yes)"
				};
				this.ButtonKeepTop.Foreground = (Brush)new BrushConverter().ConvertFromString("#DDFFFFFF");
				this.setTopClicked = true;
			}
			else
			{
				bool flag2 = this.setTopClicked;
				if (flag2)
				{
					this.window.Topmost = false;
					this.ButtonKeepTop.ToolTip = new System.Windows.Controls.ToolTip
					{
						Content = "Keep On Top (No)"
					};
					this.ButtonKeepTop.Foreground = (Brush)new BrushConverter().ConvertFromString("#7FFFFFFF");
					this.setTopClicked = false;
				}
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002EBC File Offset: 0x000010BC
		private bool IsRobloxTabActive()
		{
			bool flag = this.ListViewMenu.SelectedIndex != 2;
			return !flag;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002EF8 File Offset: 0x000010F8
		private void CheckRobloxOpen(object sender, ElapsedEventArgs e)
		{
			bool tabStatus = true;
			base.Dispatcher.Invoke(delegate()
			{
				bool flag11 = !this.IsRobloxTabActive();
				if (flag11)
				{
					tabStatus = false;
				}
			});
			bool tabStatus2 = tabStatus;
			if (tabStatus2)
			{
				bool flag = this.config[1] == "wrd";
				if (flag)
				{
					bool flag2 = this.WRD.isAPIAttached();
					if (flag2)
					{
						base.Dispatcher.Invoke(delegate()
						{
							this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF00FF00");
							this.Status.Text = "Injected";
							this.apiInjected = true;
							this.ButtonReAttach.ToolTip = new System.Windows.Controls.ToolTip
							{
								Content = "Re-Attach API"
							};
						});
					}
					else
					{
						base.Dispatcher.Invoke(delegate()
						{
							this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF7C7C7C");
							this.Status.Text = "Idle";
							this.apiInjected = false;
						});
					}
				}
				else
				{
					bool flag3 = this.config[1] == "ezxp";
					if (flag3)
					{
						bool flag4 = DllPipes.NamedPipeExist("ocybedam");
						if (flag4)
						{
							base.Dispatcher.Invoke(delegate()
							{
								this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF00FF00");
								this.Status.Text = "Injected";
								this.apiInjected = true;
								this.ButtonReAttach.ToolTip = new System.Windows.Controls.ToolTip
								{
									Content = "Re-Attach API"
								};
							});
						}
						else
						{
							base.Dispatcher.Invoke(delegate()
							{
								this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF7C7C7C");
								this.Status.Text = "Idle";
								this.apiInjected = false;
							});
						}
					}
					else
					{
						bool flag5 = this.config[1] == "cdrk";
						if (flag5)
						{
							bool flag6 = DllPipes.NamedPipeExist("zxc");
							if (flag6)
							{
								base.Dispatcher.Invoke(delegate()
								{
									this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF00FF00");
									this.Status.Text = "Injected";
									this.apiInjected = true;
									this.ButtonReAttach.ToolTip = new System.Windows.Controls.ToolTip
									{
										Content = "Re-Attach API"
									};
								});
							}
							else
							{
								base.Dispatcher.Invoke(delegate()
								{
									this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF7C7C7C");
									this.Status.Text = "Idle";
									this.apiInjected = false;
								});
							}
						}
						else
						{
							bool flag7 = this.config[1] == "csq";
							if (flag7)
							{
								bool flag8 = DllPipes.NamedPipeExist("taStqdau1Ch1ee33");
								if (flag8)
								{
									base.Dispatcher.Invoke(delegate()
									{
										this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF00FF00");
										this.Status.Text = "Injected";
										this.apiInjected = true;
										this.ButtonReAttach.ToolTip = new System.Windows.Controls.ToolTip
										{
											Content = "Re-Attach API"
										};
									});
								}
								else
								{
									base.Dispatcher.Invoke(delegate()
									{
										this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF7C7C7C");
										this.Status.Text = "Idle";
										this.apiInjected = false;
									});
								}
							}
							else
							{
								bool flag9 = this.config[1] == "anmo";
								if (flag9)
								{
									bool flag10 = DllPipes.NamedPipeExist("AnemoPIPE");
									if (flag10)
									{
										base.Dispatcher.Invoke(delegate()
										{
											this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF00FF00");
											this.Status.Text = "Injected";
											this.apiInjected = true;
											this.ButtonReAttach.ToolTip = new System.Windows.Controls.ToolTip
											{
												Content = "Re-Attach API"
											};
										});
									}
									else
									{
										base.Dispatcher.Invoke(delegate()
										{
											this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF7C7C7C");
											this.Status.Text = "Idle";
											this.apiInjected = false;
										});
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003178 File Offset: 0x00001378
		private void ButtonKillTask_Click(object sender, RoutedEventArgs e)
		{
			IEnumerable<Process> enumerable = from pr in Process.GetProcesses()
			where pr.ProcessName == "RobloxPlayerBeta"
			select pr;
			foreach (Process process in enumerable)
			{
				process.Kill();
			}
			IEnumerable<Process> enumerable2 = from pr in Process.GetProcesses()
			where pr.ProcessName == "RobloxPlayer"
			select pr;
			foreach (Process process2 in enumerable2)
			{
				process2.Kill();
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003274 File Offset: 0x00001474
		private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
		{
			bool flag = e.ChangedButton == MouseButton.Left;
			if (flag)
			{
				base.DragMove();
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000032A0 File Offset: 0x000014A0
		internal void EnableBlur()
		{
			WindowInteropHelper windowInteropHelper = new WindowInteropHelper(this);
			AccentPolicy structure = new AccentPolicy
			{
				AccentState = AccentState.ACCENT_ENABLE_ACRYLICBLURBEHIND,
				GradientColor = (this._blurOpacity << 24 | (this._blurBackgroundColor & 16777215U))
			};
			int num = Marshal.SizeOf<AccentPolicy>(structure);
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.StructureToPtr<AccentPolicy>(structure, intPtr, false);
			WindowCompositionAttributeData windowCompositionAttributeData = default(WindowCompositionAttributeData);
			windowCompositionAttributeData.Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY;
			windowCompositionAttributeData.SizeOfData = num;
			windowCompositionAttributeData.Data = intPtr;
			MainWindow.SetWindowCompositionAttribute(windowInteropHelper.Handle, ref windowCompositionAttributeData);
			Marshal.FreeHGlobal(intPtr);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003334 File Offset: 0x00001534
		internal void DisableBlur()
		{
			WindowInteropHelper windowInteropHelper = new WindowInteropHelper(this);
			AccentPolicy structure = new AccentPolicy
			{
				AccentState = AccentState.ACCENT_DISABLED,
				GradientColor = (this._blurOpacity << 24 | (this._blurBackgroundColor & 16777215U))
			};
			int num = Marshal.SizeOf<AccentPolicy>(structure);
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.StructureToPtr<AccentPolicy>(structure, intPtr, false);
			WindowCompositionAttributeData windowCompositionAttributeData = default(WindowCompositionAttributeData);
			windowCompositionAttributeData.Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY;
			windowCompositionAttributeData.SizeOfData = num;
			windowCompositionAttributeData.Data = intPtr;
			MainWindow.SetWindowCompositionAttribute(windowInteropHelper.Handle, ref windowCompositionAttributeData);
			Marshal.FreeHGlobal(intPtr);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000033C8 File Offset: 0x000015C8
		private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			this.MenuIndex = this.ListViewMenu.SelectedIndex;
			this.MoveMenuCursor(this.MenuIndex);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000033EC File Offset: 0x000015EC
		private void MoveMenuCursor(int index)
		{
			this.TransitioningContentIndicator.OnApplyTemplate();
			this.GridCursor.Margin = new Thickness(0.0, (double)(195 + 60 * index), 0.0, 0.0);
			bool flag = index == 2;
			if (flag)
			{
				this.GridCursor.Height = 52.5;
				this.GridCursor.VerticalAlignment = VerticalAlignment.Top;
			}
			else
			{
				bool flag2 = index == 3;
				if (flag2)
				{
					this.GridCursor.VerticalAlignment = VerticalAlignment.Bottom;
					this.GridCursor.Margin = new Thickness(0.0, 0.0, 0.0, 0.0);
					this.GridCursor.Height = 52.0;
				}
				else
				{
					this.GridCursor.Height = 60.0;
					this.GridCursor.VerticalAlignment = VerticalAlignment.Top;
				}
			}
			bool flag3 = index == 0;
			if (flag3)
			{
				this.Mode.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF7C7C7C");
				this.Mode.Text = "N/A";
				this.Status.Visibility = Visibility.Hidden;
				this.StatusLabel.Visibility = Visibility.Hidden;
				this.ButtonLoadScript.Visibility = Visibility.Hidden;
				this.ButtonSaveScript.Visibility = Visibility.Hidden;
				this.ButtonClearText.Visibility = Visibility.Hidden;
				this.ButtonExecuteScript.Visibility = Visibility.Hidden;
				this.ButtonReAttach.Visibility = Visibility.Hidden;
				this.ButtonKillTask.Visibility = Visibility.Hidden;
				this.LuaScreenGrid.Visibility = Visibility.Hidden;
				this.InjectorScreenGrid.Visibility = Visibility.Hidden;
				this.HomeScreenGrid.Visibility = Visibility.Visible;
				this.OptionsScreenGrid.Visibility = Visibility.Hidden;
				this.HomeScreenGrid.Height = 400.0;
				this.LuaScreenGrid.Height = 0.0;
				this.InjectorScreenGrid.Height = 0.0;
				this.OptionsScreenGrid.Height = 0.0;
			}
			else
			{
				bool flag4 = index == 1;
				if (flag4)
				{
					this.Mode.Foreground = (Brush)new BrushConverter().ConvertFromString("#FFFF0000");
					this.Mode.Text = "DLL Injector";
					this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF7C7C7C");
					this.Status.Text = "Idle";
					this.Status.Visibility = Visibility.Visible;
					this.StatusLabel.Visibility = Visibility.Visible;
					this.ButtonLoadScript.Visibility = Visibility.Hidden;
					this.ButtonSaveScript.Visibility = Visibility.Hidden;
					this.ButtonClearText.Visibility = Visibility.Hidden;
					this.ButtonExecuteScript.Visibility = Visibility.Hidden;
					this.ButtonReAttach.Visibility = Visibility.Hidden;
					this.ButtonKillTask.Visibility = Visibility.Hidden;
					this.LuaScreenGrid.Visibility = Visibility.Hidden;
					this.InjectorScreenGrid.Visibility = Visibility.Visible;
					this.HomeScreenGrid.Visibility = Visibility.Hidden;
					this.OptionsScreenGrid.Visibility = Visibility.Hidden;
					this.HomeScreenGrid.Height = 0.0;
					this.LuaScreenGrid.Height = 0.0;
					this.InjectorScreenGrid.Height = 400.0;
					this.OptionsScreenGrid.Height = 0.0;
					this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FFFFF000");
					this.Status.Text = "Loading...";
					this.procList.Items.Clear();
					this.procs.Clear();
					Process[] processes = Process.GetProcesses();
					foreach (Process process in processes)
					{
						this.procList.Items.Add(process.ProcessName + string.Format(" ({0})", process.Id));
						this.procs.Add(process.Id);
					}
					this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF7C7C7C");
					this.Status.Text = "Idle";
				}
				else
				{
					bool flag5 = index == 2;
					if (flag5)
					{
						this.Mode.Foreground = (Brush)new BrushConverter().ConvertFromString("#FFFFF000");
						this.Mode.Text = "Lua Executor";
						this.Status.Visibility = Visibility.Visible;
						this.StatusLabel.Visibility = Visibility.Visible;
						bool flag6 = this.apiInjected;
						if (flag6)
						{
							this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF00FF00");
							this.Status.Text = "Injected";
						}
						else
						{
							this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF7C7C7C");
							this.Status.Text = "Idle";
						}
						this.ButtonLoadScript.Visibility = Visibility.Visible;
						this.ButtonSaveScript.Visibility = Visibility.Visible;
						this.ButtonClearText.Visibility = Visibility.Visible;
						this.ButtonExecuteScript.Visibility = Visibility.Visible;
						this.ButtonReAttach.Visibility = Visibility.Visible;
						this.ButtonKillTask.Visibility = Visibility.Visible;
						this.LuaScreenGrid.Visibility = Visibility.Visible;
						this.InjectorScreenGrid.Visibility = Visibility.Hidden;
						this.HomeScreenGrid.Visibility = Visibility.Hidden;
						this.OptionsScreenGrid.Visibility = Visibility.Hidden;
						this.HomeScreenGrid.Height = 0.0;
						this.LuaScreenGrid.Height = 400.0;
						this.InjectorScreenGrid.Height = 0.0;
						this.OptionsScreenGrid.Height = 0.0;
					}
					else
					{
						bool flag7 = index == 3;
						if (flag7)
						{
							this.Mode.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF7C7C7C");
							this.Mode.Text = "N/A";
							this.Status.Visibility = Visibility.Hidden;
							this.StatusLabel.Visibility = Visibility.Hidden;
							this.ButtonLoadScript.Visibility = Visibility.Hidden;
							this.ButtonSaveScript.Visibility = Visibility.Hidden;
							this.ButtonClearText.Visibility = Visibility.Hidden;
							this.ButtonExecuteScript.Visibility = Visibility.Hidden;
							this.ButtonReAttach.Visibility = Visibility.Hidden;
							this.ButtonKillTask.Visibility = Visibility.Hidden;
							this.LuaScreenGrid.Visibility = Visibility.Hidden;
							this.InjectorScreenGrid.Visibility = Visibility.Hidden;
							this.HomeScreenGrid.Visibility = Visibility.Hidden;
							this.OptionsScreenGrid.Visibility = Visibility.Visible;
							this.HomeScreenGrid.Height = 0.0;
							this.LuaScreenGrid.Height = 0.0;
							this.InjectorScreenGrid.Height = 0.0;
							this.OptionsScreenGrid.Height = 400.0;
						}
					}
				}
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003B6C File Offset: 0x00001D6C
		private void ButtonExecuteScript_Click(object sender, RoutedEventArgs e)
		{
			bool flag = this.config[1] == "wrd";
			if (flag)
			{
				this.WRD.SendLuaScript(this.ScriptTextBox.Text);
			}
			else
			{
				bool flag2 = this.config[1] == "anmo";
				if (flag2)
				{
					this.ANMO.ExecuteScript(this.ScriptTextBox.Text);
				}
				else
				{
					bool flag3 = this.config[1] == "ezxp";
					if (flag3)
					{
						this.EZXP.ExecuteScript(this.ScriptTextBox.Text);
					}
					else
					{
						bool flag4 = this.config[1] == "cdrk";
						if (flag4)
						{
							this.CDRK.ExecuteScript(this.ScriptTextBox.Text);
						}
						else
						{
							bool flag5 = this.config[1] == "csq";
							if (flag5)
							{
								this.CSQ.Execute(this.ScriptTextBox.Text);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003CA4 File Offset: 0x00001EA4
		private void ButtonClearText_Click(object sender, RoutedEventArgs e)
		{
			this.ScriptTextBox.Text = "";
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003CB8 File Offset: 0x00001EB8
		private void ButtonLoadScript_Click(object sender, RoutedEventArgs e)
		{
			Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
			openFileDialog.InitialDirectory = System.IO.Path.GetFullPath("./Scripts");
			openFileDialog.Filter = "Lua File (*.lua)|*.lua|Text File (*.txt)|*.txt";
			openFileDialog.FilterIndex = 2;
			openFileDialog.RestoreDirectory = true;
			bool? flag = openFileDialog.ShowDialog();
			bool flag2 = false;
			bool flag3 = flag.GetValueOrDefault() == flag2 & flag != null;
			if (!flag3)
			{
				try
				{
					this.ScriptTextBox.Text = "";
					Stream stream;
					bool flag4 = (stream = openFileDialog.OpenFile()) == null;
					if (!flag4)
					{
						using (stream)
						{
							this.ScriptTextBox.Text = File.ReadAllText(openFileDialog.FileName);
						}
					}
				}
				catch (Exception ex)
				{
					int num = (int)System.Windows.MessageBox.Show("An unexpected error has occured", "Oof!", MessageBoxButton.OK, MessageBoxImage.Asterisk);
				}
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003DC0 File Offset: 0x00001FC0
		private void ButtonSaveScript_Click(object sender, RoutedEventArgs e)
		{
			Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
			saveFileDialog.Filter = "Lua File (*.lua)|*.lua|Text File (*.txt)|*.txt";
			saveFileDialog.FilterIndex = 1;
			saveFileDialog.RestoreDirectory = true;
			saveFileDialog.InitialDirectory = System.IO.Path.GetFullPath("./Scripts");
			bool? flag = saveFileDialog.ShowDialog();
			bool flag2 = true;
			bool flag3 = flag.GetValueOrDefault() == flag2 & flag != null;
			if (flag3)
			{
				StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName.ToString());
				streamWriter.WriteLine(this.ScriptTextBox.Text);
				streamWriter.Close();
			}
			object selectedItem = this.ScriptsListBox.SelectedItem;
			this.ScriptsListBox.SelectedItem = null;
			this.ScriptsListBox.Items.Clear();
			LocalFunctions.PopulateListBox(this.ScriptsListBox, this.ScriptsDirectory.Text, "*.txt");
			LocalFunctions.PopulateListBox(this.ScriptsListBox, this.ScriptsDirectory.Text, "*.lua");
			this.ScriptsListBox.SelectedItem = selectedItem;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003EC8 File Offset: 0x000020C8
		private void ApiType_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			string a = this.ApiType.SelectedItem.ToString();
			bool flag = a == "System.Windows.Controls.ComboBoxItem: EasyExploits";
			if (flag)
			{
				string text = "";
				string[] array = File.ReadAllLines(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"));
				array[1] = "ezxp";
				for (int i = 0; i < array.Length; i++)
				{
					text = text + array[i] + "\n";
				}
				File.WriteAllText(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"), text);
				this.config[1] = "ezxp";
			}
			else
			{
				bool flag2 = a == "System.Windows.Controls.ComboBoxItem: WeAreDevs";
				if (flag2)
				{
					string text2 = null;
					string[] array2 = File.ReadAllLines(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"));
					array2[1] = "wrd";
					for (int j = 0; j < array2.Length; j++)
					{
						text2 = text2 + array2[j] + "\n";
					}
					File.WriteAllText(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"), text2);
					this.config[1] = "wrd";
				}
				else
				{
					bool flag3 = a == "System.Windows.Controls.ComboBoxItem: Anemo (CheatSquad v2)";
					if (flag3)
					{
						string text3 = null;
						string[] array3 = File.ReadAllLines(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"));
						array3[1] = "anmo";
						for (int k = 0; k < array3.Length; k++)
						{
							text3 = text3 + array3[k] + "\n";
						}
						File.WriteAllText(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"), text3);
						this.config[1] = "anmo";
					}
					else
					{
						bool flag4 = a == "System.Windows.Controls.ComboBoxItem: ClubDark";
						if (flag4)
						{
							string text4 = null;
							string[] array4 = File.ReadAllLines(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"));
							array4[1] = "cdrk";
							for (int l = 0; l < array4.Length; l++)
							{
								text4 = text4 + array4[l] + "\n";
							}
							File.WriteAllText(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"), text4);
							this.config[1] = "cdrk";
						}
						else
						{
							bool flag5 = a == "System.Windows.Controls.ComboBoxItem: CheatSquad";
							if (flag5)
							{
								string text5 = null;
								string[] array5 = File.ReadAllLines(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"));
								array5[1] = "csq";
								for (int m = 0; m < array5.Length; m++)
								{
									text5 = text5 + array5[m] + "\n";
								}
								File.WriteAllText(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"), text5);
								this.config[1] = "csq";
							}
						}
					}
				}
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000041C4 File Offset: 0x000023C4
		private void Theme_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000041C8 File Offset: 0x000023C8
		private void AcrylicEffect_Unchecked(object sender, RoutedEventArgs e)
		{
			this.DisableBlur();
			string text = null;
			string[] array = File.ReadAllLines(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"));
			array[2] = "false";
			for (int i = 0; i < array.Length; i++)
			{
				text = text + array[i] + "\n";
			}
			File.WriteAllText(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"), text);
			this.config[2] = "flase";
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000424C File Offset: 0x0000244C
		private void AcrylicEffect_Checked(object sender, RoutedEventArgs e)
		{
			this.EnableBlur();
			string text = null;
			string[] array = File.ReadAllLines(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"));
			array[2] = "true";
			for (int i = 0; i < array.Length; i++)
			{
				text = text + array[i] + "\n";
			}
			File.WriteAllText(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"), text);
			this.config[2] = "true";
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000042D0 File Offset: 0x000024D0
		private void MainWindowOuter_Activated(object sender, EventArgs e)
		{
			bool flag = this.config[3] == "true";
			if (flag)
			{
				this.MainWindowOuter.Opacity = 1.0;
			}
			else
			{
				bool flag2 = this.config[3] == "false";
				if (flag2)
				{
				}
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004340 File Offset: 0x00002540
		private void Window_Deactivated(object sender, EventArgs e)
		{
			bool flag = this.config[3] == "true";
			if (flag)
			{
				this.MainWindowOuter.Opacity = 0.65;
			}
			else
			{
				bool flag2 = this.config[3] == "false";
				if (flag2)
				{
				}
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000043B0 File Offset: 0x000025B0
		private void ScriptsDirLabel_Click(object sender, RoutedEventArgs e)
		{
			this.MoveMenuCursor(3);
			this.ListViewMenu.SelectedIndex = 3;
			this.ScriptsDirectory.Focus();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000043D4 File Offset: 0x000025D4
		private void TextBox_LostFocus(object sender, RoutedEventArgs e)
		{
			bool flag = Directory.Exists(System.IO.Path.GetFullPath(this.ScriptsDirectory.Text));
			if (flag)
			{
				this.ScriptsListBox.SelectedItem = null;
				this.ScriptsListBox.Items.Clear();
				LocalFunctions.PopulateListBox(this.ScriptsListBox, this.ScriptsDirectory.Text, "*.txt");
				LocalFunctions.PopulateListBox(this.ScriptsListBox, this.ScriptsDirectory.Text, "*.lua");
				bool flag2 = System.IO.Path.GetFileName(System.IO.Path.GetFullPath(this.ScriptsDirectory.Text)).Length >= 9;
				string text;
				if (flag2)
				{
					text = System.IO.Path.GetFileName(System.IO.Path.GetFullPath(this.ScriptsDirectory.Text)).Substring(0, 8) + "...";
				}
				else
				{
					text = (System.IO.Path.GetFileName(System.IO.Path.GetFullPath(this.ScriptsDirectory.Text)) ?? "");
				}
				this.ScriptsDirLabel.Content = (text ?? "");
				string text2 = null;
				string[] array = File.ReadAllLines(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"));
				array[4] = (this.ScriptsDirectory.Text ?? "");
				for (int i = 0; i < array.Length; i++)
				{
					text2 = text2 + array[i] + "\n";
				}
				File.WriteAllText(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"), text2);
				this.config[4] = (this.ScriptsDirectory.Text ?? "");
			}
			else
			{
				System.Windows.MessageBox.Show("Doesn't look like that file directory exists.", "Oops!", MessageBoxButton.OK, MessageBoxImage.Hand);
				this.ScriptsDirectory.Text = "./Scripts";
				this.ScriptsDirectory.Focus();
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000045BC File Offset: 0x000027BC
		private void ScriptsDirectory_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
			bool flag = e.Key == Key.Return || e.Key == Key.Return;
			if (flag)
			{
				bool flag2 = Directory.Exists(System.IO.Path.GetFullPath(this.ScriptsDirectory.Text));
				if (flag2)
				{
					this.ScriptsListBox.SelectedItem = null;
					this.ScriptsListBox.Items.Clear();
					LocalFunctions.PopulateListBox(this.ScriptsListBox, this.ScriptsDirectory.Text, "*.txt");
					LocalFunctions.PopulateListBox(this.ScriptsListBox, this.ScriptsDirectory.Text, "*.lua");
					bool flag3 = System.IO.Path.GetFileName(System.IO.Path.GetFullPath(this.ScriptsDirectory.Text)).Length >= 13;
					string text;
					if (flag3)
					{
						text = System.IO.Path.GetFileName(System.IO.Path.GetFullPath(this.ScriptsDirectory.Text)).Substring(0, 12) + "...";
					}
					else
					{
						text = (System.IO.Path.GetFileName(System.IO.Path.GetFullPath(this.ScriptsDirectory.Text)) ?? "");
					}
					this.ScriptsDirLabel.Content = (text ?? "");
					string text2 = null;
					string[] array = File.ReadAllLines(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"));
					array[4] = (this.ScriptsDirectory.Text ?? "");
					for (int i = 0; i < array.Length; i++)
					{
						text2 = text2 + array[i] + "\n";
					}
					File.WriteAllText(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"), text2);
					this.config[4] = (this.ScriptsDirectory.Text ?? "");
				}
				else
				{
					System.Windows.MessageBox.Show("Doesn't look like that file directory exists.", "Oops!", MessageBoxButton.OK, MessageBoxImage.Hand);
					this.ScriptsDirectory.Text = "./Scripts";
					this.ScriptsDirectory.Focus();
				}
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000047CC File Offset: 0x000029CC
		private void AdvUnfocus_Unchecked(object sender, RoutedEventArgs e)
		{
			string text = null;
			string[] array = File.ReadAllLines(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"));
			array[3] = "false";
			for (int i = 0; i < array.Length; i++)
			{
				text = text + array[i] + "\n";
			}
			File.WriteAllText(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"), text);
			this.config[3] = "flase";
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004848 File Offset: 0x00002A48
		private void AdvUnfocus_Checked(object sender, RoutedEventArgs e)
		{
			string text = null;
			string[] array = File.ReadAllLines(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"));
			array[3] = "true";
			for (int i = 0; i < array.Length; i++)
			{
				text = text + array[i] + "\n";
			}
			File.WriteAllText(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"), text);
			this.config[3] = "true";
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000048C4 File Offset: 0x00002AC4
		public static void ChangeTheme(int index)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000048C8 File Offset: 0x00002AC8
		private void dllButton_Click(object sender, RoutedEventArgs e)
		{
			this.Mode.Foreground = (Brush)new BrushConverter().ConvertFromString("#FFFF0000");
			this.Mode.Text = "DLL Injector";
			this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FFFFF000");
			this.Status.Text = "Loading...";
			this.procList.Items.Clear();
			this.procs.Clear();
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				this.procList.Items.Add(process.ProcessName + string.Format(" ({0})", process.Id));
				this.procs.Add(process.Id);
			}
			this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF7C7C7C");
			this.Status.Text = "Idle";
			this.procList.Focus();
			this.ListViewMenu.SelectedIndex = 1;
			this.MoveMenuCursor(1);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004A14 File Offset: 0x00002C14
		private void luaButton_Click(object sender, RoutedEventArgs e)
		{
			bool flag = this.config[5] == "true";
			if (flag)
			{
				bool flag2 = this.apiInjected;
				if (flag2)
				{
					this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF00FF00");
					this.Status.Text = "Injected";
				}
				else
				{
					this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF7C7C7C");
					this.Status.Text = "Idle";
				}
				bool flag3 = this.config[1] == "wrd";
				if (flag3)
				{
					this.WRD.LaunchExploit();
					Thread.Sleep(750);
					bool flag4 = this.WRD.isAPIAttached();
					if (flag4)
					{
						this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF00FF00");
						this.Status.Text = "Injected";
						this.apiInjected = true;
						this.ButtonReAttach.ToolTip = new System.Windows.Controls.ToolTip
						{
							Content = "Re-Attach API"
						};
						this.MoveMenuCursor(2);
						this.ListViewMenu.SelectedIndex = 2;
					}
					else
					{
						this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF7C7C7C");
						this.Status.Text = "Idle";
						this.apiInjected = false;
					}
				}
				else
				{
					bool flag5 = this.config[1] == "ezxp";
					if (flag5)
					{
						this.EZXP.LaunchExploit();
						bool flag6 = !DllPipes.NamedPipeExist("ocybedam");
						if (flag6)
						{
							Thread.Sleep(5000);
						}
						bool flag7 = DllPipes.NamedPipeExist("ocybedam");
						if (flag7)
						{
							this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF00FF00");
							this.Status.Text = "Injected";
							this.apiInjected = true;
							this.ButtonReAttach.ToolTip = new System.Windows.Controls.ToolTip
							{
								Content = "Re-Attach API"
							};
							this.MoveMenuCursor(2);
							this.ListViewMenu.SelectedIndex = 2;
						}
						else
						{
							this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF7C7C7C");
							this.Status.Text = "Idle";
							this.apiInjected = false;
						}
					}
					else
					{
						bool flag8 = this.config[1] == "ezxp";
						if (flag8)
						{
							this.ANMO.InjectAnemo();
							bool flag9 = !DllPipes.NamedPipeExist("AnemoPIPE");
							if (flag9)
							{
								Thread.Sleep(5000);
							}
							bool flag10 = DllPipes.NamedPipeExist("AnemoPIPE");
							if (flag10)
							{
								this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF00FF00");
								this.Status.Text = "Injected";
								this.apiInjected = true;
								this.ButtonReAttach.ToolTip = new System.Windows.Controls.ToolTip
								{
									Content = "Re-Attach API"
								};
								this.MoveMenuCursor(2);
								this.ListViewMenu.SelectedIndex = 2;
							}
							else
							{
								this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF7C7C7C");
								this.Status.Text = "Idle";
								this.apiInjected = false;
							}
						}
						else
						{
							bool flag11 = this.config[1] == "cdrk";
							if (flag11)
							{
								this.CDRK.LaunchExploit();
								bool flag12 = !DllPipes.NamedPipeExist("zxc");
								if (flag12)
								{
									Thread.Sleep(5000);
								}
								bool flag13 = DllPipes.NamedPipeExist("zxc");
								if (flag13)
								{
									this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF00FF00");
									this.Status.Text = "Injected";
									this.apiInjected = true;
									this.ButtonReAttach.ToolTip = new System.Windows.Controls.ToolTip
									{
										Content = "Re-Attach API"
									};
									this.MoveMenuCursor(2);
									this.ListViewMenu.SelectedIndex = 2;
								}
								else
								{
									this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF7C7C7C");
									this.Status.Text = "Idle";
									this.apiInjected = false;
								}
							}
							else
							{
								bool flag14 = this.config[1] == "csq";
								if (flag14)
								{
									try
									{
										this.CSQ.Attach();
									}
									catch (Exception arg)
									{
										System.Windows.MessageBox.Show("Error", string.Format("{0}", arg), MessageBoxButton.OK, MessageBoxImage.Hand);
									}
									bool flag15 = !DllPipes.NamedPipeExist("taStqdau1Ch1ee33");
									if (flag15)
									{
										Thread.Sleep(5000);
									}
									bool flag16 = DllPipes.NamedPipeExist("taStqdau1Ch1ee33");
									if (flag16)
									{
										this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF00FF00");
										this.Status.Text = "Injected";
										this.apiInjected = true;
										this.ButtonReAttach.ToolTip = new System.Windows.Controls.ToolTip
										{
											Content = "Re-Attach API"
										};
										this.MoveMenuCursor(2);
										this.ListViewMenu.SelectedIndex = 2;
									}
									else
									{
										this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF7C7C7C");
										this.Status.Text = "Idle";
										this.apiInjected = false;
									}
								}
							}
						}
					}
				}
			}
			else
			{
				this.MoveMenuCursor(2);
				this.ListViewMenu.SelectedIndex = 2;
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00005050 File Offset: 0x00003250
		private void ButtonReAttach_Click(object sender, RoutedEventArgs e)
		{
			bool flag = this.config[1] == "wrd";
			if (flag)
			{
				this.WRD.LaunchExploit();
				Thread.Sleep(750);
				bool flag2 = this.WRD.isAPIAttached();
				if (flag2)
				{
					this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF00FF00");
					this.Status.Text = "Injected";
					this.apiInjected = true;
					this.ButtonReAttach.ToolTip = new System.Windows.Controls.ToolTip
					{
						Content = "Re-Attach API"
					};
				}
				else
				{
					this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF7C7C7C");
					this.Status.Text = "Idle";
					this.apiInjected = false;
				}
			}
			else
			{
				bool flag3 = this.config[1] == "anmo";
				if (flag3)
				{
					this.ANMO.InjectAnemo();
					Thread.Sleep(750);
					bool flag4 = this.ANMO.IsInjected();
					if (flag4)
					{
						this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF00FF00");
						this.Status.Text = "Injected";
						this.apiInjected = true;
						this.ButtonReAttach.ToolTip = new System.Windows.Controls.ToolTip
						{
							Content = "Re-Attach API"
						};
					}
					else
					{
						this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF7C7C7C");
						this.Status.Text = "Idle";
						this.apiInjected = false;
					}
				}
				else
				{
					bool flag5 = this.config[1] == "ezxp";
					if (flag5)
					{
						this.EZXP.LaunchExploit();
						bool flag6 = !DllPipes.NamedPipeExist("ocybedam");
						if (flag6)
						{
							Thread.Sleep(5000);
						}
						bool flag7 = DllPipes.NamedPipeExist("ocybedam");
						if (flag7)
						{
							this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF00FF00");
							this.Status.Text = "Injected";
							this.apiInjected = true;
							this.ButtonReAttach.ToolTip = new System.Windows.Controls.ToolTip
							{
								Content = "Re-Attach API"
							};
						}
						else
						{
							this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF7C7C7C");
							this.Status.Text = "Idle";
							this.apiInjected = false;
						}
					}
					else
					{
						bool flag8 = this.config[1] == "cdrk";
						if (flag8)
						{
							this.CDRK.LaunchExploit();
							bool flag9 = !DllPipes.NamedPipeExist("zxc");
							if (flag9)
							{
								Thread.Sleep(5000);
							}
							bool flag10 = DllPipes.NamedPipeExist("zxc");
							if (flag10)
							{
								this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF00FF00");
								this.Status.Text = "Injected";
								this.apiInjected = true;
								this.ButtonReAttach.ToolTip = new System.Windows.Controls.ToolTip
								{
									Content = "Re-Attach API"
								};
							}
							else
							{
								this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF7C7C7C");
								this.Status.Text = "Idle";
								this.apiInjected = false;
							}
						}
						else
						{
							bool flag11 = this.config[1] == "csq";
							if (flag11)
							{
								try
								{
									this.CSQ.Attach();
								}
								catch (Exception arg)
								{
									System.Windows.MessageBox.Show("Error", string.Format("{0}", arg), MessageBoxButton.OK, MessageBoxImage.Hand);
								}
								bool flag12 = !DllPipes.NamedPipeExist("taStqdau1Ch1ee33");
								if (flag12)
								{
									Thread.Sleep(5000);
								}
								bool flag13 = DllPipes.NamedPipeExist("taStqdau1Ch1ee33");
								if (flag13)
								{
									this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF00FF00");
									this.Status.Text = "Injected";
									this.apiInjected = true;
									this.ButtonReAttach.ToolTip = new System.Windows.Controls.ToolTip
									{
										Content = "Re-Attach API"
									};
								}
								else
								{
									this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF7C7C7C");
									this.Status.Text = "Idle";
									this.apiInjected = false;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00005554 File Offset: 0x00003754
		private void refProcList_Click(object sender, RoutedEventArgs e)
		{
			this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FFFFF000");
			this.Status.Text = "Loading...";
			this.procList.Items.Clear();
			this.procs.Clear();
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				this.procList.Items.Add(process.ProcessName + string.Format(" ({0})", process.Id));
				this.procs.Add(process.Id);
			}
			this.Status.Foreground = (Brush)new BrushConverter().ConvertFromString("#FF7C7C7C");
			this.Status.Text = "Idle";
			this.procList.Focus();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005658 File Offset: 0x00003858
		private void addDll_Click(object sender, RoutedEventArgs e)
		{
			Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
			openFileDialog.InitialDirectory = System.IO.Path.GetFullPath("./DLLs");
			openFileDialog.Filter = "Dynamic Library Link File (*.dll)|*.dll";
			openFileDialog.FilterIndex = 1;
			openFileDialog.RestoreDirectory = true;
			bool? flag = openFileDialog.ShowDialog();
			bool flag2 = false;
			bool flag3 = flag.GetValueOrDefault() == flag2 & flag != null;
			if (!flag3)
			{
				try
				{
					string fileName = openFileDialog.FileName;
					this.dlls.Add(fileName);
					this.dllNamesList.Items.Add(System.IO.Path.GetFileName(fileName));
					bool flag4 = BasicInject.GetDllMachineType(fileName).Equals(BasicInject.MachineType.IMAGE_FILE_MACHINE_I386);
					if (flag4)
					{
						System.Windows.Controls.ListViewItem listViewItem = new System.Windows.Controls.ListViewItem();
						listViewItem.Content = "32bit";
						listViewItem.Focusable = false;
						listViewItem.IsEnabled = false;
						this.dllTypesList.Items.Add(listViewItem);
					}
					else
					{
						bool flag5 = BasicInject.GetDllMachineType(fileName).Equals(BasicInject.MachineType.IMAGE_FILE_MACHINE_IA64);
						if (flag5)
						{
							System.Windows.Controls.ListViewItem listViewItem2 = new System.Windows.Controls.ListViewItem();
							listViewItem2.Content = "64bit";
							listViewItem2.Focusable = false;
							listViewItem2.IsEnabled = false;
							this.dllTypesList.Items.Add(listViewItem2);
						}
					}
				}
				catch (Exception arg)
				{
					int num = (int)System.Windows.MessageBox.Show("An unexpected error has occured", string.Format("{0}", arg), MessageBoxButton.OK, MessageBoxImage.Asterisk);
				}
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00005804 File Offset: 0x00003A04
		private void rmvDll_Click(object sender, RoutedEventArgs e)
		{
			bool flag = this.dllNamesList.Items.Count <= 0;
			if (!flag)
			{
				try
				{
					this.dlls.RemoveAt(this.dllNamesList.SelectedIndex);
					this.dllTypesList.Items.RemoveAt(this.dllNamesList.SelectedIndex);
					this.dllNamesList.Items.RemoveAt(this.dllNamesList.SelectedIndex);
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000058A4 File Offset: 0x00003AA4
		private void clrDlls_Click(object sender, RoutedEventArgs e)
		{
			this.dlls.Clear();
			this.dllTypesList.Items.Clear();
			this.dllNamesList.Items.Clear();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000058E4 File Offset: 0x00003AE4
		private void injectButton_Click(object sender, RoutedEventArgs e)
		{
			int num = 0;
			foreach (string text in this.dlls)
			{
				BasicInject.InjectDLL(this.procs[this.procList.SelectedIndex], this.dlls[num]);
				num++;
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000596C File Offset: 0x00003B6C
		private void procList_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			ListBoxItem listBoxItem = new ListBoxItem();
			listBoxItem.Content = this.procList.SelectedValue;
			listBoxItem.Foreground = (Brush)new BrushConverter().ConvertFromString("#DDFFFFFF");
			this.procList.ToolTip = new System.Windows.Controls.ToolTip
			{
				Content = this.procList.SelectedValue
			};
			this.procList.SelectedItem = listBoxItem;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000059E4 File Offset: 0x00003BE4
		private void configInjector_Click(object sender, RoutedEventArgs e)
		{
			System.Windows.MessageBox.Show("Injector Configuration Settings coming in v2.1", "Feature Not Availible", MessageBoxButton.OK, MessageBoxImage.Asterisk);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000059FC File Offset: 0x00003BFC
		private void about_Click(object sender, RoutedEventArgs e)
		{
			Process.Start("https://www.316tb.dev/#magma-iae");
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00005A0C File Offset: 0x00003C0C
		private void webSite_Click(object sender, RoutedEventArgs e)
		{
			Process.Start("https://www.316tb.dev/");
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00005A1C File Offset: 0x00003C1C
		private void gitHub_Click(object sender, RoutedEventArgs e)
		{
			Process.Start("https://github.com/Not316tb/");
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00005A2C File Offset: 0x00003C2C
		private void discUrl_Click(object sender, RoutedEventArgs e)
		{
			Process.Start("https://discord.gg/rpaF3hKrC7");
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00005A3C File Offset: 0x00003C3C
		private void atchFromHome_Unchecked(object sender, RoutedEventArgs e)
		{
			string text = null;
			string[] array = File.ReadAllLines(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"));
			array[5] = "false";
			for (int i = 0; i < array.Length; i++)
			{
				text = text + array[i] + "\n";
			}
			File.WriteAllText(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"), text);
			this.config[5] = "flase";
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00005AB8 File Offset: 0x00003CB8
		private void atchFromHome_Checked(object sender, RoutedEventArgs e)
		{
			string text = null;
			string[] array = File.ReadAllLines(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"));
			array[5] = "true";
			for (int i = 0; i < array.Length; i++)
			{
				text = text + array[i] + "\n";
			}
			File.WriteAllText(System.IO.Path.GetFullPath("config ( DO NOT EDIT! ).txt"), text);
			this.config[5] = "true";
		}

		// Token: 0x0400001A RID: 26
		private EasyExploits.Module EZXP = new EasyExploits.Module();

		// Token: 0x0400001B RID: 27
		private WeAreDevs_API.ExploitAPI WRD = new WeAreDevs_API.ExploitAPI();

		// Token: 0x0400001C RID: 28
		private ClubDarkAPI.ExploitAPI CDRK = new ClubDarkAPI.ExploitAPI();

		// Token: 0x0400001D RID: 29
		private CheatSquadAPI.Module CSQ = new CheatSquadAPI.Module();

		// Token: 0x0400001E RID: 30
		private Anemo ANMO = new Anemo();

		// Token: 0x0400001F RID: 31
		private uint _blurOpacity;

		// Token: 0x04000020 RID: 32
		private string[] config;

		// Token: 0x04000021 RID: 33
		private List<string> dlls = new List<string>();

		// Token: 0x04000022 RID: 34
		private List<int> procs = new List<int>();

		// Token: 0x04000023 RID: 35
		private uint _blurBackgroundColor = 10027008U;

		// Token: 0x04000024 RID: 36
		private bool apiInjected = false;

		// Token: 0x04000025 RID: 37
		private bool setTopClicked = false;

		// Token: 0x04000026 RID: 38
		private int MenuIndex = 0;

		// Token: 0x04000027 RID: 39
		private Window window;
	}
}
