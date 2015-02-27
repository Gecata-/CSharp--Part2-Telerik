//Problem 3. Read file contents

//Write a program that enters file name along with its full file path 
//(e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.
using System;
using System.IO;

class ReadFileContents
{
    static void Main()
    {
        Console.WriteLine("Enter file path to read it:");
        string path = Console.ReadLine();        
        try
        {
            var reader = new StreamReader(path);
            using (reader)
            {               
                string file = reader.ReadToEnd();
                Console.WriteLine(file);
            }          
        }       
        catch (System.IO.DirectoryNotFoundException)
        {
            Console.WriteLine("No such path");
        }
        catch (System.ArgumentNullException)
        {
            Console.WriteLine("Empty file");
        }
        catch (System.ArgumentException)
        {
            Console.WriteLine("Invalit type of file");
        }
        catch (System.IO.FileNotFoundException)
        {
            Console.WriteLine("File is not found");
        }
        catch (System.IO.IOException)
        {
            Console.WriteLine("Error occured");
        }                             
    }
}

