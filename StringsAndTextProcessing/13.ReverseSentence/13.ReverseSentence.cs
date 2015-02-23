//Problem 13. Reverse sentence

//Write a program that reverses the words in given sentence.
//Example:

//input	                                        output
//C# is not C++, not PHP and not Delphi!	    Delphi not and PHP, not C++ not is C#!
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

class ReverseSentence
{
    static void Main()
    {
        string input = "C# is not C++, not PHP and not Delphi!";

        var reverse = new StringBuilder();
        char lastChar = input[input.Length - 1];
        input = input.Substring(0, input.Length - 1);
        string[] words = input.Split(' ');
        List<int> commas = new List<int>();
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Contains(','))
            {
                commas.Add(i);
                words[i] = words[i].Substring(0, words[i].Length - 1);
            }
        }
        List<string> reversedWords = new List<string>(words.Reverse());
        if (commas.Count > 0)
        {
            for (int i = 0; i < commas.Count; i++)
            {
                reversedWords[commas[i]] +=',';
            }
        }

        Console.WriteLine(string.Join(" ",reversedWords) + lastChar);
    }
}



