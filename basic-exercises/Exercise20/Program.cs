using System;

public class Exercise20
{
	public static void Main()
	{
		Console.WriteLine("number a");
		int a = int.Parse(Console.ReadLine());
		Console.WriteLine("number b");
		int b = int.Parse(Console.ReadLine());
		Console.WriteLine(AbsoluteFunction(a,b));
	}

	public static int AbsoluteFunction(int a, int b)
	{
		int sum1 = Math.Abs(a - b);
		int sum2 = (a - b) * 2;
		return a > b ? sum2 : sum1;
	}
}
