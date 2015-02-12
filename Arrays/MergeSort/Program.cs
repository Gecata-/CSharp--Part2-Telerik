//Problem 13.* Merge sort

//Write a program that sorts an array of integers using the Merge sort algorithm.
using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int n = 15;
        int[] arr = new int[n];
        Random rnd = new Random();
        int start; int mid; int end;
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(15);
        }

        int[] why = new int[n];
        Console.WriteLine("Before Sorting: {0}", string.Join(", ",arr));
        MergeSort(arr, why, 0, arr.Length - 1);
        Console.WriteLine("After Merge Sorting: {0}", string.Join(", ", arr));

    }
    static void MergeSort(int[] elements, int[] temp, int start, int end)
    {
        if (start >= end) return;  // Array with 1 element

        int middle = start + (end - start) / 2; // Define a middle of the array

        MergeSort(elements, temp, start, middle);
        MergeSort(elements, temp, middle + 1, end);
        CompareAndSort(elements, temp, start, middle, end);
    }

    static void CompareAndSort(int[] elements, int[] temp, int start, int middle, int end)
    {
        int i = start; // 'temp' index
        int l = start, m = middle + 1; // 'elements' indexes

        while (l <= middle && m <= end)
            temp[i++] = (elements[l] > elements[m]) ? elements[m++] : elements[l++];

        while (l <= middle) temp[i++] = elements[l++];

        while (m <= end) temp[i++] = elements[m++];

        for (int j = start; j <= end; j++) elements[j] = temp[j];
    }
}
