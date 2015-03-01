// Problem 11. Prefix "test"

// Write a program that deletes from a text file all words that start with the prefix "test".
// Words contain only the symbols 0…9, a…z, A…Z, _.
using System;
using System.Collections.Generic;
using System.IO;

class PrefixTest
{
    static void Main()
    {
        string text;
        string[] testWords;
        using (var streamReader = new StreamReader(@"..\..\PrefixTest.txt"))
        {
            text = streamReader.ReadToEnd();
        }
        testWords = text.Split(' ');
        text = text.Remove(0);
        for (int i = 0; i < testWords.Length; i++)
        {
            if (testWords[i].Contains("test"))
            {
                text = string.Concat(text," "+ testWords[i]);
            }
        }
        using (var streamWriter = new StreamWriter(@"..\..\PrefixTestDeleted.txt"))
        {
            streamWriter.Write(text);
        }
    }
}

