using System;

namespace IntroCS
{
	public class Test
	{
		static int CountRep(string s, string target)
		{
			int count = 0;
			if(s.Contains(target))
			{
				int i = 0;
				while(i < s.Length)
				{
					int loc = s.IndexOf(target, i);
					int len = target.Length;
					count ++;
					i += (loc+len+1);//adds one since I need the position after the string I just found
				}
			}
			else
			{
				return 0; 
			}
			return count;
		}
		public static void Main()
		{
			string x = UIF.PromptLine ("Enter the whole word: ");
			string y = UIF.PromptLine ("Enter the part you need: ");

			if (CountRep (x, y) == 1) {
				Console.Write ("The part occurs {0} time.", CountRep (x, y));
			} else {
				Console.Write ("The part occurs {0} times.", CountRep (x, y));
			}
		}
	}
}