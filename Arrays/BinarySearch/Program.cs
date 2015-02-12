//Problem 11. Binary search

//Write a program that finds the index of given element in a sorted array of 
//integers by using the Binary search algorithm.
using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 6, 4, 5, 16, 27, 3, 9, 14 };
        int start;
        int end;
        int mid = 0;
        int key = 4;

        //int n = Array.BinarySearch<int>(arr, 9);
        //Console.WriteLine(n);

        end = arr.Length - 1;
        start = 0;
        Array.Sort(arr);
        while (start <= end)
        {
            mid = (start + end) / 2;
            if (arr[mid] < key)
            {
                start = mid + 1;
            }
            else if (key < arr[mid])
            {
                end = mid - 1;
            }
            else
            {
                Console.WriteLine(mid);
                break;            
            }
        }
    }
}

