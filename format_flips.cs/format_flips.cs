using System;

namespace format_flips.cs
{

	class MainClass
	{
		static Random r = new Random();

		static string Flip()
		{
			int n = r.Next(0, 2);

			if (n < 1) {
				return "Heads";
			} else {
				return "Tails";
			}
		}

		static void GroupFlips (int total, int groupSize)
		{
			while (total > 0){
				for(int x = 0; x < groupSize; x++){
					if (total > 0) {
						Console.Write (Flip () + " ");
					}
					total--;
				}
				Console.WriteLine ();
			}
		}

		public static void Main (string[] args)
		{
			GroupFlips(10, 1);
		}
	}
}


// Print out the results from the total number of random flips of a coin.
// Group them groupSize per line, each followed by a space.
// The last line may contain fewer than groupSize flips
// if total is not a multiple of groupSize.  The last line
// should be followed by exactly one newline in all cases.
// For example, GroupFlips(10, 4) *could* produce:
//   Heads Heads Tails Heads
//   Heads Tails Heads Tails
//   Tails Tails
//static void GroupFlips(int total, int groupSize)