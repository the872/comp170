using System;

namespace IntroCS
{
	class sum_all
	{
		public static void Main (string[] args)
		{
			addOne ();
		}
		static void addOne ()
		{
			int sum = 0;
			int one = UIF.PromptInt ("Enter one number at a time and I will add them up." + "\n" + "When you are done, enter '0'." + "\n");

			while( one != 0 ){

				sum += one;
				one = UIF.PromptInt ("Please enter another number. Remember to end press '0'." + "\n");

			}
			Console.Write ("Your total is: " + sum + ".");
		}
	}
}
