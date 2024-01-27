using System;

public class Exercise5
{
	public static void Main()
	{

		Console.WriteLine("Variable 1:");
		var varOne = Console.ReadLine();
		Console.WriteLine("Variable 2:");
		var varTwo = Console.ReadLine();
		Console.WriteLine($"Before swap - v1:{varOne} v2:{varTwo}");
		var tempVar = varOne;
		varOne = varTwo;
		varTwo = tempVar;
		Console.WriteLine($"After swap - v1:{varOne} v2:{varTwo}");
		
	}
}
