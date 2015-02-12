//Problem 8. Maximal sum

//Write a program that finds the sequence of maximal sum in given array.
//Example:

//input	                                     result
//2, 3, -6, -1, 2, -1, 6, 4, -8, 8	         2, -1, 6, 4
//Can you do it with only one loop (with single scan through the elements of the array)?
using System;
using System.Collections.Generic;

class MaximalSum
{
    static void Main()
    {
        string input = "2, 3, -6, -1, 2, -1, 6, 4, -8, 8";

        int number = 0;
        string[] digit = new string[10];
        int[] numbers = new int[digit.Length];
        digit = input.Split(',');
        int maxSum = 0;
        int currentSum = 0;
        int startIndex = 0;
        int endIndex = 0;
      
        for (int i = 0; i < digit.Length; i++)
        {
            numbers[i] = Convert.ToInt32(digit[i]);
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            if (currentSum <= 0)
            {
                startIndex = i;
                currentSum = 0;
            }
            currentSum += numbers[i];
            if (currentSum > maxSum)
            {
                maxSum = currentSum;               
                endIndex = i;
            }
        }
        Console.Write("The best sequance is: ");
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    }
}


