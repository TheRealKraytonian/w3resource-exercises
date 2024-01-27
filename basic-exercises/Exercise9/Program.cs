using System;

public class Exercise9
{
	public static void Main()
	{
		Console.WriteLine("Input the first number:");
		int varOne = int.Parse(Console.ReadLine());
		Console.WriteLine("Input the second number:");
		int varTwo = int.Parse(Console.ReadLine());
		Console.WriteLine("Input the three number:");
		int varThree = int.Parse(Console.ReadLine());
		Console.WriteLine("Input the four number:");
		int varFour = int.Parse(Console.ReadLine());
		Console.WriteLine($"{varOne}, {varTwo}, {varThree}, {varFour} is: {(varOne + varTwo + varThree + varFour) / 4}");
	}
}
