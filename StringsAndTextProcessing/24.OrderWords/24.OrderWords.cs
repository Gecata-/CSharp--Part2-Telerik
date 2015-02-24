﻿//Problem 24. Order words

//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
using System;

class OrderWords
{
    static void Main()
    {
        string text = "abba zoo bible row dino cable boss";
        string[] words = text.Split(' ');
        Array.Sort(words);
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
        
    }
}

