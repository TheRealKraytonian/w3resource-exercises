using System;

public class Exercise21
{
	public static void Main()
	{
		Console.WriteLine("number a");
		int x = int.Parse(Console.ReadLine());
		Console.WriteLine("number b");
		int y = int.Parse(Console.ReadLine());
		Console.WriteLine(x == 20 || y == 20 || x + y == 20);
	}
}
