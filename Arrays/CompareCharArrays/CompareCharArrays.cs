//Problem 3. Compare char arrays

//Write a program that compares two char arrays lexicographically (letter by letter).
using System;

    class CompareCharArrays
    {
        static void Main()
        {
            Console.WriteLine("Enter two char arrays to compare lexicographically" );

            Console.WriteLine(" Enter the lenght of both arrays:");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 1-st array:");
            char[] array1 = new char[length];
             char[] array2 = new char[length];
                
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("First array [{0}]", i);
                array1[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter 2-nd array:");            
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("First array [{0}]", i);
                array2[i] = char.Parse(Console.ReadLine());
            }
            for (int i = 0; i < length; i++)
            {
                if (array1[i] == array2[i])
                {
                    Console.WriteLine("Both Arrays are equal at [{0}] element",i);
                }
                else
                {
                    Console.WriteLine("Both Arrays are different at [{0}] element",i);
                }
            }
        }
    }

