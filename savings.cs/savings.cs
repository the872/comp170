using System;

namespace IntroCS{
	public class saving
	{
	static void Main()
	{
			double x = UIF.PromptDouble ("Please enter your starting amount: ");
			double y = UIF.PromptDouble ("Please enter your rate (ex. '.04'): ");
			double z = UIF.PromptDouble ("Please enter your desired amount: ");

		Compound(x, y, z);
	}
	static void Compound(double start, double rate, double goal)
	{

		Console.WriteLine(start.ToString("F2"));
		while(start < goal)
		{
			start = start*(1.00 + rate);
			start = Math.Round(start, 2);
			Console.WriteLine(start.ToString("F2"));
		}
	}
	}
}