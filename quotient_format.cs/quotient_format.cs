using System;

namespace quotient.cs
{
	class MainClass
	{
		static void QuotientProblem (int x, int y)
		{
			int ans;
			int remain;
			ans = x / y;
			remain = x % y;
			Console.WriteLine ("The quotient of {0} and {1} is {2} with a remainder of {3}.", x, y, ans, remain);
		}
		static void Main ()
		{
			//test 1
			QuotientProblem (10, 5);

			//test 2
			QuotientProblem (2, 4);

			//test 3
			QuotientProblem (100, 9);

			//user test
			Console.Write("Enter an integer: ");
			int a = int.Parse(Console.ReadLine());
			Console.Write("Enter another integer: ");
			int b = int.Parse(Console.ReadLine());
			QuotientProblem (a, b);

		}
	}
}

