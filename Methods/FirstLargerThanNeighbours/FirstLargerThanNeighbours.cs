//Problem 6. First larger than neighbours

//Write a method that returns the index of the first element in array that is 
//larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.
using System;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        int[] arr = { 1, -15, 2, 4, 9, 6, 4, 7, 3, 4 };
        //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
        Console.WriteLine("First element larget than its neigbours is at index : {0} ",
                                                                    FirstLargeElement(arr));     
    }
    static int FirstLargeElement(int[] array)
    {
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (LargerThanNeigbours(array, i))
            {
                index = i;
                break;
            }
            else
            {
                index = -1;
            }
        }
        return index;
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

