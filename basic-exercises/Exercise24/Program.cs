using System;

public class Exercise24
{
	public static void Main()
	{
		string longestWord = LongestWord("Write a C# Sharp Program to display the following pattern using the alphabet");
		Console.WriteLine("Longest word:" + longestWord);
	}

	public static string LongestWord(string phrase)
	{
		string[] lwlist = phrase.Split(" ");
		string longestWord = lwlist.FirstOrDefault();
		foreach(string word in lwlist)
		{
			if(word.Length > longestWord.Length)
			{
				longestWord = word;
			}
		}
		return longestWord; 
	}
}
