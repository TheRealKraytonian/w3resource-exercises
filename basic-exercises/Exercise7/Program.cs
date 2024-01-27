using System;


public class Exercise7
{
	public static void Main()
	{
		Console.WriteLine("Input the first number:");
		int varOne = int.Parse(Console.ReadLine());
		Console.WriteLine("Input the second number:");
		int varTwo = int.Parse(Console.ReadLine());
		Console.WriteLine($"{varOne} + {varTwo} = {varOne + varTwo}");
		Console.WriteLine($"{varOne} - {varTwo} = {varOne - varTwo}");
		Console.WriteLine($"{varOne} x {varTwo} = {varOne * varTwo}");
		Console.WriteLine($"{varOne} / {varTwo} = {varOne / varTwo}");
		Console.WriteLine($"{varOne} mod {varTwo} = {varOne % varTwo}");
	}
}
