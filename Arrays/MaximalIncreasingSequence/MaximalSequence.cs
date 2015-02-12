//Problem 5. Maximal increasing sequence

//Write a program that finds the maximal increasing sequence in an array.
//Example:

//input	                    result
//3, 2, 3, 4, 2, 2, 4	    2, 3, 4
using System;
using System.Collections.Generic;

class MaximalSequence
{
    static void Main()
    {
        string sequence = Console.ReadLine();
        string[] input = sequence.Split(',');
        int length = 7;
        int[] arr1 = new int[7];
        int[] arr2 = new int[7];
        int countSeq = 1;
        int maxSeq = 1;
        int number = 0;

        for (int i = 0; i < length; i++)
        {
            arr1[i] = Convert.ToInt32(input[i]);            
        }
        arr2 = (int[])arr1.Clone();
        for (int i = 0; i < arr1.Length - 1; i++)
        {
            if (arr1[i] == (arr2[i + 1] - 1))
            {
                countSeq++;
                if (countSeq > maxSeq)
                {
                    maxSeq = countSeq;
                    number = arr1[i];
                    number -= (maxSeq - 1);
                }
                else
                {
                    countSeq = 1;
                }
            }
        }
        for (int j = 0; j < maxSeq; j++)
        {
            number++;
            Console.Write("{0}, ", number);
        }
    }
}


