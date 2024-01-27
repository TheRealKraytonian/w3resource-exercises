using System;

public class Exercise12
{
	public static void Main()
	{
		Console.WriteLine("Enter a digit:");
		int digit = int.Parse(Console.ReadLine()); 
		Console.WriteLine($"{digit} {digit} {digit} {digit}");
		Console.WriteLine($"{digit}{digit}{digit}{digit}");
		Console.WriteLine($"{digit} {digit} {digit} {digit}");
		Console.WriteLine($"{digit}{digit}{digit}{digit}");
	}
}
