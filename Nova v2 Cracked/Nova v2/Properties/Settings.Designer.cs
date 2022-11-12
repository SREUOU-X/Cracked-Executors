using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Nova_v2.Properties
{
	// Token: 0x02000008 RID: 8
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.3.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00006E10 File Offset: 0x00005010
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00006E28 File Offset: 0x00005028
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00006E4A File Offset: 0x0000504A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Email
		{
			get
			{
				return (string)this["Email"];
			}
			set
			{
				this["Email"] = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00006E5C File Offset: 0x0000505C
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00006E7E File Offset: 0x0000507E
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string User
		{
			get
			{
				return (string)this["User"];
			}
			set
			{
				this["User"] = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00006E90 File Offset: 0x00005090
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00006EB2 File Offset: 0x000050B2
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Pass
		{
			get
			{
				return (string)this["Pass"];
			}
			set
			{
				this["Pass"] = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00006EC4 File Offset: 0x000050C4
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00006EE6 File Offset: 0x000050E6
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string LogCheck
		{
			get
			{
				return (string)this["LogCheck"];
			}
			set
			{
				this["LogCheck"] = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00006EF8 File Offset: 0x000050F8
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00006F1A File Offset: 0x0000511A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string TokenID
		{
			get
			{
				return (string)this["TokenID"];
			}
			set
			{
				this["TokenID"] = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00006F2C File Offset: 0x0000512C
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00006F4E File Offset: 0x0000514E
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string ScriptSaver
		{
			get
			{
				return (string)this["ScriptSaver"];
			}
			set
			{
				this["ScriptSaver"] = value;
			}
		}

		// Token: 0x0400003C RID: 60
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
