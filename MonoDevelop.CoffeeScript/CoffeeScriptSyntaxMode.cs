using System;
using Mono.TextEditor.Highlighting;
using System.Xml;
using Mono.TextEditor;

namespace MonoDevelop.CoffeeScript
{
	public class CoffeeScriptSyntaxMode : SyntaxMode
	{
		public CoffeeScriptSyntaxMode () : base ()
		{
			Init ();
		}

		public CoffeeScriptSyntaxMode (TextDocument doc) : base (doc) 
		{ 
			Init (); 
		}

		void Init ()
		{
			var provider = new ResourceXmlProvider (typeof (CoffeeScriptSyntaxMode).Assembly, "MonoDevelop.CoffeeScript.CoffeeScriptSyntaxMode.xml");
    		using (var reader = provider.Open()) {
				var baseMode = SyntaxMode.Read (reader);

				this.rules = new System.Collections.Generic.List<Rule> (baseMode.Rules);
				this.keywords = new System.Collections.Generic.List<Mono.TextEditor.Highlighting.Keywords> (baseMode.Keywords);
				this.spans = baseMode.Spans;
				this.matches = baseMode.Matches;
				this.prevMarker = baseMode.PrevMarker;
				this.SemanticRules = new System.Collections.Generic.List<Mono.TextEditor.SemanticRule>(baseMode.SemanticRules);
				this.keywordTable = baseMode.keywordTable;
				this.properties = baseMode.Properties;
			}
		}
	}
}

