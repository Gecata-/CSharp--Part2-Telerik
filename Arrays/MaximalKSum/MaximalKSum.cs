//Problem 6. Maximal K sum

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.
using System;

class MaximalKSum
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
       Console.WriteLine("Enter K:");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter an array with {0} elements divided by ',':",n);
        string input = Console.ReadLine();
        string[] arr = new string[n];
        int[] arr2 = new int[n];
        arr = input.Split(',');
        for (int i = 0; i < arr.Length; i++)
        {
            arr2[i] = Convert.ToInt32(arr[i]);            
        }
        Array.Sort(arr2);
        for (int i = arr2.Length-k; i < arr2.Length; i++)
        {
            Console.Write("{0} ,", arr2[i]);
        }

    }
}

