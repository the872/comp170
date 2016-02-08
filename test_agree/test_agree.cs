using System;
namespace IntroCS
{
	class TestAgree  
	{

		public static void Main() //testing routine
		{
			Console.WriteLine(Agree("Do you understand?"));
		}

		/// Prompt the user with a question; Return true of false.
		/// Allow certain starting characters for true (t, y) and
		/// others for false (f, n), and repeat until the response
		/// is in one of these groups.
		static Boolean Agree (string question)
		{
			int done = 0;
			question = UIF.PromptLine("Do you understand? Use 'y' or 'n'." + "\n");

			while (done == 0) {
				string res = question.ToLower ();

				if (res.Length == 0) {
					res = UIF.PromptLine ("Please enter a response. Use 'y' or 'n'." + "\n");
					return false;
				} else if ((res != "y") || (res != "n")) {
					res = UIF.PromptLine ("Try again, we didn't understand your request. Use 'y' or 'n'." + "\n");
				}

				if (res == "y") {
					done = 1;  
					return true;  
				} else if (res == "n") {
					done = 1;
					return false;
				} 
			}
			return true;
		}
		

	}
}                                          