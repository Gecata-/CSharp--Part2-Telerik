// Problem 6. Save sorted names
   
// Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
// Example:
   
// input.txt	     output.txt

// Ivan              George
// Peter             Ivan 
// Maria             Maria 
// George	         Peter

using System;
using System.IO;

class SaveSortedNames
{
    static void Main()
    {
        var streamReader = new StreamReader(@"..\..\input.txt");
        string text = streamReader.ReadToEnd();
        string[] input = text.Split(' ');

    }
}

