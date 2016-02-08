using System;

namespace IntroCS
{
	class Grade
	{                        // function chunk
		/// Return letter grade for score. 
		static char letterGrade(double score)
		{
			char letter;
			if (score < 60) {
				letter = 'F';
			}
			else if (score < 70) { 
				letter = 'D';
			}
			else if (score < 80) { 
				letter = 'C';
			}
			else if (score < 90) { 
				letter = 'B';
			}
			else {
				letter = 'A';
			}
			return letter;
		}
		// end of function chunk
		static void Main()
		{
			Console.WriteLine("Your letter grade is {0}.", letterGrade(88));
			Console.WriteLine("Your letter grade is {0}.", letterGrade(90));
			Console.WriteLine("Your letter grade is {0}.", letterGrade(78));
			Console.WriteLine("Your letter grade is {0}.", letterGrade(68));
			Console.WriteLine("Your letter grade is {0}.", letterGrade(58));
			double g = UIF.PromptDouble("Enter a numerical grade: ");
			Console.WriteLine("Your letter grade is {0}.", letterGrade(g));
		}
	}
}