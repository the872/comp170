//use http://en.wikipedia.org/wiki/The_Price_Is_Right_(U.S._game_show)#One_Bid as reference

using System;

namespace IntroCS
{
	class oneBid : IGame
	{
		static Random rnd = new Random ();

		public oneBid (string name, List<string> prizes)
		{
			//sets name to string name so it can be used below
			this.name = name;

			//gets random item from the list
			int r = rnd.Next (prizes.Count);

			//gets the name of the random item we have from the list
			string objName = prizes [r].getName ();
			//gets the price of the random item we got from the list
			int objPrice = prizes [r].getPrice ();

		}

		//checks if the price went over
		public bool Check(int input)
		{
			if (input > objPrice)
				return true;
			else
				return false;
		}

		//checks if the user got the bonus
		public int Bonus (int input, int itemPrice){
			if (input == itemPrice) {
				return 100;
			} else {
				return 0;
			}
		}

		// Play all games and keep score.
		public double Play ()  // exactly matches heading in Game interface
		{
			//put in the code for this game here
			double score = 0;//keeps track of score and is set to zero

			//intro to game
			Console.WriteLine ("To start us off, let's play a game of One Bid!");
			Console.WriteLine ("You have to guess the price of the item without going over!");

			//ask the user to guess the price of the item
			Console.WriteLine ("The item is called a {0}", objPrice);
			int userPrice = UIF.PromptLine ("Please enter what you think the item is valued at: ");

			//checks if the player went over
			if (Check(userPrice) == true) {
				//informs the user that they went over in price
				Console.WriteLine ("Oh! You went over, let's try another item.");
				//recursion to repeat this funciton
				Play ();
			}

			//the computer picks for how much they think its worth. 
			//we can tweak these later to add more of an algorithmic approach to their guesses
			int pick0 = rnd.Next (objPrice + 500);
			int pick1 = rnd.Next (objPrice + 300);
			int pick2 = rnd.Next (objPrice + 100);

			//checks the difference between the guesses for all the guesses
			int diffUser = objPrice - userPrice;
			int diffP0 = objPrice - pick0;
			int diffP1 = objPrice - pick1;
			int diffP2 = objPrice - pick2;

			if (Check (pick0) == true && Check (pick1) == true && Check (pick2) == true && Check(userPrice)) {
				//informs the user that everyone went over
				Console.WriteLine("Oh no! Everyone went over, let's try agian.");
				//calls the function again
				Play();
			}

			if (Check (pick0) == true && Check (pick1) == true && Check (pick2) == true) {
				//informs the user that everyone went over
				Console.WriteLine("Everyone except for you went over, you win!");
				//retrns the dollar amount of what the user got, including the bonus if they got the exact number
				return objPrice + Bonus (userPrice, objPrice); //must return double score 
			}


			//checks if the user was the lowest price (best price)
			if (diffUser > diffP1 || diffUser > diffP0 || diffUser > diffP2) {
				//tells the user that they did not win this round
				Console.WriteLine ("Sorry, you did not win. Please try again.");
				//recursion to repeat this function
				Play ();
			} else {
				//informs the user on winning the game
				Console.WriteLine ("Congradulations! You won this round.");
				Console.WriteLine ("The correct amount was {0} for the {1} and you guessed {2}", objPrice, objName, userPrice); 
			}
			//retrns the dollar amount of what the user got, including the bonus if they got the exact number
			return objPrice + Bonus (userPrice, objPrice); //must return double score 
		}
	}
}

