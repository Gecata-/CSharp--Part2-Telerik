//Problem 6. binary to hexadecimal

//Write a program to convert binary numbers to hexadecimal numbers (directly).
using System;
using System.Collections.Generic;
using System.Numerics;

    class BinaryToHexadecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter binary number to convert it in hexadecimal numbers:");
            string bin = Console.ReadLine();
            ConvertToHex(bin);
        }

        private static void ConvertToHex(string bin)
        {
            BigInteger number = BigInteger.Parse(bin);
            BigInteger fourDigit = 0;
            List<char> binNumber = new List<char>();
            for (int i = 0; i <= bin.Length / 4; i++)
            {
                fourDigit = number % 10000;
                number /= 10000;

                switch ((long)fourDigit)
                {
                    case 1010: binNumber.Add('A'); break;
                    case 1011: binNumber.Add('B'); break;
                    case 1100: binNumber.Add('C'); break;
                    case 1101: binNumber.Add('D'); break;
                    case 1110: binNumber.Add('E'); break;
                    case 1111: binNumber.Add('F'); break;
                    case 0000: binNumber.Add('0'); break;
                    case 0001: binNumber.Add('1'); break;
                    case 0010: binNumber.Add('2'); break;
                    case 0011: binNumber.Add('3'); break;
                    case 0100: binNumber.Add('4'); break;
                    case 0101: binNumber.Add('5'); break;
                    case 0110: binNumber.Add('6'); break;
                    case 0111: binNumber.Add('7'); break;
                    case 1000: binNumber.Add('8'); break;
                    case 1001: binNumber.Add('9'); break;
                }

            }
            binNumber.Reverse();
            for (int i = 0; i < binNumber.Count; i++)
            {
                Console.Write(binNumber[i]);
            }
            Console.WriteLine();
        }
    }

