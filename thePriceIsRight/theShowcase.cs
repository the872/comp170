//use http://en.wikipedia.org/wiki/The_Price_Is_Right_(U.S._game_show)#The_Showcase as reference

using System;

namespace IntroCS
{
	class theShowcase : IGame
	{
		public theShowcase()
		{
			//this is empty unless parameters are added
		}

		// Play all games and keep score.
		public int Play()  
		{
			//put in the code for this game here
			int score = 0;//keeps track of score and is set to zero

			Console.WriteLine ("Great round! Get ready for the final round, The Showcase!");
			//Console.WriteLine ("Add directions here?");


			return score; //must return int score 
		}
	}
}

