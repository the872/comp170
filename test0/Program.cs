using System;

namespace test0
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] a = {10, 8, 9, 77, 12, 15, 2, 1};  //1
			int n = 1;                               //2
			while (n < 8) {                          //3
				Console.Write(" {0}->{1}", n, a[n]);  //4
				if (a[n-1] < a[n]) {                  //5
					n += 2;  //note += not =           //6
				} else {                              
					n++;                               //7
				}              
			}



		}
	}
}
