//Problem 6. String length

//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.
using System;
using System.Text;

class StringLength
{
    static void Main()
    {
        var str = new StringBuilder(20,20);
        //string input = "Gosho";
        string input = Console.ReadLine();
        int append = str.Length - input.Length;
        str.Append(input);
        for (int i = input.Length; i < str.Capacity; i++)
        {
            str.Append('*');
        }
        Console.WriteLine(str);
        Console.WriteLine(str.Length);
    }
}

