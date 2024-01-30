using System;

public class Ecercies22
{
	public static void Main()
	{	
		Console.WriteLine("Inputan integer:");
		int x = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine(result(x));
	}
	public static bool result(int n) {
        if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
            return true;
        return false;
    }
}
