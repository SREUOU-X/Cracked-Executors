using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Kraken.Properties
{
	// Token: 0x02000007 RID: 7
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00004734 File Offset: 0x00002934
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04000028 RID: 40
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
