using System;
using System.Collections.Generic;

namespace IntroCS
{
	//using http://en.wikipedia.org/wiki/The_Price_Is_Right_(U.S._game_show)#Gameplay as reference
	public class PlayGames
	{

		public static IGame getGame(int n, List<IGame> g)//used below to run the games 
		{
			IGame ret = g [n];
			return ret;
		}

		public static void Main ()
		{
			List<IGame> games = new List<IGame> (); //games list
			games.Add (new oneBid (); //One Bid game that starts off the game
			games.Add (new pricingGames ()); //pricing game that comes after
			games.Add (new showcaseShowdown ()); //showcase showdown game (spinning the wheel)
			games.Add (new theShowcase ()); //final game 

			int totScore = 0;//total score set to zero

			Console.WriteLine ("Welcome to....");
			Console.WriteLine ("THE PRICE IS RIGHT");
			string name = UIF.PromptLine ("Who do we have the pleasure with playing today with?");
			Console.WriteLine ("Welcome, {0}!", name);

			for (int x = 0; x <= 4; x++) {//loop that runs all the games and avoids redundant code
				totScore = totScore + getGame (x, games).Play ();//plays each game and adds score of each to the total score
				Console.WriteLine (" ");
			}

			Console.WriteLine ("Thanks for playing, {0}!", name);//thanks the user for playing
			Console.WriteLine ("Your total score is " + totScore + "!");//displays the score
			//to play game as long as user wants to play, just add a while loop
		}
	}
}