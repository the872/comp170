using System;

namespace grade_calc.cs
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//initilization
			double ex0;
			double lab0;
			double hw0;
			double pro0;
			double par0;

			double left0 = 100;

			double ex1;
			double lab1;
			double hw1;
			double pro1;
			double par1;

			double ex2;
			double lab2;
			double hw2;
			double pro2;
			double par2;

			double fin;
			string fing;

			bool done = false;

			while (done == false) {
				//intro
				Console.WriteLine ("Welcome to The Grade Calculator.");
				Console.WriteLine ("Follow the directions to find out what your grade is.");
				Console.WriteLine ("What is your name?");
				string name = Console.ReadLine ();

				Console.WriteLine ("Hello, {0}.", name);


				//asking for exam weights
				Console.WriteLine ("What are your exams weighted? You have {0}% left.", left0);
				string ex = Console.ReadLine ();
				ex0 = double.Parse (ex);
				left0 -= ex0;

				Console.WriteLine ("What are your labs weighted? You have {0}% left.", left0);
				string lab = Console.ReadLine ();
				lab0 = double.Parse (lab);
				left0 -= lab0;

				Console.WriteLine ("What is your homework weighted? You have {0}% left.", left0);
				string hw = Console.ReadLine ();
				hw0 = double.Parse (hw);
				left0 -= hw0;

				Console.WriteLine ("What are your projects weighted? You have {0}% left.", left0);
				string pro = Console.ReadLine ();
				pro0 = double.Parse (pro);
				left0 -= pro0;

				Console.WriteLine ("What is your participation weighted? You have {0}% left.", left0);
				string par = Console.ReadLine ();
				par0 = double.Parse (par);
				left0 -= par0;

				double sum0 = (ex0 + lab0 + hw0 + pro0 + par0);

				if( sum0 != 100.00)
				{
					Console.WriteLine ("Your number don't add up 100%, check that out and try again.");
					done = true;
					Environment.Exit (0);
				}

				//asking for user's grades
				Console.WriteLine ("Enter your grade on exams.");
				string e = Console.ReadLine ();
				ex1 = double.Parse (e);

				Console.WriteLine ("Enter your grade on labs.");
				string l = Console.ReadLine ();
				lab1 = double.Parse (l);

				Console.WriteLine ("Enter your grade on homework.");
				string h = Console.ReadLine ();
				hw1 = double.Parse (h);

				Console.WriteLine ("Enter your grade on projects.");
				string pr = Console.ReadLine ();
				pro1 = double.Parse (pr);

				Console.WriteLine ("Enter your grade on participation.");
				string pa = Console.ReadLine ();
				par1 = double.Parse (pa);

				//calculations
				ex2 = (ex0 * ex1) / 1000.00;
				lab2 = (lab0 * lab1) / 1000.00;
				hw2 = (hw0 * hw1) / 1000.00;
				pro2 = (pro0 * pro1) / 1000.00;
				par2 = (par0 * par1) / 1000.00;

				double sum2 = ex2 + lab2 + hw2 + pro2 + par2;

				fin = sum2 * 10.0;

				if (fin > 93) {
					fing = "A";
				} else if (fin > 90) {
					fing = "A-";
				} else if (fin > 87) {
					fing = "B+";
				} else if (fin > 83) {
					fing = "B";
				} else if (fin > 80) {
					fing = "B-";
				} else if (fin > 77) {
					fing = "C+";
				} else if (fin > 73) {
					fing = "C";
				} else if (fin > 70) {
					fing = "C-";
				} else if (fin > 67) {
					fing = "D+";
				} else if (fin > 63) {
					fing = "D";
				} else if (fin > 60) {
					fing = "D-";
				} else {
					fing = "F";
				}
			
				//answer to their question

				Console.WriteLine ("{0}, your final grade is a {1}%.", name, fin);
				Console.WriteLine("You got an {0} in the class.", fing);
				Console.WriteLine("Press Y to do another calculation");
				string result = Console.ReadLine ();

				//check to see if user wants to do another calculation 
				if((result).Equals("y"))
				{
					done = false;
				}
				else if((result).Equals("Y"))
				{
					done = false;
				}
				else
				{
					done = true;
				}
			}
			Environment.Exit (0);
		}
	}
}