//Problem 1. Odd lines

//Write a program that reads a text file and prints on the console its odd lines.
using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        StreamReader streamReader = new StreamReader(@"..\..\LoremIpsum.txt");
        using (streamReader)
        {
            string line = streamReader.ReadLine();
            int oddLine = 1;
            while (line != null)
            {
                if (oddLine % 2 == 1)
                {
                    Console.WriteLine("Line : {0}: {1}", oddLine, line);
                }
                line = streamReader.ReadLine();
                oddLine++;
            }
        }
        
    }
}

