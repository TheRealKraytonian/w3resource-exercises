using System;

public class Exercise26
{
	public static void Main()
	{
		int total = 0;
		int counter = 0;
		int firstPrime = 0;

		while (counter < 500)
		{
			if(IsPrime(firstPrime))
			{
				total += firstPrime;
				counter++;
				Console.WriteLine($"{counter}: {total}");
			}
			firstPrime++;
		}
		Console.WriteLine($"{total}");
	}

	public static bool IsPrime(int number)
	{
    if (number <= 1) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;

    var boundary = (int)Math.Floor(Math.Sqrt(number));
          
    for (int i = 3; i <= boundary; i += 2)
        if (number % i == 0)
            return false;
    
    return true;        
	}
}
