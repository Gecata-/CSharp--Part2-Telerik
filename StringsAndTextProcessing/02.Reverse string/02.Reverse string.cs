//Problem 2. Reverse string

//Write a program that reads a string, reverses it and prints the result at the console.
//Example:

//input	        output
//sample	    elpmas
using System;
using System.Linq;

class Reversestring
{
    static void Main()
    {
        //string str = "sample";
        string str = Console.ReadLine();
        string reverse = new string(str.Reverse().ToArray());
        Console.WriteLine(reverse);
    }
}

