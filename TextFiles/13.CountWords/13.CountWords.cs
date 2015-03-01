// Problem 13. Count words

// Write a program that reads a list of words from the file words.txt
// and finds how many times each of the words is contained in another file test.txt.
// The result should be written in the file result.txt and the
// words should be sorted by the number of their occurrences in descending order.
// Handle all possible exceptions in your methods.
using System;
using System.Collections.Generic;
using System.IO;

class CountWords
{
    static void Main()
    {
        var streamReader = new StreamReader(@"..\..\words.txt");
        var secondStreamReader = new StreamReader(@"..\..\test.txt");

        string words = streamReader.ReadToEnd();
        string text = secondStreamReader.ReadToEnd();
        string[] word = words.Split(' ');
        string[] textWords = text.Split(' ');
        var result = new Dictionary<string, int>();
        for (int i = 0; i < word.Length; i++)
        {
            result.Add(word[i], 0);
        }
        foreach (string item in textWords)
        {
            if (result.ContainsKey(item))
            {
                result[item] += 1;
            }
        }
        var streamWriter = new StreamWriter(@"..\..\result.txt");
        foreach (var item in result)
        {
            streamWriter.Write("word: \"{0}\" had occured {1} times\r\n", item.Key, item.Value);
        }

        streamReader.Close();
        secondStreamReader.Close();
        streamWriter.Close();
    }
}

