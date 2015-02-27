//Problem 3. Line numbers

//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.
using System;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        var streamReader = new StreamReader(@"..\..\LoremIpsum.txt");
        var streamWriter = new StreamWriter(@"..\..\LineNumbers.txt");
        int lineCount = 1;
        using (streamReader)
        {
            string line = streamReader.ReadLine();
            while (line != null)
            {
                streamWriter.WriteLine("{0}. {1}", lineCount.ToString(), line);
                line = streamReader.ReadLine();
                lineCount++;
            }
        }
        streamWriter.Close();
    }
}

