using System;

public class Exercise6 
{
	public static void Main()
	{
		System.Console.WriteLine("Enter first number to X:");
		double? one = double.Parse(System.Console.ReadLine());
		System.Console.WriteLine("Enter second number to X:");
		double? two = double.Parse(System.Console.ReadLine());
		System.Console.WriteLine("Enter third number to X:");
		double? three = double.Parse(System.Console.ReadLine());
		System.Console.WriteLine($"number {one} x number {two} x number {three} = {one*two*three}");
	}	

}
