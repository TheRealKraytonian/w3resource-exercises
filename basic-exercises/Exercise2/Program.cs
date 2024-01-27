using System;

public class Exercise2
{
	public static void Main()
	{
		System.Console.WriteLine("Enter a number");
		double b = double.Parse(System.Console.ReadLine());
		System.Console.WriteLine("Enter b number");
		double a = double.Parse(System.Console.ReadLine());
		System.Console.WriteLine($"{a} plus {b} is {a+b}");
	}
}
