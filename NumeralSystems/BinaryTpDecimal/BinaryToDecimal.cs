//Problem 2. Binary to decimal

//Write a program to convert binary numbers to their decimal representation.
using System;
using System.Collections.Generic;
class BinaryTpDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter binary number to see it in decimal representation");
        int binary = int.Parse(Console.ReadLine());
        int decimalNumber = 0;
        int length = binary.ToString().Length;
        List<int> binDigits = new List<int>();
        int digit = 0;
        for (int i = 0; i < length; i++)
        {
            digit = binary % 10;
            binary /= 10;
            if (digit == 1 || digit == 0)
            {


                binDigits.Add(digit);
            }
            else
            {
                Console.WriteLine("Not a binnary number");
                return;
            }
        }
        for (int i = 0; i < binDigits.Count; i++)
        {
            decimalNumber += binDigits[i] * (int)Math.Pow(2, i);
        }
        Console.WriteLine(decimalNumber);

    }
}
