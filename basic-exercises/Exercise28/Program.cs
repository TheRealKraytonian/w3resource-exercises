using System;


namespace Name
{

    public class Exercise28()
    {

        public static void Main()
        {
            string reversedString = ReverseWords("Display the pattern like pyramid using the alphabet.");
            Console.WriteLine($"Original String: {reversedString}");
            Console.WriteLine($"Reversed String: {ReverseWords(reversedString)}");
        }

        public static string ReverseWords(string str)
        {
            //turn the string into an array
            string[] wordsList = str.Split(" ");
            string[] newWordsList = new string[wordsList.Length];

            //use reverse method 
            int storeValue = 0;
            for (int i = wordsList.Length - 1; i >= 0; i--)
            {
                newWordsList[storeValue] = wordsList[i];
                storeValue++;
            }

            //turin it back into a string
            string revStr = string.Join(" ", newWordsList);
            return revStr;
        }
    }
}
