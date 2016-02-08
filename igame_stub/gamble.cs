using System;

namespace IntroCS
{
	class Gamble : IGame  // note :IGame  !!
	{
		private Random rand = new Random ();
		// Constructor for objects of class AdditionGame
		public Gamble ()
		{

		}
		// Play all games and keep score.
		public int Play ()  // exactly matches heading in Game interface
		{
			int score = 8;
	
			bool prompt = UI.Agree ("You are given given 8 points. Want to play heads or tails?" + "\n" +
				"You will play with those 8 points." + "\n" +
				"If you guess the number you double your 8 points. If not," + "\n" + 
				"you lose 4 of your total points." + "\n" + 
				"y or n?" + "\n");


			if (prompt == false) {
				Console.WriteLine (" ");
				Console.WriteLine ("Oh well, here are your 8 points.");  

			}

			if (prompt != false) {
				Console.WriteLine (" ");
				int guess = rand.Next (2);
				int promptNum = UI.PromptInt ("Press 1 for heads, 2 for tails" + "\n");

				Console.WriteLine (" ");
						
				if (promptNum == guess) {
					Console.WriteLine ("You got it!");
					score *= 2;
					Console.WriteLine ("You got {0} points.", score);
				} else {
					Console.WriteLine ("Sorry, you didn't get it.");
					score = -4; 
					Console.WriteLine("You got {0} points.", score);
				}
				Console.WriteLine (" ");
			}
					
			return score;    
		}
	}
}
