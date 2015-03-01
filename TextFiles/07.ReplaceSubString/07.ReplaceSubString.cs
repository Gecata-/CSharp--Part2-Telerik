//Problem 7. Replace sub-string

//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).
using System;
using System.IO;

class ReplaceSubString
{
    static void Main()
    {
        
        string text;
        string firstWord = "START";
        string secondWord = "FINISH";
        using (var streamReader = new StreamReader(@"..\..\text.txt"))
        {
            text = streamReader.ReadToEnd();
        }
        string replacedText = text.Replace(firstWord, secondWord);        
        using (var streamWriter = new StreamWriter(@"..\..\replacedText.txt"))
        {
            streamWriter.Write(replacedText);
        }
    }
}

