//Problem 4. Download file

//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.
using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        WebClient file = new WebClient();
        using (file)
        {
            try
            {
                file.DownloadFile(@"http://www.weapons-universe.com/Martial_Arts/Ninja/Ninja_God.jpg", @"..\..\ninja.jpg");
            }
            catch (System.ArgumentNullException an)
            {
                Console.WriteLine(an);
            }
            catch(System.Net.WebException we)
            {
                Console.WriteLine(we);
            }
            catch(System.NotSupportedException ns)
            {
                Console.WriteLine(ns);
            }
        }        
    }
}

