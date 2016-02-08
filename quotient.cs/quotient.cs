using System;

namespace quotient_return.cs
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ( "Enter an integer: ");
			string xString = Console.ReadLine();
			int x = int.Parse(xString);
			Console.Write( "Enter another integer: ");
			string yString = Console.ReadLine();
			int y = int.Parse(yString);

			int ans = x / y;
			int rem = x % y;

			Console.WriteLine ("The quotient of {0} and {1} is {2} with a remainder of {3}.", x, y, ans, rem);
		}
	}
}

