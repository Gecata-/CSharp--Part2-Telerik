//Problem 9. Forbidden words

//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.
//Example text: Microsoft announced its next generation PHP compiler today.
//It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

//Forbidden words: PHP, CLR, Microsoft

//The expected result: ********* announced its next generation *** compiler today.
//It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
using System;
using System.Collections.Generic;
using System.Text;

class ForbiddenWords
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today.\nIt is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        var forbidenWords = new List<string>{"PHP", "CLR", "Microsoft"};
        string correctedText = text;
        string[] words = text.Split(' ');

        for (int i = 0; i < forbidenWords.Count; i++)
        {
            correctedText = correctedText.Replace(forbidenWords[i], new string('*', forbidenWords[i].Length));          
        }
        Console.WriteLine(correctedText);      
    }
}

