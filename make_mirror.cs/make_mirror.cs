using System;

namespace make_mirror.cs
{
	class MainClass
	{
		// Create a new array with the elements of a in the opposite order.
		// {"aA", "bB", "cC"} produces a new array {"cC", "bB", "aA"}
		public static string[] Mirror(string[] a)
		{
			int size = a.Length;
			string[] fin = new string[size];
			for (int i = 0; i < size; i++) {
				fin [size - i] = a [i]; 
			}
			return fin;
		}

		public static void Main (string[] args)
		{
			//Mirror(test); not implemented 
		}
	}
}
