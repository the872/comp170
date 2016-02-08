using System;
using System.IO;

namespace IntroCS
{
   class GradeFiles
   {
		/// <summary>
		/// So here is what you need to do to finish this:
		/// 
		/// - loop through the student master and get all the student id's to create all the student data files 
		/// - open the student data files 
		/// - read and store each line of the data file into an array, using split on a comma
		/// - average the scores
		/// - write out results to the file
		/// 
		/// Here is the grading scale stuff so you don't waste time on typing this out
		/// </summary>


      public static void Main(string[] args)
      {


         // TEMPORARY line to get oriented to the file system:
			//Console.WriteLine("Current directory: " + Directory.GetCurrentDirectory());

			//course abbrv. for step 2
			string courseName = GetCourseName(args);

			string categoriesPath = FIO.GetPath("categories_" + courseName + ".txt"); // get full paths to files
			//Console.WriteLine ("categoriesPath = " + categoriesPath);
			string studentsPath = FIO.GetPath("students" + courseName + ".txt");
			//Console.WriteLine ("studentsPath = " + studentsPath);
			//Console.WriteLine ();
		
			// the following lines read the contents of the categories and students files into string arrays:
			string[] categoriesMaster = File.ReadAllLines(categoriesPath); // File function like reader.ReadToEnd()
			// categoriesMaster now holds the 3 lines of the Master Category file
			string[] studentsMaster = File.ReadAllLines(studentsPath);
			// read all lines of the Student Master file into a string array, one line per element

			string[] cats = MakeCatArray(categoriesMaster);
			// creates a string array of the category names
			//Console.WriteLine("cats array: " + string.Join(", ", cats));


			// containing the weights contained in the second line of the categories file, now in categoriesMaster[1]
			int[] catWeights = MakeWeightArray(categoriesMaster); 
			// creates an int array of weights used for the final grade calculation
			//Console.WriteLine("catWeights array: " + string.Join(", ", catWeights));

	
			// containing the numbers of items contained in the third line of the categories file, now in categoriesMaster[2]
			int[] numItems = MakeNumItemsArray(categoriesMaster); 
			// creates an int array of the maximum number of grades per category
			//Console.WriteLine("numItems array: " + string.Join(", ", numItems));
			//Console.WriteLine ();

			string [] sID = studentDFile (studentsMaster);
			string[] files = new string[sID.Length];

			for (int x = 0; x < sID.Length; x++) {
				files [x] = FIO.GetPath(sID [x] + courseName + ".data");
			}

			int[] finNum = MakeNumItemsArray (categoriesMaster);
			int ex0, lb0, hw0, pr0, ca0;

			ex0 = finNum [0];
			lb0 = finNum [1];
			hw0 = finNum [2];
			pr0 = finNum [3];
			ca0 = finNum [4];

			string output_file = courseName + "_summary.txt";

			StreamWriter writer = FIO.OpenWriter(FIO.GetLocation(categoriesPath), output_file);

			string[] finalOrder = new string[3];

			for (int x = 0; x < files.Length; x++) {
			
				double[] ex = new double[ex0];
				for(int i = 0; i < ex.Length; i++){
					ex [i] = 0;
				}

				double[] lb = new double[lb0];
				for(int i = 0; i < lb.Length; i++){
					lb [i] = 0;
				}

				double[] hw = new double[hw0];
				for(int i = 0; i < hw.Length; i++){
					hw [i] = 0;
				}

				double[] pr = new double[pr0];
				for(int i = 0; i < pr.Length; i++){
					pr [i] = 0;
				}

				double[] ca = new double[ca0];
				for(int i = 0; i < ca.Length; i++){
					ca [i] = 0;
				}

				string [] student_files = File.ReadAllLines(files[x]);

				string[] line0 = LineReader (student_files, x);

				int[] line1 = new int[line0.Length];
				for(int y = 0; y < line0.Length; y++){
					line1 [y] = int.Parse(line0 [y]);
				}

				double[] line2 = new double[line1.Length];
				for(int z = 0; z < line1.Length; z++){
					line2 [z] = line1 [z];
				}


				//E, L, H, P, and C.
				if (line0 [0] == "e") {
					ex [line1 [1]] = line2 [2];
				} else if (line0 [0] == "l") {
					lb [line1 [1]] = line2 [2];
				} else if (line0 [0] == "h") {
					hw [line1 [1]] = line2 [2];
				} else if (line0 [0] == "p") {
					pr [line1 [1]] = line2 [2];
				} else {
					ca [line1 [1]] = line2 [2];
				}
					
				double finE, finL, finH, finP, finC;

				finE = Math (ex);
				finL = Math (lb);
				finH = Math (hw);
				finP = Math (pr);
				finC = Math (ca);

				finE = (finE * catWeights [0])/totalCatW(catWeights);
				finL = (finL * catWeights [1])/totalCatW(catWeights);
				finH = (finH * catWeights [2])/totalCatW(catWeights);
				finP = (finP * catWeights [3])/totalCatW(catWeights);
				finC = (finC * catWeights [4])/totalCatW(catWeights); 

				double finalGrade = finE + finL + finH + finP + finC;

				finalOrder [x] = studentsMaster [x].Split (',');
				writer.Write (finalOrder [1] + ", " + finalOrder[2] + finalGrade + finGradeLet(finalGrade));

			}

      }

		static string finGradeLet(double fin){
			string fing;

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
			return fing; 
		}

		static double totalCatW(int[] input){
			double sum = 0.0;
			for(int r = 0; r < input.Length; r++){
				sum += input [r];
			}
			return sum;
		}

		static double Math( double[] input){

			double sum = 0.0;
			for (int x = 0; x < input.Length; x++) {
				sum += input [x];
			}

			sum /= input.Length;

			return sum;

		}

		static double[] toDouble(int[] input){

			double[] finD = new double[input.Length]; 

			for (int i = 0; i < input.Length; i++) {
				finD [i] = input [i];
			}

			return finD;
		}
			
		static string[] studentDFile(string[] input)
		{
			string[] id = new string[input.Length];
			for (int x = 0; x < input.Length; x++) {
				id[x] = LineReader (input, 0) [0];
			}

			return id;
		}
		static string[] LineReader(string[] studentsMaster, int loc )
		{
			string[] lR = studentsMaster [loc].Split (',');

			for (int x = 0; x < lR.Length; x++) {
				lR [x] = lR [x].Trim ();
			}

			return lR; 
		}
                                           // codeIndex chunk                                          
		/// Take the first letter code for a category, and 
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
	
		static string[] MakeCatArray(string[] categoriesMaster)
		{
			string[] cats = categoriesMaster [0].Split (',');

			for (int x = 0; x < cats.Length; x++)
				cats[x] = cats [x].Trim();

			return cats; 
		}

		static int[] MakeWeightArray(string[] categoriesMaster)
		{
			string[] wght = categoriesMaster [1].Split (',');
			int[] finwght = new int[wght.Length]; 

			for (int x = 0; x < wght.Length; x++){
				finwght [x] = int.Parse (wght [x]);
			}

			return finwght; // so code compiles - replace
		}

		static int[] MakeNumItemsArray(string[] categoriesMaster)
		{
			string[] nums = categoriesMaster [2].Split (',');
			int[] finnums = new int[nums.Length]; 

			for (int x = 0; x < nums.Length; x++){
				finnums [x] = int.Parse (nums [x]);
			}

			return finnums; // so code compiles - replace
		}

		//function for abbrv. for step 2
		static string GetCourseName(string[] args) // parameter: reference to the program's args array
		{
			if (args.Length == 0){ // if there was not a command line parameter ...
				return UI.PromptLine ("Please enter the course name you want to process grades for: ").Trim(); 
				// prompt the user for the course name, Trim it, and return it
			}
			return args[0].Trim(); // otherwise return what was given on the command line, Trimmed
		}
   }                                   // end codeIndex chunk
}
