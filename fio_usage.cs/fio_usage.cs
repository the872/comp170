using System;
using System.IO;

namespace IntroCS
{
	class FIOTest
	{
		public static void Main(string[] args)
		{
			FileLineRemoval (new StreamReader("sample.txt"), new StreamWriter("sample_new.txt"), '#');
		}
			 
		static void FileLineRemoval(StreamReader reader, StreamWriter writer, char startToRemove)
		{
			while (!reader.EndOfStream) 
			{
				string line = reader.ReadLine ();
				if (reader.Read() != startToRemove) {
					writer.Write (line);
				} 
				line = reader.ReadLine ();
			}
			reader.Close (); 
			writer.Close ();
		}
	}
}