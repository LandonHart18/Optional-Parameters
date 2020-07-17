using System;

/*Using your own words in a comment at the top of your .cs file, describe "syntactic sugar".
Answer:
Syntactic sugar, or syntax sugar, is a visually or logically-appealing "shortcut" provided by the language, which reduces the amount of code that must be 
written in some common situation. Syntactic sugar is syntax within a programming language that is designed to make things easier to read or to express.*/

namespace OptionalParameters
{
	class Program
	{
		static public void Main()
		{
			//Calling the scholar method
			Scholar("Siya", "Joshi", 30);
			Scholar("Rohan", "Joshi", 37, "Information Technology");
			Console.ReadKey();
		}

		static public void Scholar(string fname, string lname, int age = 20, string branch = "Computer Science")
		{
			Console.WriteLine("First name: {0}", fname);
			Console.WriteLine("Last name: {0}", lname);
			Console.WriteLine("Age: {0}", age);
			Console.WriteLine("Branch: {0}", branch);
		}

		static public void Scholar(string fname, string lname, int age)
		{
			Console.WriteLine("First name: {0}", fname);
			Console.WriteLine("Last name: {0}", lname);
			Console.WriteLine("Age: {0}", age);
		}
	}
}
