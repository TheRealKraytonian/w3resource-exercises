using System;

public class Exercise
{

    public static void Main()
    {
        Console.WriteLine("Give me a hexadecimal number");

        string hexaDec = Console.ReadLine();

        int num = Int32.Parse(hexaDec, System.Globalization.NumberStyles.HexNumber);

        Console.WriteLine("{0}", num);
    }
}
