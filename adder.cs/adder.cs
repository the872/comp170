using System;

namespace IntroCS
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int sum = 0;
			Console.WriteLine("There are {0} command line parameters.", args.Length);
			foreach(string s in args) {
				int st = int.Parse (s);
				sum += st;
			}
			Console.WriteLine (sum); 
		}
	}
}
