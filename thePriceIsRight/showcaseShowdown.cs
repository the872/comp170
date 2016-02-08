//use http://en.wikipedia.org/wiki/The_Price_Is_Right_(U.S._game_show)#Showcase_Showdown as reference

using System;

namespace IntroCS
{
	class showcaseShowdown : IGame
	{
		public showcaseShowdown()
		{
			//this is empty unless parameters are added
		}

		// Play all games and keep score.
		public int Play()  // exactly matches heading in Game interface
		{
			//put in the code for this game here
			int score = 0;//keeps track of score and is set to zero

			Console.WriteLine ("Splendid round! It's time for a round of Showcase Showdown!");
			//Console.WriteLine ("Add directions here?");


			return score; //must return int score 
		}
	}
}

