using System;
using MonoDevelop.Projects;
using MonoDevelop.Core;


namespace MonoDevelop.CoffeeScript
{
	public class CoffeeScriptLanguageBinding : IDotNetLanguageBinding
	{
		public CoffeeScriptLanguageBinding ()
		{
		}

		#region ILanguageBinding implementation
		public bool IsSourceCodeFile(MonoDevelop.Core.FilePath fileName)
		{
			return fileName.Extension == ".coffee";
		}

		public MonoDevelop.Core.FilePath GetFileName(MonoDevelop.Core.FilePath fileNameWithoutExtension)
		{
			var file = new FilePath (fileNameWithoutExtension.FileNameWithoutExtension + ".coffee");
			return file;
		}

		public string Language {
			get {
				return "CoffeeScript";
			}
		}

		public string SingleLineCommentTag {
			get {
				return "#";
			}
		}

		public string BlockCommentStartTag {
			get {
				return "###";
			}
		}

		public string BlockCommentEndTag {
			get {
				return "###";
			}
		}
		#endregion

		#region IDotNetLanguageBinding implementation
		public ConfigurationParameters CreateCompilationParameters(System.Xml.XmlElement projectOptions)
		{
			return null;
		}

		public ProjectParameters CreateProjectParameters(System.Xml.XmlElement projectOptions)
		{
			var projParams = new ProjectParameters ();
			return projParams;
		}

		public BuildResult Compile(ProjectItemCollection items, DotNetProjectConfiguration configuration, ConfigurationSelector configSelector, MonoDevelop.Core.IProgressMonitor monitor)
		{
			return new BuildResult ("ok", 1, 0);
		}

		public ClrVersion[] GetSupportedClrVersions()
		{
			return new ClrVersion[] { ClrVersion.Net_1_1, ClrVersion.Net_2_0, ClrVersion.Clr_2_1, ClrVersion.Net_4_0, ClrVersion.Net_4_5 };
		}

		public System.CodeDom.Compiler.CodeDomProvider GetCodeDomProvider()
		{
			return null;
		}

		public string ProjectStockIcon {
			get {
				return "MonoDevelop.CoffeeScript.FileIcon";
			}
		}
		#endregion

	}
}

