//Problem 14. Integer calculations

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.
using System;

class IntegerCalculations
{
    static void Main()
    {
        int[] arr = { 1, 3, 7, 9, 3 };
        // Uncomment to test.
        // int[] arr = { 1, 2, 3, 4, 5 };
        // int[] arr = { 1, 2, 3, 4, 5, 78, 8, 7, 5, 92, 4 };
        // int[] arr = { 1, 2, 3};

        Console.WriteLine(Maximum(arr));
        Console.WriteLine(Minimum(arr));
        Console.WriteLine(Average(arr));
        Console.WriteLine(Sum(arr));
        Console.WriteLine(Product(arr));
    }

    static int Product(params int[] arr)
    {
        int product = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            product *= arr[i];
        }
        return product;
    }

    static int Sum(params int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }

    static decimal Average(params int[] arr)
    {
        decimal average = 0;
        decimal sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        average = sum / arr.Length;
        return average;
    }

    static int Maximum(params int[] arr)
    {
        int max = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }

    static int Minimum(params int[] arr)
    {
        int min = int.MaxValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return min;
    }
}

