//Problem 25. Extract text from HTML

//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
//Example input:

//<html>
//  <head><title>News</title></head>
//  <body><p><a href="http://academy.telerik.com">Telerik
//    Academy</a>aims to provide free real-world practical
//    training for young people who want to turn into
//    skilful .NET software engineers.</p></body>
//</html>
//Output:

//Title: News

//Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.
using System;
using System.Text;

class ExtractTextFromHTML
{
    static void Main()
    {
        string text = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";
        var result = new StringBuilder();
        bool isText = false;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '<')
            {
                isText = false;
            }
            if (isText)
            {
                result.Append(text[i]);
            }
            if (text[i] == '>')
            {
                isText = true;
                result.Append(' ');
            }
        }
        Console.WriteLine(result);
    }
}

