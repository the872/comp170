using System;

namespace count_dups.cs
{
	class MainClass
	{
		// Return the number of duplicate pairs in an array a.
		// Example: for elements 2, 5, 1, 5, 2, 5
		// the return value would be 4 (one pair of 2's three pairs of 5's.
		public static int dups(int[] a)
		{
			int count = 0; 
			Array.Sort(a);
			for (int i = 0; i < a.Length; i++)
			{
				for (int j = i + 1; j < a.Length; j++)
				{
					if (a [i] == a [j])
						count++;
				}
			}
			return count;
		}

		public static void Main (string[] args)
		{
			//dups(test); not implemented
		}
	}
}
