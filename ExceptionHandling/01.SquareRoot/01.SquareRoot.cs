//Problem 1. Square root

//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.
//Use try-catch-finally block.
using System;

class SquareRoot
{
    static void Sqrt(string num)
    {
        try
        {
            int number = int.Parse(num);
            double sqrt = Math.Sqrt(number);
            Console.WriteLine(sqrt);
            if (number < 0)
            {
                throw new System.ArgumentOutOfRangeException();
            }
        }
        catch (System.FormatException)
        {
            throw;
        }
    }
    static void Main()
    {
        string num =Console.ReadLine();
        try
        {
            Sqrt(num); 
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (System.ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number");
        }
        finally 
        {
            Console.WriteLine("Goodbye");
        }
    }
}

