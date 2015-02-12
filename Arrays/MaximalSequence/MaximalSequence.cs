//Problem 4. Maximal sequence

//Write a program that finds the maximal sequence of equal elements in an array.
//Example:

//input	                            result
//2, 1, 1, 2, 3, 3, 2, 2, 2, 1	    2, 2, 2
using System;
using System.Collections.Generic;

class MaximalSequence
{
    static void Main()
    {
        Console.WriteLine("Enter number of elements:");
        int length = int.Parse(Console.ReadLine());
        string[] numbers = new string[length];
        int maxSequence = 1;
        int sequence = 1;
        string element = null;

        Console.WriteLine("Enter the elements diveded by ',' :");
        string input = Console.ReadLine();
        numbers = input.Split(',');
        for (int i = 0; i < length-1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                sequence++;
                if (sequence > maxSequence)
                {
                    maxSequence = sequence;
                    element = numbers[i];
                }
            }
            else
            {
                sequence = 1;
            }
        }
        for (int i = 0; i < maxSequence; i++)
        {
            Console.Write("{0}, ",element);
        }
    }

}
