using System;

public class Exercise2
{
	public static void Main()
	{
 		System.Console.WriteLine("Enter Numerator");
		double a = double.Parse(System.Console.ReadLine());
		System.Console.WriteLine("Enter Denominator");
		double b = double.Parse(System.Console.ReadLine());
		System.Console.WriteLine($"{a} / {b} is {a/b}");
	}
}

