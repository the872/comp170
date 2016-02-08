using System;

namespace getTokens
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write(GetTokens ("  extra  spaces "));
		}

		///Return an array with the string split at blanks
		/// into positive length tokens.
		/// Example:  GetTokens("  extra  spaces ") returns an
		/// array containing {"extra", "spaces"}
		public static string[] GetTokens(string s)
		{
			string[] integers = s.Split(' ');
			return integers;
		}
	}
}
