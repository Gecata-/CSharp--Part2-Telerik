//Problem 8. Binary short

//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
using System;
using System.Collections.Generic;



    class BinaryShort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter signed short number:");
            short signed = short.Parse(Console.ReadLine());
            if (signed > 0)
            {
                Console.WriteLine("Invalid number, please enter negative number.");
            }
            short number = (short)(signed * -1);
            List<int> binary = new List<int>();
            int bin = 1;
            int bit = 1;
            while (number > 0)
            {
                int secondTemp = number;
                short temp = number;
                secondTemp %= 2;
                temp /= 2;
                number = temp;
                bin = secondTemp;
                binary.Add(secondTemp);
            }
            if (signed < 0)
            {
                if (binary.Count<16)
                {
                    bit = 16 - binary.Count;
                }
                for (int i = 0; i < bit ; i++)
                {
                    binary.Add(1);
                }                
            } 
            binary.Reverse();                      
            for (int i = 0; i < binary.Count; i++)
            {
                Console.Write(binary[i]);
            }
            Console.WriteLine();
        }
    }

