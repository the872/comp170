using System;
namespace IntroCS
{
	class StrangeSequence
	{
		/// Assume n is an integer.  If n is even, return n//2.
		/// Otherwise (n is odd) return 3*n + 1.
		static int Jump(int n)
		{
			if(n % 2 == 0)
			{
				n = n/2;
			}
			else
			{
				n = (3*n)+1;
			}
			return n; // so stub compiles
		}


		/// Iterate the Jump function, starting with the positive
		///   integer value n, stopping when the latest value is 1.  
		///   Print each value.  Exanples:
		///
		///   PrintStrangeSequence(1) prints:
		///   1
		///   PrintStrangeSequence(5) prints:
		///   5
		///   16
		///   8
		///   4
		///   2
		///   1               */
		static void PrintStrangeSequence(int n)
		{
			while (Jump (n) !=  1) {
				Console.Write ("{0}",n);
				Console.Write (" ");
				Jump (n);
				int ans = Jump (n);
				n = ans;
			}
			Jump (n);
			Console.Write ("{0}",n);
		}

		/// Same idea as PrintStrangeSeq, but instead of
		/// printing the whole sequence, just count the
		/// number of entries.  For example,
		///   CountStrangeSequence(1) returns 1; 
		///   CountStrangeSequence(6) returns 6.
		static int CountStrangeSequence(int n)
		{
			int i = 0;
			while (Jump (n) != 1) {
				Jump (n);
				int ans = Jump (n);
				n = ans;
				i++;
			}
			Jump (n);
			i++;
			return i;
		}

		static void Main() //testing routine
		{
			int n = UIF.PromptInt("Enter a positive integer: ");
			Console.WriteLine(n);
			Console.WriteLine("One jump from {0} is {1}.", n, Jump(n));
			Console.WriteLine("Sequence until 1:");
			PrintStrangeSequence(n);
			Console.WriteLine (" ");
			Console.WriteLine("{0} elements in the sequence.", CountStrangeSequence(n));
		}
	}
}