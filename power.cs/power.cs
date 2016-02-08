using System;

namespace power.cs
{
	public class power{ 
		static int PromptDouble (string prompt)
		{
			Console.Write (prompt);
			string inp = Console.ReadLine ();
			return int.Parse (inp);
		}

		static int Power(int n, int p) 
		{
			if (p == 0) {
				return 1;
			}
			else if(p == 1){ // this tests to see if n is 1, the base case
				return n;
		} // if so, the function returns 1
		else{
				return n*Power(n, p-1); 
		}
	}
		static void Main()
		{
			int int1 = PromptDouble("Enter your first number." + "\n");
			int int2 = PromptDouble("Enter your second number." + "\n");

			int sum = Power (int1, int2);		

			Console.Write("Your answer is {0}.", sum);
		}
	}
}
