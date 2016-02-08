using System;

class StringManip
{
	static string replaceFirst (string s, string target, string replacement)
	{
		return "not implemented";
	}
	static string replaceFirst1 (string s, string target, string replacement)
	{
		return "It was the worst of times.";
	}
	static string replaceFirst2(string s, string target, string replacement)
	{
		string first = s.Substring (0, 10);
		//string word = s.Substring (11, 14);
		string last = s.Substring (15);
		 
		return first + replacement + last;
	}
	static string replaceFirst3(string s, string target, string replacement)
	{
		int inx = s.IndexOf ("best");
		string first = s.Substring (0, inx - 1);
		string last = s.Substring (inx + 4);
		return first + replacement + last;
	}
	static string replaceFirst4(string s, string target, string replacement)
	{   
		int tar = target.Length;
		string part = target;
		int inx = s.IndexOf (part);
		string first = s.Substring (0, inx - 1);
		string last = s.Substring (inx + (tar - 1));
		return first + replacement + last;
	}	

	//EXTRA CREDIT

	/**  Return s with the first occurence of target
       *  replaced by replacement.  You cannot
       *  assume that the target string is in s.
       */
	
	static string replaceFirst5(string s, string target, string replacement)
	{ 
		if(s.IndexOf(target) != -1){
			int tar = s.IndexOf (target);
			int len = target.Length;
			string first = s.Substring (0, tar - 1);
			string last = s.Substring (tar + (len - 1));
			return first + replacement + last;
		}
		else{
			return s;
		}
	}

	//exercise 4.4 #1
	static void ShowLength()// print the prompt string to ask for user input
	{
		Console.Write ("Enter your input \n");
		string prompt = Console.ReadLine();
		int tar = prompt.Length;
		Console.Write ("String Lenght: {0}", tar);
		/**
		string end = prompt.IndexOf (tar - 1);
		if ((end).Equals ("?")) {
			Console.Write ("interrogatory sentence");
		} else if ((end).Equals ("!")) {
			Console.Write ("exclamation");
		} else if ((end).Equals (".")) {
			Console.Write ("declarative sentence");
		} else {
			Console.Write ("not a sentence");
		}
		**/
	}

	//exercise 4.4 #3
		static void LastFirst(string prompt)
	{
		if (prompt.IndexOf (" ") != -1) {
			int inp = prompt.IndexOf (" ");
			string first = prompt.Substring (0, inp);
			string last = prompt.Substring (inp + 1);

			Console.Write ("{0}, {1}", last, first);
		} else {
			string inpt = prompt.Substring (0);
			Console.Write (inpt);
		}
	}

	static void Main()
	{

		string str1 = "It was the best of times.";
		string str2 = "Of times it was the best.";
		Console.WriteLine("str1=" + str1);
		Console.WriteLine("str2=" + str2);
		Console.WriteLine();
		// to embed a quote inside a string constant, precede it by backslash(\).
		Console.WriteLine("Let us do some \"cutting and pasting\" of strings!");
		string str3 = replaceFirst(str1, "best", "worst"); // this call is supposed to replace "best" with "worst" in str1
		Console.WriteLine("str3 = str1 with best => worst: " + str3); // "It was the worst of times."
		string str4 = replaceFirst(str2, "best", "worst"); // similarly, this one replaces "best" with "worst" in str2
		Console.WriteLine("str2 with best => worst: " + str4);           // "Of times it was the worst."
		string str5 = replaceFirst(str3, "worst", "best"); // and this one replaces "worst" with "best" in str3
		Console.WriteLine("str3 with worst => best: " + str5);           // "It was the best of times."

		//ShowLength ();
		//LastFirst("john");
	}
}