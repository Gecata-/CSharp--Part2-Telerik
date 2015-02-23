//Problem 7. Encode/decode

//Write a program that encodes and decodes a string using given encryption key (cipher).

//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the 
//string with the first of the key, the second – with the second, etc.
//When the last key character is reached, the next is the first.
using System;
using System.Text;

class EncodeDecode
{
    static void Main()
    {
        string cipher = "abcdefghjklmnopqrstuvwxyz";

        //string test = "alphabet";
        string test = Console.ReadLine();       
        var encoded = new StringBuilder();
        var decoded = new StringBuilder();

        for (int i = 0,j=0; i < test.Length; i++,j++)
        {
            if (j >= cipher.Length) j = 0;      
                encoded.Append((char)(test[i] ^ cipher[j]));
        }
        Console.WriteLine("The encoded text is: {0} ",encoded);
        for (int i = 0,j=0; i < test.Length; i++,j++)
        {
            if (j >= cipher.Length) j = 0;
            decoded.Append((char)(encoded[i] ^ cipher[j]));
        }
        Console.WriteLine("The decoded text is: {0} ",decoded);  
    }
}

