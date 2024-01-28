using System;

public class Exercise17
{
	public static void Main()
	{
		Console.WriteLine("Enter a Sentence");
		string StringInput = Console.ReadLine();

		Console.WriteLine($"{StringInput[0]}{StringInput}{StringInput[0]}");
	}
}
