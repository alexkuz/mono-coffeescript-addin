using System;
using MonoDevelop.CoffeeScript;
using System.Text.RegularExpressions;

namespace TestCoffeeScript
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine ("Hello World!");
			var syntaxMode = new CoffeeScriptSyntaxMode ();
			Console.WriteLine ("syntax mode created");
			var r = new Regex ("^(?:.*)->");
			Console.WriteLine (r.Match ("constructor: -> ").Success);
		}
	}
}
