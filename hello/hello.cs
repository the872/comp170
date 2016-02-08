using System;

class Hello
{
	static void Main()
	{
		string name;
		bool condition;

		Console.Write("Enter your name: ");
		name = Console.ReadLine();
		Console.WriteLine("Hello {0}", name); 

		Console.WriteLine ("This is my project.");
		Console.WriteLine ("I call it Hello World");
		Console.Write ("Enter 'Q' to close" + "\n");
		if(Console.ReadLine().Equals("q"))
			{
				condition = true;
			}
			else
			{
				condition = false;
			}
		if(condition)
			{
			System.Environment.Exit (3000);
			}
			else
			{
			Console.WriteLine("Just press 'Q' {0}", name + ", there isn't anything left here!");
			condition = false;
			}
		//boolean not working after it reads the line once and performs outcome
	}
}