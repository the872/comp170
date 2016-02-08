using System;

namespace IntroCS
{
	class StringManip
	{
		static void Main()
		{
			Game();
		}


		static void Game()
		{
			int big = 0;
			int small = 1;
			int guesses = 0;
			big = UIF.PromptInt ("What do you want the highest number to be?" + "\n");			 
			Random r = new Random();
			int secret = r.Next(small, big);
			int guess = UIF.PromptInt ("Guess the number between " + small + " and " + big + "." + "\n");
			bool right = false;
			bool playag = false; 

			while (right != true) {
				guesses++;
				if (guess == secret) {
					playag = UIF.Agree ("That's right!" + "\n" + "It took you " + guesses + " guesses." + "\n" + "Press 'y' to play again or 'q' to quit" + "\n");
					right = true;
				} else if (guess > secret) {
					guess = UIF.PromptInt ("A little lower!" + "\n");	
				} else if (guess < secret){
					guess = UIF.PromptInt ("A little higher!" + "\n");
				}
			}

			if (playag == true) {
				Game ();
			} else {
				Environment.Exit (0);
			}


		}
	}
}