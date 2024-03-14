using System;


public class Exercise27
{
	public static void Main()
	{
		Console.WriteLine("Give me a list of numbers.");
		string InputInteger = Console.ReadLine();
		Console.WriteLine(SumOfIntArray(InputInteger));
	}
	
	public static string SumOfIntArray(string integer)
	{
		int[] intArray = new int[integer.Length];
		for (int i = 0; i < integer.Length; i++)
		{
			intArray[i] = int.Parse(integer[i]);
			Console.WriteLine($"{intArray[i]}");
		}
		return intArray;
	}
}
