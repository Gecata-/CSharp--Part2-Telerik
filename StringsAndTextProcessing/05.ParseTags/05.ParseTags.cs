//Problem 5. Parse tags

//You are given a text. Write a program that changes the text in all
//regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. 
//We don't have <upcase>anything</upcase> else.

//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
using System;
using System.Text;

class ParseTags
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. \nWe don't have <upcase>anything</upcase> else.";
        string start = "<upcase>";
        string end = "</upcase>";
         StringBuilder result = new StringBuilder();
         
         for (int i = 0; i < text.Length; i++)
         {
             if (text[i] == '<')
             {
                 i += start.Length;

                 while (text[i] != '<' && text[i + 1] != '/')
                 {
                     result.Append(text[i].ToString().ToUpper());
                     i++;
                 }
                 if (text[i] == '<'&& text[i+1]=='/')
                 {
                    i += end.Length-1;
                 }           
             }
             else
             {
                 result.Append(text[i]);
             }
         }         
         Console.WriteLine(result);
    }
}

