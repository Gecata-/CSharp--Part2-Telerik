//Problem 22. Words count

//Write a program that reads a string from the console and lists all 
//different words in the string along with information how many times each word is found.
using System;
using System.Collections.Generic;


class WordsCount
{
    static string Text()
    {
        string loremIpsum = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
 Phasellus lorem est, mollis a odio at, consequat tempus nulla. 
 Cras ut blandit sapien, nec ullamcorper erat. Donec ac semper justo.
 Aliquam quis tortor faucibus, fringilla sapien ut, efficitur leo.
 Duis vitae libero sapien. Vestibulum tempus pulvinar sollicitudin. 
 Sed volutpat, sapien sed posuere elementum, nisl sapien euismod eros, et elementum diam turpis vitae leo. 
 Curabitur nec justo in est rhoncus aliquam eget sed purus. Nam non dictum nibh, quis accumsan nulla. 
 Donec tempus lectus mollis mauris accumsan congue. Nunc laoreet congue scelerisque. Aenean ac justo nulla. 
 Vivamus nec tempor orci. In fringilla.";

        return loremIpsum;
    }
    static void Main()
    {
        var result = new Dictionary<string, int>();
        string text = Text();
        text = text.Replace(',', '\0');
        text = text.Replace('.', '\0');
        string[] word = text.Split(' ');
        for (int i = 0; i < word.Length; i++)
        {
            if (!result.ContainsKey(word[i]))
            {
                result.Add(word[i], 0);
            }
            if (result.ContainsKey(word[i]))
            {
                result[word[i]] += 1;
            }
        }
        foreach (var resultWord in result)
        {
            Console.WriteLine("The word \"{0}\" is repeated {1} in text.", resultWord.Key, resultWord.Value);
        }
    }
}

