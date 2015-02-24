//Problem 21. Letters count

//Write a program that reads a string from the console and prints all different letters
//in the string along with information how many times each letter is found.
using System;
using System.Collections.Generic;

class LettersCount
{
    static void Main()
    {
        string text = "Write a program that reads a string from the console and prints all different letters";
        var result = new Dictionary<char, int>();

        for (int i = 0; i < text.Length; i++)
        {
            if ( !result.ContainsKey(text[i]) && char.IsLetter(text[i]))
            {
                result.Add(text[i], 0);
            }
            if (result.ContainsKey(text[i]) && char.IsLetter(text[i]))
            {
                result[text[i]] += 1;
            }
        }
        foreach (var letter in result)
        {
            Console.WriteLine("{0} letter is repeated {1} times.",letter.Key, letter.Value);
        }
    }
}

