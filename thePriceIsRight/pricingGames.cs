//use http://en.wikipedia.org/wiki/The_Price_Is_Right_(U.S._game_show)#Pricing_games as reference

using System;

namespace IntroCS
{
	class pricingGames : IGame
	{
		public pricingGames()
		{
			//this is empty unless parameters are added
		}

		// Play all games and keep score.
		public int Play()  // exactly matches heading in Game interface
		{
			//put in the code for this game here
			int score = 0;//keeps track of score and is set to zero

			Console.WriteLine ("That was a great round! Let's now move to a round of the Pricing Game!");
			//Console.WriteLine ("Add directions here?");


			return score; //must return int score 
		}
	}
}

