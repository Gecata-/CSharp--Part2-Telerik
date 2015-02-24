//Problem 20. Palindromes

//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
using System;
using System.Text;
using System.Collections.Generic;

class Palindromes
{
    static void Main()
    {
        string text = "ABBA, lamal, dog, dingo, exe, car, Roma, xixix, hahahahah";
        HashSet<string> palindromes = new HashSet<string>();
        string[] words = text.Split(',', ' ');
        foreach (var word in words)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] == word[word.Length - 1 - i] && i != word.Length - 1 + i)
                {
                    palindromes.Add(word);
                }
                else
                {
                    continue;
                }
            }
        }
        Console.WriteLine(String.Join(", ", palindromes));
    }
}
