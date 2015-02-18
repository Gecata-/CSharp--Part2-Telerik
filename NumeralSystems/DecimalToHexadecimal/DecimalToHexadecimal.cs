//Problem 3. Decimal to hexadecimal

//Write a program to convert decimal numbers to their hexadecimal representation.
using System;
using System.Collections.Generic;

namespace DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main()
        {
            Console.WriteLine("Enter decimal number to see it in hexadecimal representation");
            int decimalNumber = int.Parse(Console.ReadLine());
            int digit = 0;
            string hexDigit = "a";
            List<string> hex = new List<string>();
            int length = decimalNumber.ToString().Length;
            for (int i = 0; i < length - 1; i++)
            {
                digit = decimalNumber % 16;
                decimalNumber /= 16;
                if (digit >= 10 && digit <= 15)
                {
                    switch (digit)
                    {
                        case 10: hexDigit = "A";
                            break;
                        case 11: hexDigit = "B";
                            break;
                        case 12: hexDigit = "C";
                            break;
                        case 13: hexDigit = "D";
                            break;
                        case 14: hexDigit = "E";
                            break;
                        case 15: hexDigit = "F";
                            break;

                    }
                    hex.Add(hexDigit);
                }
                else
                {
                    hex.Add(digit.ToString());
                }
            }
            hex.Reverse();
            for (int i = 0; i < hex.Count; i++)
            {
                Console.Write(hex[i]);
            }
            Console.WriteLine();
        }
    }
}
