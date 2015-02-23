//Problem 3. Correct brackets

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
using System;
using System.Collections.Generic;

class CorrectBrackets
{
    static void Main()
    {
        string expression = ")(a+b))";
       // string expression = "((a+b)/5-d)";

        CheckSolution(expression);

    }

    private static void CheckSolution(string expression)
    {
        int firstBracket = CheckBracket(expression, '(');
        int secondBracket = CheckBracket(expression, ')');
        if (firstBracket==secondBracket)
        {
            Console.WriteLine("Correct expression.");
        }
        else
        {
            Console.WriteLine("Incorrect expression.");
        }
    }

    static int CheckBracket(string expression, char bracket)
    {
        int currentIndex = -1;
        int count = 0;
        for (int i = 0; i < expression.Length; i++)
			{
                int index = expression.IndexOf(bracket, i);
                
                if (index<0)
                {
                    break;
                }
                if (index > currentIndex)
                {
                    currentIndex = index;
                    count++;
                }
			}
        return count;
    }

}
