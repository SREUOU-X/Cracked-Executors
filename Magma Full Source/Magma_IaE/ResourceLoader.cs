using System;
using System.IO;
using System.Xml;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;

namespace Magma_IaE
{
	// Token: 0x0200000B RID: 11
	public static class ResourceLoader
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00006398 File Offset: 0x00004598
		public static IHighlightingDefinition LoadHighlightingDefinition(string resourceName)
		{
			Type typeFromHandle = typeof(ResourceLoader);
			string name = typeFromHandle.Namespace + "." + resourceName;
			IHighlightingDefinition result;
			using (Stream manifestResourceStream = typeFromHandle.Assembly.GetManifestResourceStream(name))
			{
				using (XmlTextReader xmlTextReader = new XmlTextReader(manifestResourceStream))
				{
					result = HighlightingLoader.Load(xmlTextReader, HighlightingManager.Instance);
				}
			}
			return result;
		}
	}
}
