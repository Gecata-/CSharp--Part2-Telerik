//Problem 14. Word dictionary

//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.
//Sample dictionary:

//input	         output
//.NET	         platform for applications from Microsoft
//CLR	         managed execution environment for .NET
//namespace	     hierarchical organization of classes
using System;
using System.Collections.Generic;

class WordDictionary
{
    static void Main()
    {
        var dictionary = new Dictionary<string, string> 
        {
            {".NET","platform for applications from Microsof"},
            {"CLR","managed execution environment for .NET"},
            {"namespace","hierarchical organization of classes"}           
        };
        Console.WriteLine("Enter word:");
        string input = Console.ReadLine();
        if (dictionary.ContainsKey(input))
        {
            Console.WriteLine(dictionary[input]);
        }
        else
        {
            Console.WriteLine("No such word in dictionary");
        }
    }
}

