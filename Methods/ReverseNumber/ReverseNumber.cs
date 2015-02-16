//Problem 7. Reverse number

//Write a method that reverses the digits of given decimal number.
//Example:

//input	    output
//256	    652
using System;

class ReverseNumber
{
    static void Main()
    {
        decimal testNumber = 256m;
        Console.WriteLine(testNumber);
        decimal  reversed = ReverseDecimal(testNumber);
        Console.WriteLine(reversed);
    }

     static  decimal ReverseDecimal(decimal number)
    {
      
         char[] arr = number.ToString().ToCharArray();
         Array.Reverse(arr);
         string reversedNumbers = new string(arr);
         decimal reversed = decimal.Parse(reversedNumbers);
         return reversed;
    }
}
