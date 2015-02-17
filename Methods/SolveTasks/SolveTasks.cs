//  Problem 13. Solve tasks

//  Write a program that can solve these tasks:
//  Reverses the digits of a number
//  Calculates the average of a sequence of integers
//  Solves a linear equation a * x + b = 0
//  Create appropriate methods.
//  Provide a simple text-based menu for the user to choose which task to solve.
//  Validate the input data:
//      The decimal number should be non-negative
//      The sequence should not be empty
//      'a' should not be equal to 0
using System;

class SolveTasks
{
    static void Main()
    {
        Console.WriteLine("Choose the number of the program that solves the desired task:");
        Console.WriteLine();
        Console.WriteLine("1) Reverses the digits of a number \n2) Calculates the average of a sequence of integers");
        Console.WriteLine("3) Solves a linear equation a * x + b = 0 ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.Write("Please enter number:");
                string n = Console.ReadLine();

                Reverse(n);
                break;

            case 2:
                Console.WriteLine(" Please enter an array of positive numbers devided by ','");
                string input = Console.ReadLine();
                string[] arr = input.Split(',', ' ');

                decimal[] secondArr = new decimal[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    secondArr[i] = Convert.ToDecimal(arr[i]);
                }

                AverageArr(secondArr);
                break;

            case 3:
                Console.WriteLine("Please enter 'a' and 'b' to find for you 'x':");
                Console.WriteLine("'a' should not be equal to 0");
                Console.Write("a = ");
                decimal a = decimal.Parse(Console.ReadLine());
                Console.Write("b = ");
                decimal b = decimal.Parse(Console.ReadLine());

                SolveEquation(a, b);
                break;
        }
    }

    private static void SolveEquation(decimal a, decimal b)
    {
        //a * x + b = 0
        if (a != 0)
        {
            decimal x = -b / a;
            Console.WriteLine(" x = {0} ", x);
        }
        else
        {
            Console.WriteLine("'a' is 0.");
        }

    }

    private static void AverageArr(decimal[] arr)
    {
        decimal average = 0;
        decimal sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        if (average > 0)
        {
            average = sum / arr.Length;
            Console.WriteLine("The average of the sequence is {0}.", average);
        }
        else
        {
            Console.WriteLine("The average is negative number");
        }

    }
    static void Reverse(string n)
    {
        char[] arr = n.ToCharArray();

        for (int i = 0; i < arr.Length / 2; i++)
        {
            char temp = arr[i];
            arr[i] = arr[arr.Length - 1 - i];
            arr[arr.Length - 1 - i] = temp;
        }
        string reversed = string.Join("", arr);
        Console.WriteLine("Reversed number is: {0}.", reversed);
    }
}

