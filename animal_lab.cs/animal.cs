using System;
using System.Collections.Generic;


namespace IntroCS
{
   public class Animal
   {
		private string name; 
		private List<string> guts;

      
		public Animal(string name)
		{
			this.name = name;
			guts = new List<string> ();
			 
		}

		public string getName()
		{
			return name;
		}

		public List<string> getGuts()
		{
			return guts;
		}

		public int getGutsSize()
		{
			return guts.Count;
		}

		public void Greet()
		{
			Console.WriteLine("Hello my name is, " + getName() + ".");
		}

		public void Eat (string food)
		{
			guts.Add (food);
		}

		public void Excrete ()
		{
			if (getGutsSize () > 0) {
				string fin = guts[getGutsSize() - 1];
				guts.RemoveAt (getGutsSize () - 1);
				Console.WriteLine(fin);
			} else {
				Console.WriteLine("");
			}
		}

		public override string ToString()
		{
			if (getGutsSize () == 0) {
				return string.Format ("Animal: {0} did not eat anything.", name);
			} else if (getGutsSize () == 1) {
				return string.Format ("Animal: {0} ate {1}", name, guts[0]);
			} else if (getGutsSize () == 2) {
				return string.Format ("Animal: {0} ate {1} and {2}", name, guts[0], guts[1]);
			} else {
				string done = "";
				for (int i = 0; i < (getGutsSize() - 1); i++) {
					done += guts[i] + ", ";
				}
				string last = "and " + guts[getGutsSize() - 1];
				return string.Format ("Animal: {0} ate {1} {2}.", name, done, last);

			}


		}

   }
}