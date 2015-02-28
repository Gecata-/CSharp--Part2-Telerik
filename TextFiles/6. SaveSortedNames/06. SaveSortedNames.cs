// Problem 6. Save sorted names
   
// Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
// Example:
   
// input.txt	     output.txt

// Ivan              George
// Peter             Ivan 
// Maria             Maria 
// George	         Peter

using System;
using System.Collections.Generic;
using System.IO;


class SaveSortedNames
{
    static void Main()
    {
        var streamReader = new StreamReader(@"..\..\input.txt");
        string currentName = streamReader.ReadLine();
        List<string> textNames = new List<string>();
        while (currentName != null)
        {
            textNames.Add(currentName);
            currentName = streamReader.ReadLine();
        }
        textNames.Sort();
        var streamWriter = new StreamWriter(@"..\..\output.txt");
        for (int i = 0; i < textNames.Count; i++)
        {
            streamWriter.WriteLine(textNames[i].Trim());
        }
        streamReader.Close();
        streamWriter.Close();
    }
}

