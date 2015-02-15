//Problem 4. Binary search

//Write a program, that reads from the console an array of N integers and an integer K,
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
using System;

class BinarySearch
{
    static void Main()
    {
        int currentBigNumber = int.MinValue;
        int index = 0;
        //int k = 100;
        //int[] arr = new int[] { 1, 2, 37, 4, 5, 99, 11, 2, 3, 5, 4, 6, 8, 9 };

        Console.Write(" Enter number of elements for an array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("element [{0}]: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        Console.WriteLine(" Enter number 'K' to test: 'N ≤ K': ");
        int k = int.Parse(Console.ReadLine());
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < k && arr[i] > currentBigNumber)
            {
                currentBigNumber = arr[i];
                index = Array.BinarySearch(arr, currentBigNumber);
            }
            else if (arr[i] == k)
            {
                currentBigNumber = arr[i];
                index = Array.BinarySearch(arr, currentBigNumber);
            }
        }
        Console.WriteLine(arr[index]);
    }
}

