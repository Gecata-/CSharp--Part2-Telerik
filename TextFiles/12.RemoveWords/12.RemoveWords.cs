//Problem 12. Remove words

//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.
using System;
using System.IO;

class RemoveWords
{
    static void Main()
    {
        try
        {
            var streamReader = new StreamReader(@"..\..\Robocop.txt");
            var secondStreamReader = new StreamReader(@"..\..\words.txt");

            string text = streamReader.ReadToEnd();
            string words = secondStreamReader.ReadToEnd();

            string[] wordsToRemove = words.Split(' ');
            for (int i = 0; i < wordsToRemove.Length; i++)
            {
                text = text.Replace(wordsToRemove[i], "");
            }
            streamReader.Close();
            secondStreamReader.Close();

            var streamWriter = new StreamWriter(@"..\..\Robocop.txt");
            streamWriter.Write(text);
            streamWriter.Close();
        }
        catch (System.IO.FileNotFoundException)
        {
            Console.WriteLine("File is not found");
        }
        catch (System.ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch (System.UnauthorizedAccessException uae)
        {
            Console.WriteLine(uae.Message);
        }
        catch (System.OutOfMemoryException ome)
        {
            Console.WriteLine(ome.Message);
        }
    }
}



