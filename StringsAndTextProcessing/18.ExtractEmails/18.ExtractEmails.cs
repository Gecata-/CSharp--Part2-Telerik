//Problem 18. Extract e-mails

//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
using System;
using System.Text;

class ExtractEmails
{
    static void Main()
    {
        string text = "Hello my name is Spas and my e-mail is Spas@spasov.bg. \nMy friend`s e-mail is SpasFriend@abv.bg.";
  
        Console.WriteLine(text);
        var email = new StringBuilder();
        string[] words = text.Split(' ');
        char dot = '.';
        string noDot = "";
        foreach (var word in words)
        {
            if (word.Contains("@"))
            {                
                if (word[word.Length-1] == dot)
                {
                    noDot =  word.Remove(word.Length -1);
                    email.Append(noDot);
                    email.Append('\n');
                }
                else
                {
                    email.Append(word);
                    email.Append('\n');
                }
            }
        }
        Console.WriteLine(email);
    }
}

