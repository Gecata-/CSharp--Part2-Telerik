//Problem 10. N Factorial

//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number 
//represented as array of digits by given integer number.
using System;
using System.Numerics;

class NFactorial
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            BigInteger result = FactorialN(i);
            Console.WriteLine(result);
        }
    }
    static BigInteger FactorialN(int n)
    {
        BigInteger result = 1;
        int[] arr = new int[n];
        for (int i = 0, j = 1; i < arr.Length; i++, j++)
        {
            arr[i] = j;
            result *= arr[i];
        }
        return result;
    }
}

