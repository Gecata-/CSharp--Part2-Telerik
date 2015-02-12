//Problem 10. Find sum in array

//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:

//array	                 S	    result
//4, 3, 1, 4, 2, 5, 8	 11	    4, 2, 5
using System;
using System.Collections.Generic;
class FindSumInArray
{
    static void Main()
    {
        int[] arr = { 4, 3, 1, 4, 2, 5, 8 };
        int s = 11;
        int startIndex = 0;
        int endIndex = 0;
        int curSum = 0;
        int maxSum = 0;
        startIndex = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            curSum += arr[i];
            startIndex = i;
            for (int j = i+1; j < arr.Length; j++)
            {
                curSum += arr[j];
                if (curSum==s)
                {
                 
                    for (int k = startIndex ; k <= j; k++)
                    {
                        Console.Write(arr[k] +" ");
                        
                    }
                    break;
                }
            }
            curSum = 0;
        }
    }
}

