//Problem 1. Say Hello

//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.
//Example:

//input	output
//Peter	Hello, Peter!
using System;

class SayHello
{
    static void Main()
    {
        //uncomment to test.
        //string name = "Kondio";

        Console.Write(" Please enter your name : ");
        string name = Console.ReadLine();           
        UsersName(name);
    }
    static void UsersName(string name) 
    {                
            Console.Write("Hello, {0} ", name);
            Console.WriteLine();       
    }
}
