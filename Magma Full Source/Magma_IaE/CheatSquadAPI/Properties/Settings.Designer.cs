using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace CheatSquadAPI.Properties
{
	// Token: 0x02000013 RID: 19
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.5.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00006CAC File Offset: 0x00004EAC
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04000066 RID: 102
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
