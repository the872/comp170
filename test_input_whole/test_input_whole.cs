using System;
namespace IntroCS
{
	class TestInputWhole  // stub for InputWhole
	{    
		public static void Main() //testing routine
		{
			int n = PromptWhole("Enter a whole number: ");

			Console.WriteLine("The number is {0}.", n);
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

		/// Return a whole number.  Catch input
		/// errors, and keep prompting the user until
		/// a legal entry is made, and return
		/// the corresponding int.  Trim extra whitespace.
		static int PromptWhole(string prompt)
		{
			int done = 0;
			int x = 0;

			while (done == 0) {
				prompt = UIF.PromptLine ("Enter a whole number: ");

				string prmt = prompt.Trim(); //this removes the blank space at the start and ends

				//below is a while loop that replaces spaces inbetween ints with no spaces
				int i = 0;
				while (i < prompt.Length) {
					if (prompt[i].Equals(" ")) {
						prompt.Replace (" ", "");
						}
					i++;
				}

				if (IsDigits (prmt) == true) {
					x = int.Parse (prompt);

					if (x >= 0) {
						done = 1;
						return x;
					} else {
						Console.Write ("There has been an error (1)" + "\n");
						x = PromptWhole ("Enter a whole number: ");
						done = 0;
					}

				} else {
					Console.Write ("There has been an error (2)" + "\n");
					x = PromptWhole ("Enter a whole number: ");
					done = 0;
				}

			}
			return x;
		}
	}
}