using System;

class DoTheMath {
	public static void Main() { 
		bool deci;
		bool another = true;

		while (another == true) {
			Console.WriteLine ("Do you need a decimal? Press Y if you do.");
			string input0 = Console.ReadLine ();

			if ((input0).Equals ("y")) {
				deci = true;
			} else {
				deci = false;
			}

			if (deci == true) {
				Console.WriteLine ("Please enter the numerator.");
				string input1 = Console.ReadLine ();
				double num = double.Parse (input1);
				Console.WriteLine ("Please enter the denominator");
				string input2 = Console.ReadLine ();
				double den = double.Parse (input2);
				double ans = num / den;
				Console.WriteLine ("You asked: {0} / {1} = ?", num, den);
				Console.WriteLine ("Your answer is {0}", ans);
			} else {
				Console.WriteLine ("Please enter the numerator.");
				string input1 = Console.ReadLine ();
				int num = int.Parse (input1);
				Console.WriteLine ("Please enter the denominator");
				string input2 = Console.ReadLine ();
				int den = int.Parse (input2);
				int ans = num / den;
				int rem = num % den;
				Console.WriteLine ("You asked: {0} / {1} = ?", num, den);
				Console.WriteLine ("Your answer is {0} with a remainder of {1}", ans, rem);
			}

			Console.WriteLine ("Do you need another calculation done? Enter Y if you do.");
			string input3 = Console.ReadLine ();

			if ((input3).Equals ("y")) {
				another = true;
			} else {
				another = false;
			}
		}
		Environment.Exit (0);
		
	} // total of 11-13 lines of code to implement this and complete the Lab exercise
} 
