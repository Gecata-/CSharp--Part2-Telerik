//Problem 5. Larger than neighbours

//Write a method that checks if the element at given position 
//in given array of integers is larger than its two neighbours (when such exist).
using System;

class LargerThanNeighbours
{
    static void Main()
    {
        int[] arr = { 1, 5, 3, 4, 9, 6 };
        int position = 4;
        Console.WriteLine("The number at position {0} is larger that its neigbours : {1} ",position ,LargerThanNeigbours(arr, position)) ;
    }

    static bool LargerThanNeigbours(int[] array, int index)
    {
        bool isLarger = false;
        if ((index - 1) >= 0 && (index + 1) < array.Length)
        {
            if (array[index] > array[index + 1] && array[index] > array[index - 1])
            {
                isLarger = true;
            }
        }
        return isLarger;
    }
}

