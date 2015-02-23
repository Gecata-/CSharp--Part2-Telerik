//Problem 11. Format number

//Write a program that reads a number and prints it as a decimal number,
//hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.
using System;
using System.Globalization;

class FormatNumber
{
    static void Main()
    {
        //Uncomment to test.
        //int number = int.Parse(Console.ReadLine());
        int number = 10;
        CultureInfo culture = new CultureInfo("bg-BG");
        Console.WriteLine("Decimal: {0:D}\nHexadecimal: {0:X}\nPercentage: {0:P}\nScientific: {0:E0}",number);
    }
}

