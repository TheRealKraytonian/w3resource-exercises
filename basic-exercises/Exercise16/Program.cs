using System;

public class Exercise16
{
	public static void Main()
	{
		Console.WriteLine("Enter a Phrase");
		char[] TestData = Console.ReadLine().ToCharArray();
		(TestData[0],TestData[TestData.Length - 1]) = (TestData[TestData.Length - 1],TestData[0]);
		Console.WriteLine(TestData);
	}
}       
