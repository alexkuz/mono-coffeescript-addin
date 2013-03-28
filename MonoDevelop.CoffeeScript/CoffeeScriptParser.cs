using System;
using MonoDevelop.Ide.TypeSystem;

namespace MonoDevelop.CoffeeScript
{
	public class CoffeeScriptParser : TypeSystemParser
	{
		public override ParsedDocument Parse (bool storeAst, string fileName, System.IO.TextReader content, MonoDevelop.Projects.Project project = null)
		{
			throw new NotImplementedException ();
		}
	}
}

