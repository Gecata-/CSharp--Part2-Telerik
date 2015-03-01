//Problem 9. Delete odd lines

//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.
using System;
using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        string text;
        string oddLine;
        int count = 1;
        using (var streamReader = new StreamReader(@"..\..\LoremIpsum.txt"))
        {
            text = streamReader.ReadToEnd();
            text = string.Concat(text, new string('#', 100));
        }
        var secondStreamReader = new StreamReader(@"..\..\LoremIpsum.txt");
        text = string.Concat(text, "\r\n");
        text = string.Concat(text, oddLine = secondStreamReader.ReadLine());
        while (oddLine != null)
        {
            count++;
            if (count % 2 != 0)
            {
                text = string.Concat(text, "\r\n");
                text = string.Concat(text, oddLine = secondStreamReader.ReadLine());
            }
            else
            {
                oddLine = secondStreamReader.ReadLine();
            }
        }

        secondStreamReader.Close();

        using (var streamWriter = new StreamWriter(@"..\..\LoremIpsum.txt"))
        {
            streamWriter.Write(text);
        }
    }
}


