using System;

namespace IntroCS
{
	class congress
	{
		static string checkGraduation (int age, int citzenship)
		{
			if (age >= 30) {
				if (citzenship >= 9) {
					return "You can a Representative and a Senator.";
				} else if (citzenship >= 7) {
					return "You can a Representative only.";
				} else {
					return "You are not elgible to be anything.";
				}
			} else if (age >= 25) {
				if (citzenship >= 7) {
					return "You can be Representative only.";
				} else {
					return "You are not elgible to be anything";
				}	
			} else {
				return "You are not elgible to be anything";
			}
		}
		static void Main ()
		{
			int age = UIF.PromptInt("Enter your age ");
			int citizen = UIF.PromptInt("Enter how many years you have been a citizen: ");
			string ans = checkGraduation (age, citizen);
			Console.WriteLine (ans);

		}
	}
}
