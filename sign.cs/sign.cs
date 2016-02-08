using System;
namespace IntroCS
{
	class SignExercise
	{
		static string posNegZero(int x)
		{
			string sentence;

			if (x == 0)
			{
				 sentence = "Zero";
			}
			else if (x > 0)
			{
				 sentence = "Positive";
			}
			else
			{
				 sentence = "Negative";
			}

			return sentence;
		}

		static void Main()
		{
			posNegZero (10);
			int a = UIF.PromptInt("Enter an integer: "); 
			Console.WriteLine(posNegZero(a));
		}
	}
}
