//Problem 4. Hexadecimal to decimal

//Write a program to convert hexadecimal numbers to their decimal representation.
using System;
using System.Collections.Generic;



class HexadecimalToDecimal
{
    static void Main()
    {
        Console.WriteLine("Please enter hexadecimalnumber to convert it in decimal representation" );
        string hex = Console.ReadLine();
        int number = 0;
        List<string> hexDigits = new List<string>(hex.Length);
        foreach (char digit in hex)
        {           
            hexDigits.Add(digit.ToString());
        }
        hexDigits.Reverse();
        for (int i = 0; i < hexDigits.Count; i++)
        {
            if (hexDigits[i] == "A" || hexDigits[i] == "B" || hexDigits[i] == "C" ||
                hexDigits[i] == "D" || hexDigits[i] == "E" || hexDigits[i] == "F")
            {                                          
                switch (hexDigits[i])
                {
                case "A": hexDigits[i]= "10"; break;
                case "B": hexDigits[i]="11"; break;
                case "C": hexDigits[i]="12"; break;
                case "D": hexDigits[i]="13"; break;
                case "E": hexDigits[i]="14"; break;
                case "F": hexDigits[i]="15"; break;
                }
            }
            number += Convert.ToInt32(hexDigits[i]) * (int)Math.Pow(16, i);
            
        }
        Console.WriteLine("The decimal number is {0}. ",number);
        
    }
}

