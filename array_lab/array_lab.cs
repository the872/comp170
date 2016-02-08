using System;

namespace IntroCS
{
   public class ArrayLab
   {
      public static void Main()
      { /// Include test:. Display test input and output 
        /// with liberal use of PrintInts,
        /// showing labeled inputs and outputs.

			//PrintInts ("Label", new int[] {3, 1, 5});
			//PrintInts ("New", new int[] {});
			//ReadInts ("Label", 3);
			//Console.Write(Minimum (new int[] { 1, 2, 3, 4, 5 }));
			//Console.Write(CountEven (new int[] {-4, 7, 6, 12, 9}));
			//PairwiseAdd(new int[] {1,2,3}, new int [] {1,2,3}, new int [] {0,0,0});
			//NewPairwiseAdd (new int[] {1,2,3}, new int [] {1,2,3});
			//IsAscending (new int[] { 1, 2, 3, 5, 6, 10, 4, 10});
			//PrintAscendingValues(new int[] { 1, 2, 3, 5, 6, 10, 4, 10});
			//PrintRuns(new int[] { 1, 2, 10, 5, 6, 10, 4, 6});
			//Console.Write(VectorDotProduct(new double[]{ 1.0, 2.0, 3.0 }, new double[]{ 4.0, 2.0, -1.0 }));
			//Console.Write(extraCredit1(new int[] { 1, 9, 6, 7 }));
			Console.Write(extraCredit2(new int[] { 1, 0, 0, 1, 1 }, 2));
      }
                                                   //PrintInts chunk
      /// Print label and then each element preceeded by a space,
      ///  all across one line.  Example:
      ///  If a contains {3, -1, 5} and label is "Nums:",
      ///  print:   Nums: 3 -1 5                   
      static void PrintInts(string label, int[] a)
      {
			if (a.Length != 0) {
				foreach (int element in a) {
					Console.Write (label + " " + element);
				}
				Console.WriteLine ();
			} else {
				Console.Write (label);
			}
      }
                                                   //ReadInts chunk
      ///  Prompt the user to enter n integers, and
      ///  return an array containing them.
      ///  Example:  ReadInts("Enter values", 3) could generate the
      ///  Console sequence:
      ///      Enter values (3)
      ///      1: 5
      ///      2: 7
      ///      3: -1
      ///  and the function would return an array containing {5, 7, -1}. 
      static int[] ReadInts(string prompt, int n)
      {
			int[] num;
			num = new int[(n-1)];
			Console.WriteLine (prompt + " (" + n + ")");
			for (int i = 0; i < n; i++) {
				int ans = UIF.PromptInt ((i + 1) + ": ");
				num [i] = ans;
			}
			return num; // so stub compiles
      }
                                                   //Minimum chunk
      ///  Return the minimum value in a.
      ///  Example: If a contains {5, 7, 4, 9}, return 4. 
      ///  Assume a contains at least one value.
      static int Minimum(int[] a)
      {
			int min = a [0];
			for (int i = 0; i < a.Length; i++) {
				if (a [i] < min) {
					min = a [i];
				}
			}
			return min; // so stub compiles
      }
                                                   //CountEven chunk
      ///  Return the number of even values in a.
      ///  Example: If a contains {-4, 7, 6, 12, 9}, return 3. 
      static int CountEven(int[] a)
      {
			int count = 0;
			for (int i = 0; i < a.Length; i++) {
				if (a [i] % 2 == 0) {
					count++;
				}
			}
			return count; // so stub compiles
      }
                                                   //PairwiseAdd chunk
      ///  Add corresponding elements of a and b and place them in sum.
      ///  Assume all arrays have the same Length.
      ///  Example: If a contains {2, 4, 6} and b contains {7, -1, 8}
      ///  then at the end sum should contain {9, 3, 14}. 
      static void PairwiseAdd(int[] a, int[] b, int[] sum)
      {
			for (int i = 0; i < a.Length; i++) {
				sum [i] = a [i] + b [i];
				Console.WriteLine (sum [i]);
			}
      }
                                                   //NewPairwiseAdd chunk
      ///  Return a new array whose elements are the sums of the
      ///  corresponding elements of a and b.
      ///  Assume a and b have the same Length.
      ///  Example: If a contains {2, 4, 6} and b contains {3, -1, 5}
      ///  then return an array containing {5, 3, 11}. 
      static int[] NewPairwiseAdd(int[] a, int[] b)
      {
			int[] sum;
			sum = new int[(a.Length)];
			for (int i = 0; i < a.Length; i++) {
				sum [i] = a [i] + b [i];
				Console.WriteLine (sum [i]);
			}
			return sum; // so stub compiles
      }
                                                   //IsAscending chunk
      ///  Return true if the numbers are sorted in increasing order,
      ///  so that in each pair of consecutive entries,
      ///  the second is always at least as large as the first.
      ///  Return false otherwise.  Assume an array with fewer than
      ///  two elements is ascending.
      ///  Examples: If a contains {2, 5, 5, 8}, return true;
      ///  if a contains {2, 5, 3, 8}, return false. 
      static bool IsAscending(int[] a)
      {
			if (a.Length < 2) {
				//Console.Write ("t");
				return true;
			}
			for (int i = 0; i < a.Length-1; i++) 
			{
				if (a [i] > a [i + 1]) {
					//Console.Write ("f");
					return false;
				}
			}
			//Console.Write ("t");
			return true;
      }
                                                   //PrintAscendingValues chunk
      ///  Print an ascending sequence from the elements
      ///  of a, starting with the first element and printing
      ///  the next number after the previous number
      ///  that is at least as large as the previous one printed.
      ///  Example: If a contains {5, 2, 8, 4, 8, 11, 6, 7, 10},
      ///  print:  5 8 8 11      
      static void PrintAscendingValues(int[] a)
      {
			if (IsAscending(a) == true) {
				for (int i = 0; i < a.Length; i++)
					Console.Write (a [i] + " ");
			} else {
				Array.Sort (a);
				for (int i = 0; i < a.Length; i++)
					Console.Write (" " + a [i] + " ");
			}
      }
                                                   //PrintRuns chunk
      ///  Prints each ascending run in a, one run per line.
      ///  Example: If a contains {2, 5, 8, 3, 9, 9, 8}, print
      ///  2 5 8
      ///  3 9 9
      ///  8          
      static void PrintRuns(int[] a)
      {
			if (a.Length < 2) {
				Console.Write (a [0]);
			}
			for (int i = 0; i < a.Length-1; i++) 
			{
				if (a [i] < a [i + 1]) {
					Console.Write (a [i] + " ");
				} else {
					Console.WriteLine (a [i] + " ");
				}
			}
			Console.WriteLine (a [a.Length-1]);

      }  

	  static double VectorDotProduct(double[]a, double[]b)
		{
			double sum = 0;
			for (int i = 0; i < a.Length; i++) {
				sum += a [i] * b [i];
			}
			return sum;
		}
		static int extraCredit1(int[]a)
		{
			int num = 0;
			for (int i = 0; i < a.Length; i++) {
				num = 10 * num + a [i];
			}
			return num;
		}
		static double extraCredit2(int[]a, int base1)
		{
			double num = 0.0;
			for (int i = 0; i < a.Length; i++) {
				num = base1 * num + a [i];
			}
			return num;
		}
   }                                              // end PrintRuns chunk   
}
