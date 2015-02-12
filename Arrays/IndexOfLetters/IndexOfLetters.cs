//Problem 12. Index of letters

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.
using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
        Console.WriteLine("Enter word to see its letter indexes");
        string word = Console.ReadLine();
        char[] wordLetter = new char[word.Length];
        int x = 0;

        foreach (var letter in word)
        {
            wordLetter[x] = letter;
            x++;
        }
        for (int i = 0; i < wordLetter.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (wordLetter[i] == alphabet[j])
                {
                    Console.WriteLine("Letter {0} has {1} index in Alphabet array.", wordLetter[i], j);
                }
            }
        }

    }
}


