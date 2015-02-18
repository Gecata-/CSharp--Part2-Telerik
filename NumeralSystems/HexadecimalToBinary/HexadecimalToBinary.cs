//Problem 5. Hexadecimal to binary

//Write a program to convert hexadecimal numbers to binary numbers (directly).
using System;
using System.Collections.Generic;

class HexadecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter hexadecimal number to convert it  to binary numbers (directly)");
        string hex = Console.ReadLine();
        List<string> bin = ConvertHexToBin(hex);
        for (int i = 0; i < hex.Length; i++)
        {
            Console.Write(bin[i]);
        }
        Console.WriteLine();
    }

    static List<string> ConvertHexToBin(string hex)
    {
        List<string> bin = new List<string>();

        foreach (char number in hex)
        {
            switch (number)
            {
                case 'A': bin.Add("1010"); break;
                case 'B': bin.Add("1011"); break;
                case 'C': bin.Add("1100"); break;
                case 'D': bin.Add("1101"); break;
                case 'E': bin.Add("1110"); break;
                case 'F': bin.Add("1111"); break;
                case '0': bin.Add("0000"); break;
                case '1': bin.Add("0001"); break;
                case '2': bin.Add("0010"); break;
                case '3': bin.Add("0011"); break;
                case '4': bin.Add("0100"); break;
                case '5': bin.Add("0101"); break;
                case '6': bin.Add("0110"); break;
                case '7': bin.Add("0111"); break;
                case '8': bin.Add("1000"); break;
                case '9': bin.Add("1001"); break;
            }
        }
        return bin;
    }

}

