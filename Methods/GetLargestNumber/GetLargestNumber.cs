//Problem 2. Get largest number

//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
using System;

class GetLargestNumber
{
    static void Main()
    {

        Console.WriteLine("please enter 3 numbers :");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
         int n = GetMax(a, b);
        int c = int.Parse(Console.ReadLine());
        int max = GetMax(n, c);

       
        Console.WriteLine("The Largest number is: {0} ", max);
    }

    static int GetMax(int a, int b)
    {
        int max = int.MinValue;

        if (a > b)
        {
            max = a;

        }
        else
        {
            max = b;
        }
        return max;
    }
}
