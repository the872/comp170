using System; 

class Painting 
{
	static double PromptDouble (string prompt)
	{
		Console.Write (prompt);
		string inp = Console.ReadLine ();
		return double.Parse (inp);
	}

	static double Perimeter( double length, double width)
		{
		double sum = 2 * (length + width);
		return sum;
		}

	static void Main()
	{
		double width, length, wallArea, ceilingArea;
		//string widthString, lengthString;
		double HEIGHT = 8;


		Console.WriteLine ( "Calculation of Room Paint Requirements");


		//Console.Write ( "Enter room length: "); 
		//lengthString = Console.ReadLine();
		//length = double.Parse(lengthString); // these 3 lines might make a nice function: 
		length = PromptDouble("Enter room length: "); // lengthString no longer needed

		//Console.Write( "Enter room width: "); 
		//widthString = Console.ReadLine();
		//width = double.Parse(widthString); // these 3 lines could use the same function: 
		width = PromptDouble("Enter room width: "); // widthString no longer needed


		//wallArea = 2 * (length + width) * HEIGHT; // ignore doors
		// this line might use a Perimeter function, like so: 
		wallArea = Perimeter(length,width) * HEIGHT;
		ceilingArea = length * width;
		// this line might provide/use a new function called Area, similar to Perimeter

		Console.WriteLine("The wall area is " + wallArea + " square feet.");
		Console.WriteLine("The ceiling area is " + ceilingArea + " square feet.");
	}
}
