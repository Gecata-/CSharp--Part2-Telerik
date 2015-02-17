//Problem 8. Number as array

//Write a method that adds  two positive integer numbers represented as 
//arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.
using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

class NumberAsArray
{
    static void Main()
    {
        Console.WriteLine("Please enter big number.");
        string firstNum = Console.ReadLine();
        Console.WriteLine("Please enter second big number.");
        string secondNum = Console.ReadLine();
        if (IsCorrectNumber(firstNum) && IsCorrectNumber(secondNum))
        {
            List<BigInteger> result = AddTwoArrays(firstNum, secondNum);
            PrintResult(result);
        }
        else
        {
            Console.WriteLine("You have entered invalid number!");
        }
    }

    static List<BigInteger> AddTwoArrays(string numberA, string numberB)
    {
        char[] arrFirst = numberA.ToCharArray();
        char[] arrSecond = numberB.ToCharArray();
        BigInteger[] arrFirstNum = ConvertToInt(arrFirst);
        BigInteger[] arrSecondNum = ConvertToInt(arrSecond);
        Array.Reverse(arrFirstNum);
        Array.Reverse(arrSecondNum);

        List<BigInteger> result = new List<BigInteger>(Math.Max(arrFirstNum.Length, arrSecondNum.Length));
       
        BigInteger left = 0;
        for (int i = 0; i < result.Capacity; i++)
        {
            BigInteger num = (i < arrFirstNum.Length ? arrFirstNum[i] : 0) + (i < arrSecondNum.Length ? arrSecondNum[i] : 0) + left;
            left = num / 10;
            result.Add(num % 10);
        }

        if (left > 0) result.Add(left);
        return result;
    }

    static BigInteger[] ConvertToInt(char[] arr)
    {
        BigInteger[] arrInt = new BigInteger[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            arrInt[i] = arr[i] - '0';
        }
        return arrInt;
    }

    static bool IsCorrectNumber(string number)
    {
        return number.All(t => t >= '0' && t <= '9');
    }

    static void PrintResult(List<BigInteger> result)
    {
        for (int i = result.Count - 1; i >= 0; i--)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine("\n");
    }
}

