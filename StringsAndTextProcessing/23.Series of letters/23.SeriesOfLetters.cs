//Problem 23. Series of letters

//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
//Example:

//input	                        output
//aaaaabbbbbcdddeeeedssaa	    abcdedsa
using System;
using System.Collections.Generic;
using System.Text;

class SeriesOfLetters
{
    static void Main()
    {
        string text = "aaaaabbbbbcdddeeeedssaa";
        var result = new StringBuilder();
        for (int i = 0; i < text.Length-1; i++)
        {
            
            if (text[i] != text[i+1])
            {
                result.Append(text[i]);
            }
            else
            {
                continue;
            }
        }
        Console.WriteLine("{0}{1}",result, text[text.Length-1]);
       
    }
}

