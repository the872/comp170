using System;

namespace IntroCS
{
	class array2d
	{
		static int[,] arrayMaker(int rows, int cols)
		{
			int[,] table = new int[rows, cols];
			//uncomment the Console.Writes to test the program
			for (int r = 0; r < rows; r++) {
				for (int c = 0; c < cols; c++) {
					table [r, c] = 10 * (r + 1) + c + 1;
					//Console.Write (table [r, c] + " "); 
				}
				//Console.WriteLine ();
			}
			return table;
		}

		public static void Main (string[] args)
		{
			int rows = UIF.PromptInt ("Please enter how many rows you want: ");
			int cols = UIF.PromptInt ("Please enter how many columns you want: ");
			arrayMaker (rows, cols);
		}
	}
}

