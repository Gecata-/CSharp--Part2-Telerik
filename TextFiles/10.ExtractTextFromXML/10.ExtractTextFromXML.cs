//Problem 10. Extract text from XML

//Write a program that extracts from given XML file all the text without the tags.
//Example:
/*
<?xml version="1.0"?><student><name>Pesho Gogo</name><age>21</age>
<interests count="3"><interest>Games</interest><interest>C#</interest>
<interest>Java</interest></interests></student>
 */

using System;
using System.IO;

class ExtractTextFromXML
{
    static void Main()
    {
        string text;
        string textWithoutTags = "";
        bool isText = false;
        using (var streamReader = new StreamReader(@"..\..\TestXML.xml"))
        {
            text = streamReader.ReadToEnd();
        }
        foreach (char item in text)
        {
            if (item =='<')
            {
                isText = false;
            }
            else if (isText == true)
            {
                textWithoutTags = string.Concat(textWithoutTags, item);
            }
            else if (item == '>')
            {
                isText = true;
            }
        }
        Console.Write(textWithoutTags.Trim());
    }
}

