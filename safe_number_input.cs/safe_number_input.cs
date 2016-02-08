using System;
namespace IntroCS
{
	class SafeNumberInput  //versions with fault tolerance
	{     
		static void Main() //testing routine
		{
			string maybeNum = UIF.PromptLine("Enter a number, maybe: ");
			Console.WriteLine("{0}: Is it a legal int? {1}.  A double? {2}",
				maybeNum, IsIntString(maybeNum), IsDecimalString(maybeNum));
			int n = PromptInt("Enter a score: ");
			Console.WriteLine("Your score is {0}.", n);
			double x = PromptDouble("Enter a decimal number: ");
			Console.WriteLine("Your number is {0}.", x);
		}

		/// Return true if s contains one or more digits
		/// and nothing else. Otherwise return false.
		static Boolean IsDigits(string s)
		{
			int i = 0;
			while (i < s.Length) {
				if (s[i] < '0' || s[i] > '9') {
					return false;
				}
				i++;
			}
			return (s.Length > 0);
		}

		/// Return true when s is a legal int string,
		/// and return false otherwise.
		static bool IsIntString(string s)
		{
			int num;
			if (Int32.TryParse(s, out num) == true)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// Return an int entered by the user.  Catch input
		/// errors, and keep promping the user until a
		/// legal entry is made.  Return the corresponding int.  
		static int PromptInt(string prompt)  
		{ //FIX so loops until legal
			int ans = 0;
			while (IsIntString (prompt) != true) {
				string nStr = UIF.PromptLine (prompt).Trim (); 
				ans = int.Parse (nStr);
			}
			return ans;
		}

		/// Return true when s is a legal decimal string,
		/// and return false otherwise.
		static bool IsDecimalString(string s)
		{
			decimal value;
			if (Decimal.TryParse (s, out value)) {
				return true;
			} else {
				return false;
			}
		}

		/// Return a double entered by the user.  Catch input
		/// errors, and keep promping the user until a legal
		/// decimal entry is made.  Return the corresponding double.  .
		static double PromptDouble(string prompt)  
		{  //FIX so loops until legal
			double ans = 0.00;
			while (IsDecimalString (prompt) != true) {
				string nStr = UIF.PromptLine (prompt).Trim (); 
				ans = double.Parse (nStr);
			}
			return ans;
		}
	}
}