using System;

namespace IntroCS
{                           
	class GuessGame : IGame //OOP version of Game from static_version
	{
		private static Random r = new Random();
		private int big;  // moved to instance variable

		public GuessGame(int big)
		{
			this.big = big; // need this. to access same-named instance variable
		}

		public int Play()  // Not static!  No explicit parameter
		{
			int points = 19;
			int secret = r.Next(big);    // use instance variable
			int guesses = 1;
			Console.WriteLine("Guess a number less than {0}.", big);
			int guess = UI.PromptInt("Next guess: ");
			while (secret != guess) {
				if (guess < secret) {
					Console.WriteLine("Too small!");
				} else {
					Console.WriteLine("Too big!");            
				}
				guess = UI.PromptInt("Next guess: ");
				points--;
				guesses++;
			}
			Console.WriteLine("You won on guess {0}!", guesses);
			Console.WriteLine ("Your score is {0}.", points);
			return points;
		}
	}
}           