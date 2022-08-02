using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace CheatSquadAPI.Properties
{
	// Token: 0x02000012 RID: 18
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000067 RID: 103 RVA: 0x00006C64 File Offset: 0x00004E64
		internal Resources()
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00006C6C File Offset: 0x00004E6C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("CheatSquadAPI.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00006C9C File Offset: 0x00004E9C
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00006CA4 File Offset: 0x00004EA4
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x04000064 RID: 100
		private static ResourceManager resourceMan;

		// Token: 0x04000065 RID: 101
		private static CultureInfo resourceCulture;
	}
}
