using System;
/**
namespace make_histogram.cs
{
	// Return a histogram array counting repetitions of values
	// start through end in array a.  The count for value start+i
	// is at index i of the returned array, starting at i == 0.
	// For example:
	// Histogram(new int[]{2, 0, 3, 5, 3, 5}, 2, 5) counts how
	// many times the numbers 2 through 5, inclusive, occur in
	// the original array, and returns a new array containing
	// {1, 2, 0, 2}, that is, 1 2, 2 3's, 0 4's, and 2 5's. The
	// count of 2's appears as the first (0th) element of the
	// returned array, the count of 3's as the second, etc.
	// Similarly, Histogram(new int[]{2, 0, 3, 5, 3, 5}, -1, 1)
	// returns the new array {0, 1, 0},
	// that is, 0 -1's, 1 0, and 0 1's.
	public static int[] Histogram(int[] a, int start, int end)
	{
		int count = 0;
		int[] final = new int[end-start];
		while(start < end)
		{
			foreach(int fin in a)
			{
				for(int x = start; start < end; start++)
				{
					if(a[fin] == x)
					{
						final[x] +=1;
					}
				}
			}
		}
		return final;
	}



	class MainClass
	{
		public static void Main (string[] args)
		{
			//Histogram(new int[]{2, 0, 3, 5, 3, 5}, 2, 5); not implemented 
		}
	}
}
**/