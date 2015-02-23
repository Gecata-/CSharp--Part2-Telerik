//Problem 8. Extract sentences

//Write a program that extracts from a given text all sentences containing given word.
//Example:

//The word is: in

//The text is: We are living in a yellow submarine. We don't have anything else.
//Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

//Consider that the sentences are separated by . and the words – by non-letter symbols.

using System;



class ExtractSentences
{
    static void Main()
    {
        string text = Text();
        int index = 0;
        int secuenceIndex = 0;

       string[] sentenceBySentence = text.Split('.');

       foreach (var sentence in sentenceBySentence)
       {
           if (sentence.Contains(" in "))
           {
               Console.Write("{0}.",sentence);
           }
       }
       Console.WriteLine();
    }

    static string Text()
    {
        string text = @"We are living in a yellow submarine. We don't have anything else.\nInside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        return text;
    }
}

