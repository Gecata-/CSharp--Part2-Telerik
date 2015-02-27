//Problem 4. Compare text files

//Write a program that compares two text files line by line and prints the number 
//of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.
using System;
using System.IO;

    class CompareTextFiles
    {
        static void Main()
        {
            var streamReader = new StreamReader(@"..\..\LoremIpsum.txt");
            var secondStreamReader = new StreamReader(@"..\..\LoremIpsum2.txt");
            string firstTextLine;
            string secondTextLine;
            int sameLines = 0;
            int differentlines = 0;
            using (streamReader)
            {
                using (secondStreamReader)
                {
                    firstTextLine = streamReader.ReadLine();
                    secondTextLine = secondStreamReader.ReadLine();
                    while (firstTextLine != null && secondTextLine != null)
                    {
                        if (firstTextLine == secondTextLine)
                        {
                            sameLines++;
                        }
                        else
                        {
                            differentlines++;
                        }
                        firstTextLine = streamReader.ReadLine();
                        secondTextLine = secondStreamReader.ReadLine();
                    }
                }                          
            }
            Console.WriteLine("There are {0} same lines and {1} different lines in bouth texts",sameLines,differentlines);
        }
    }

