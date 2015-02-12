//Problem 7. Selection sort

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.
using System;

class SelectionSort
{
    static void Main()
    {
        int[] arr = new int[10];
        Random rnd = new Random();     
        int maxElement = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(1, 50);
            Console.WriteLine("[{0}] -> {1}", i, arr[i]);
        }


        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    maxElement = arr[i];
                    arr[i] = arr[j];
                    arr[j] = maxElement;
                }
            }
        }
        Console.Write(new string('-',10));
        Console.WriteLine();
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("[{0}] -> {1}", i, arr[i]);
        }
    }
}