//Problem 4. Sub-string in text

//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:

//The target sub-string is "in"

//The text is as follows:
//We are living in an yellow submarine. 
//We don't have anything else. inside the submarine is very tight.
//So we are drinking all the day. We will move out of it in 5 days.

//The result is: 9
using System;

class SubStringInText
{
    static string BigText()
    {
        string text = @"We are living in an yellow submarine.
We don't have anything else. inside the submarine is very tight.
So we are drinking all the day. We will move out of it in 5 days.";
        return text;
    }

    static void FindSubStringInText(string text, string substring) 
    {
        int maxIndex = -1;
        int count = 0;
        for (int i = 0; i < text.Length; i++)
        {
            int index = text.IndexOf(substring, i);
            if (index < 0)
            {
                break;
            }
            if (index > maxIndex)
            {
                maxIndex = index;
                count++;
            }
        }
        Console.WriteLine("The result is: {0}", count);
    }

    static void Main()
    {
        string text = BigText();
        FindSubStringInText(text, "in");      
    }
}

