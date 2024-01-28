using System;

public class exercise18
{
	public static void Main()
	{
		Console.WriteLine("input first integer:");
		int x = int.Parse(Console.ReadLine());
		Console.WriteLine("input second integer:");
		int y = int.Parse(Console.ReadLine());
		 Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
	}
}
