using System;

public class Exercise13
{
	public static void Main()
	{
		Console.WriteLine("Enter a number:");
		int digit = int.Parse(Console.ReadLine());
		Console.WriteLine($"{digit}{digit}{digit}");
		Console.WriteLine($"{digit} {digit}");
		Console.WriteLine($"{digit} {digit}");
		Console.WriteLine($"{digit} {digit}");
		Console.WriteLine($"{digit}{digit}{digit}");
	}
}
