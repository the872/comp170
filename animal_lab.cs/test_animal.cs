using System;

namespace IntroCS
{
   public class TestAnimal
   {
      /// Thoroughly test all Animal methods, with all the actions 
      ///   clearly labeled for a person *not* readingthe code.
      public static void Main()
      {  
			Animal f = new Animal ("Frog");
			Animal d = new Animal ("Dog");
			Animal c = new Animal ("Cow");

			f.Greet ();
			f.Eat ("worm"); 
			f.Eat ("corn"); 
			f.Eat ("fly"); 
			f.Eat ("bird");
			f.Excrete ();
			Console.WriteLine(f.ToString ());

			d.Greet ();
			d.Eat ("biscuit"); 
			d.Eat ("homework");
			d.Excrete ();
			Console.WriteLine(d.ToString ());

			c.Greet ();
			c.Eat ("grass"); 
			c.Excrete ();
			Console.WriteLine(c.ToString ());

      }
   }
}