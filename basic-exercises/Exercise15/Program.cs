using System;

public class Exercise15
{

	public static void Main()
	{
		 Console.WriteLine("Enter Text");
		 string TestData = Console.ReadLine();
		 int strLength = TestData.Length;
		 Console.WriteLine($"Remove an index from {TestData}");
		 int IndexInput = Int32.Parse(Console.ReadLine());
		 Console.WriteLine(IndexInput);
		 TestData = TestData.Remove(IndexInput, 1);
		 Console.WriteLine(TestData);
	}
}
