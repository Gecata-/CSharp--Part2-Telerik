//roblem 15. Prime numbers

//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
using System;
using System.Collections.Generic;

    class PrimeNumbers
    {
        static void Main()
        {
             int end = 10000000;
        int remove = int.MinValue;
        int[] allNums = new int[end];
        for (int i = 0; i < end; i++)
        {
            allNums[i] = i + 1;
        }
        allNums[0] = int.MinValue;
        for (int i = 1; i < end - 1; i++)
        {
            if (allNums[i] * allNums[i] > end)
            {
                break;
            }

            for (int j = allNums[i] * allNums[i] - 1; j < end; j++)
            {
                if (allNums[i] != int.MinValue)
                {
                    if (allNums[j] % allNums[i] == 0)
                    {
                        allNums[j] = remove;
                    }
                }
            }
        }
        List<int> sieve = new List<int>();
        for (int i = 0; i < allNums.Length; i++)
        {
            if (allNums[i] != int.MinValue)
            {
                sieve.Add(allNums[i]);
            }
        }
        int primes = sieve.Count;
        Console.WriteLine("From 1 to {0}, there are {1} prime numbers.", end, primes);
        }

    }

