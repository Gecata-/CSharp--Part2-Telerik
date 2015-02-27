//Problem 2. Concatenate text files

//Write a program that concatenates two text files into another text file.
using System;
using System.IO;

class ConcatenateTextFiles
{
    static void Main()
    {
        var firstStreamReader = new StreamReader(@"..\..\LoremIpsum.txt");
        var secondStreamReader = new StreamReader(@"..\..\SecondText.txt");

        string firstText = firstStreamReader.ReadToEnd();
        string secondText = secondStreamReader.ReadToEnd();
        string concatenedText = string.Concat(firstText,secondText);
        var StreamWriter = new StreamWriter(@"..\..\ConcatenedText.txt");
        StreamWriter.Write(concatenedText);

        firstStreamReader.Close();
        secondStreamReader.Close();
        StreamWriter.Close();
    }
}

