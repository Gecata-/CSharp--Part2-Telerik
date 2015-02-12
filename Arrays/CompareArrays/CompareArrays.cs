//Problem 2. Compare arrays

//Write a program that reads two integer arrays from the console and compares them element by element.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Write 2 two integer arrays");
        string n = Console.ReadLine();
        int lenght = n.Length;
        int[] arr1 = new int[lenght];
        int i = 0;
        foreach (var number in n)
        {
            
            
            arr1[i] = number - '0';
            //Console.WriteLine(arr1[i]);
            i++;
        }
        i = 0;
        string a = Console.ReadLine();
        int[] arr2 = new int[a.Length];
        foreach (var number in a)
        {
            
            
            arr2[i] = number - '0';
            //Console.WriteLine(arr2[i]);
            i++;
        }
        for (int j = 0; j < lenght; j++)
        {
           
            if (arr1[j] > arr2[j])
            {
                Console.WriteLine("The bigger element is: {0}",arr1[j]);
            }
            else
            {
                Console.WriteLine("The bigger element is: {0}",arr2[j]);
            }

            //int b = int.Parse(Console.ReadLine());
            //int[] arr2 = new int[b];
        }
    }
}
