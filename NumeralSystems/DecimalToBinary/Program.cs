//Problem 1. Decimal to binary

//Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter decimal number to see its binary representation: " );
            int number = int.Parse(Console.ReadLine());
            List<int> binary = new List<int>();
            int bin = 1;
            while (number > 0)
            {
                 int secondTemp = number;
                 int temp = number;
                 secondTemp %= 2;
                 temp /= 2;
                 number = temp;
                 bin = secondTemp;
                 binary.Add(secondTemp);                 
            }
            binary.Reverse();
            for (int i = 0; i < binary.Count; i++)
            {
                Console.Write(binary[i]);
            }
            Console.WriteLine();
        }
    }

