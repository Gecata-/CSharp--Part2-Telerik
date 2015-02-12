//Problem 9. Frequent number

//Write a program that finds the most frequent number in an array.
//Example:

//input	                                        result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	        4 (5 times)
using System;
using System.Collections.Generic;
class FrequentNumber
{
    static void Main()
    {
        int number = 0;
        int count = 1;
        int maxCount = 0;
        int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        Array.Sort(arr);

        for (int i = 0; i < arr.Length-1 ; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                count++;

            }
            else
            {
                count = 1;
            }
            if (count > maxCount)
            {
                maxCount = count;
                number = arr[i];

            }
        }
        Console.WriteLine(" {0} ({1} times)", number, maxCount);
    }
}

