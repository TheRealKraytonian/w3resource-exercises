using System;

public class Exercise14
{
	public static void Main()
	{
		Console.WriteLine("Enter the amount of celsius:");
		int celsius = int.Parse(Console.ReadLine());
		Console.WriteLine($"Kelvin = {Math.Floor(celsius + 273.15)}");
		Console.WriteLine($"Fahrenheit = {Math.Floor(celsius * 1.8 + 32)}");
	}
}
