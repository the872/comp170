using System;
using System.IO;

namespace IntroCS
{
	class Week9Lab1GradeFiles
	{
		public static void Main(string[] args)
		{    
			// for GradeFiles Lab only: set courseName to a constant value for testing
			string courseName = "comp170"; // this will either become "comp150" or "comp170" for Grade Files

			/* for the Grade Files homework, Section 18.7, use this instead:
            string courseName = GetCourseName(args); // returns the course name from the args array or from the user
            */

			// Assignment 1: use FIO.GetPath to find the path names where these two files reside:
			// 1) categories_<courseName>.txt and 2) students_<courseName>.txt
			// these are the values of the input strings that you pass to FIO.GetPath
			// in the line above, plug the contents of variable courseName into the input strings
			// set the variables categoriesPath and studentsPath to the strings returned by FIO.GetPath

			string categoriesPath = FIO.GetPath("categories_" + courseName + ".txt"); // get full paths to files
			Console.WriteLine ("categoriesPath = " + categoriesPath);
			string studentsPath = FIO.GetPath("students" + courseName + ".txt");
			Console.WriteLine ("studentsPath = " + studentsPath);
			Console.WriteLine ();

			// end of Assignment 1

			// the following lines read the contents of the categories and students files into string arrays:
			string[] categoriesMaster = File.ReadAllLines(categoriesPath); // File function like reader.ReadToEnd()
			// categoriesMaster now holds the 3 lines of the Master Category file
			string[] studentsMaster = File.ReadAllLines(studentsPath);
			// read all lines of the Student Master file into a string array, one line per element

			// Assignment 2: later in this file, create a function called MakeCatArray that returns a string array
			// containing the categories contained in the first line of the categories file, now in categoriesMaster[0]
			string[] cats = MakeCatArray(categoriesMaster);
			// creates a string array of the category names
			Console.WriteLine("cats array: " + string.Join(", ", cats));

			// Assignment 3: later in this file, create a function called MakeWeightArray that returns an int array
			// containing the weights contained in the second line of the categories file, now in categoriesMaster[1]
			int[] catWeights = MakeWeightArray(categoriesMaster); 
			// creates an int array of weights used for the final grade calculation
			Console.WriteLine("catWeights array: " + string.Join(", ", catWeights));

			// Assignment 4: later in this file, create a function called MakeNumItemsArray that returns an int array
			// containing the numbers of items contained in the third line of the categories file, now in categoriesMaster[2]
			int[] numItems = MakeNumItemsArray(categoriesMaster); 
			// creates an int array of the maximum number of grades per category
			Console.WriteLine("numItems array: " + string.Join(", ", numItems));
			Console.WriteLine ();

			string[] finalOrder = new string[3];
			for(int j = 0; j < studentsMaster.Length; j++){ // process each student data line

				// Assignment 5 and 6:
			
				finalOrder [j] = studentsMaster [j].Split (',');
				Console.Write (finalOrder [0]);
				Console.Write (finalOrder [2]);
				Console.Write (finalOrder [1]);
				Console.WriteLine ();
			
				Console.Write (finalOrder [0] + courseName + ".txt");

				Console.WriteLine ();
			}
		}

		// functions for you to fill in follow ...

		// Assignment 2: fill in this function to match the listed requirements
		// remember that the list of categories is in the first line of the
		// categories master file, which is now in categoriesMaster[0]; they
		// are separated by commas (use Split and Trim!)

		/** Given an array of lines from the Category Master file,
          * return a string array of trimmed Category names */
		static string[] MakeCatArray(string[] categoriesMaster)
		{
			string[] cats = categoriesMaster [0].Split (',');

			for (int x = 0; x < cats.Length; x++)
				cats[x] = cats [x].Trim();

			return cats; // so code compiles - replace
		}

		// end of Assignment 2

		// Assignment 3: fill in this function to match the listed requirements
		// remember that the list of category weights is in the second line of the
		// categories master file, which is now in categoriesMaster[1]; they
		// are separated by commas (use Split!)
		// remember that categoriesMaster is a string array, not an int array!

		/** Given an array of lines from the Category Master file,
          * return an array of integer weight values, one per Category */
		static int[] MakeWeightArray(string[] categoriesMaster)
		{
			string[] wght = categoriesMaster [1].Split (',');
			int[] finwght = new int[wght.Length]; 

			for (int x = 0; x < wght.Length; x++){
				finwght [x] = int.Parse (wght [x]);
			}
		
			return finwght; // so code compiles - replace
		}

		// end of Assignment 3

		// Assignment 4: fill in this function to match the listed requirements
		// remember that the list of category item #'s is in the third line of the
		// categories master file, which is now in categoriesMaster[2]; they
		// are separated by commas (use Split!)
		// remember that categoriesMaster is a string array, not an int array!

		/** Given an array of lines from the Category Master file,
          * return an array of integer numbers of grade items per Category */
		static int[] MakeNumItemsArray(string[] categoriesMaster)
		{
			string[] nums = categoriesMaster [2].Split (',');
			int[] finnums = new int[nums.Length]; 

			for (int x = 0; x < nums.Length; x++){
				finnums [x] = int.Parse (nums [x]);
			}
				
			return finnums; // so code compiles - replace
		}

		// end of Assignment 4

		////////////////////// functions //////////////////////
		// codeIndex chunk                                          
		/// Take the first letter code for a catagory, and 
		/// return the index of that category in categories.
		static int codeIndex(string code, string[] categories)
		{
			for (int i = 0; i < categories.Length; i++) {
				if (categories[i].Trim().StartsWith(code)) {
					return i;
				}
			}
			return -1; //required by compiler: shouldn't reach
		}

		// GetCourseName chunk
		/// return the course name as a string from the args
		/// array or by prompting the user
		static string GetCourseName(string[] args) // parameter: reference to the program's args array
		{
			if (args.Length == 0){ // if there was not a command line parameter ...
				return UI.PromptLine ("Please enter the course name you want to process grades for: ").Trim(); 
				// prompt the user for the course name, Trim it, and return it
			}
			return args[0].Trim(); // otherwise return what was given on the command line, Trimmed
		}
	}
}