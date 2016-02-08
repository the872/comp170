using System;

namespace heads_tails.cs
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
			
		public static void Main (string[] args)
		{
			for (int i = 0; i < 10; i++) {
				Console.WriteLine(Flip ());
			}
		}
	}
}
