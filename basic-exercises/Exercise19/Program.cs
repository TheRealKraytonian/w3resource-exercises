using System;

public class Exercise19
{
	public static void Main()
	{
		Console.WriteLine("Input number 1");
		int x = int.Parse(Console.ReadLine());
		Console.WriteLine("Input number 2");
		int y = int.Parse(Console.ReadLine());

		if(x == y)
		{
			Console.WriteLine($"{3 * (x + y)}");
		}
		else
		{
		Console.WriteLine($"{x + y}");
		}
	}
}
