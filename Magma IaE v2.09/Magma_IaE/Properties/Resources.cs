using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Magma_IaE.Properties
{
	// Token: 0x0200000C RID: 12
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00006424 File Offset: 0x00004624
		internal Resources()
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00006430 File Offset: 0x00004630
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("Magma_IaE.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00006480 File Offset: 0x00004680
		// (set) Token: 0x0600004C RID: 76 RVA: 0x000064A0 File Offset: 0x000046A0
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

		// Token: 0x0400005C RID: 92
		private static ResourceManager resourceMan;

		// Token: 0x0400005D RID: 93
		private static CultureInfo resourceCulture;
	}
}
