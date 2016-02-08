using System;

namespace IntroCS
{
	class graduate
	{
		static string totalCredits (int current)
		{
			if (current >= 120) {
				return "You do";
			} else {
				return "You do not";
			}
		}
		static void Main()
		{
			int hours = UIF.PromptInt("Enter total amount of credits: ");
				string ans = totalCredits (hours);
			Console.WriteLine(
					"{0} have enough credits to graduate.",
					ans);
		}
	}
}
