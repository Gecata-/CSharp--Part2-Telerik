//Problem 3. English digit

//Write a method that returns the last digit of given integer as an English word.
//Examples:

//input	output
//512	two
//1024	four
//12309	nine

using System;

class EnglishDigit
{
    static void Main()
    {

        Console.WriteLine("Please enter number:");
        string numbers = Console.ReadLine();
        char[] numberByNumber = numbers.ToCharArray();
        char digit = numberByNumber[numberByNumber.Length - 1];
        Console.WriteLine( DigitInWord(digit) );
    }

     static string DigitInWord(char digit)
    {
        string word = null;
        switch (digit)
        {
            case '1': word = "one";
                break;
            case '2': word = "two";
                break; 
            case '3': word = "three";
                break;
            case '4': word = "four";
                break;
            case '5': word = "five";
                break; 
            case '6': word = "six";
                break;
            case '7': word = "seven";
                break; 
            case '8': word = "eight";
                break; 
            case '9': word = "nine";
                break; 
            case '0': word = "zero";
                break;
        }
        return word;
    }
}

