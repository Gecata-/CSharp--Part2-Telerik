//Problem 2. Enter numbers

//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
using System;

class EnterNumbers
{
    static void ReadNumber(int start, int end)
    {
        Console.WriteLine("Enter number such that: {0} < number < {1}", start, end);

        for (int i = 0; i < 10; i++)
        {
            string number = Console.ReadLine();         
            try
            {
                int validNumber = int.Parse(number);
                
                if (start > validNumber || end < validNumber)
                {
                    throw new System.ArgumentOutOfRangeException();
                }
            }
            catch (System.FormatException fe)
            {
                Console.WriteLine("Not a valid number: " + fe.Message); ;
            }
            catch (System.ArgumentOutOfRangeException or)
            {
                Console.WriteLine(or.Message);
            }
            Console.WriteLine("Enter number such that: {0} < number < {1}", number, end);
            try
            {
                start = int.Parse(number);
            }
            catch (FormatException)
            {              
            } 
        }
    }
    static void Main()
    {
        int start = 1;
        int end = 100;

        ReadNumber(start, end);
    }
}

