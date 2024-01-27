using System;

public class Exercise10 
{
	public static void Main()
	{
		Console.WriteLine("Input the first number:");
		int varOne = int.Parse(Console.ReadLine());
		Console.WriteLine("Input the second number:");
		int varTwo = int.Parse(Console.ReadLine());
		Console.WriteLine("Input the third number:");
		int varThree = int.Parse(Console.ReadLine());
		
		Console.WriteLine
($"Result of specified numbers {varOne}, {varTwo}, and {varThree}, ({varOne} + {varTwo}) x {varThree} is {(varOne + varTwo) * varThree} and ({varOne} x {varTwo}) + ({varTwo} x {varThree}) is {(varOne*varTwo) + (varTwo*varThree)}");
	}
}
