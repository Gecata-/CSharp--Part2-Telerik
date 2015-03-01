//Problem 8. Replace whole word

//Modify the solution of the previous problem to replace only whole words (not strings).
using System;
using System.Collections.Generic;
using System.IO;

class ReplaceWholeWord
{
    static void Main()
    {
        string text;
        string firstWord = "START";
        string secondWord = "FINISH";
        List<string> replacedText = new List<string>();
        using (var streamReader = new StreamReader(@"..\..\text.txt"))
        {
            text = streamReader.ReadToEnd();
        }
        var textWords = text.Split(' ');
        foreach (string word in textWords)
        {
            if (word == firstWord && word.Length == firstWord.Length)
            {
                replacedText.Add(word.Replace(firstWord, secondWord));
            }
            else if (word == firstWord+('.') && word.Length == firstWord.Length+1)
            {
                replacedText.Add(word.Replace(firstWord, secondWord));
            }
            else
            {
                replacedText.Add(word);
            }   
        }
        using (var streamWriter = new StreamWriter(@"..\..\replacedText.txt"))
        {
            streamWriter.Write(string.Join(" ",replacedText));
        }
    }
}

