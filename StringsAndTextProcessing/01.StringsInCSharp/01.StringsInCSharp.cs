//Problem 1. Strings in C#.

//Describe the strings in C#.
//What is typical for the string data type?
//Describe the most important methods of the String class.

using System;

class StringsInCSharp
{
    static string DescribeString() 
    {
        string text = @"A string is an object of type String whose value is text. 
Internally, the text is stored as a sequential read-only collection of Char objects. 
There is no null-terminating character at the end of a C# string;
therefore a C# string can contain any number of embedded null characters ('\0'). 
The Length property of a string represents the number of Char objects it contains, not the number of Unicode characters.
To access the individual Unicode code points in a string, use the StringInfo object.";
        return text;
    }
    static string TypicalForStingType() 
    {
        string text = @"If you have a variable that will always contain a string and never a numeric value, you can declare it to be of type String.
Because fixed-length strings are padded with trailing spaces, you may find the Trim and RTrim functions, which remove the spaces, useful when working with them.
Fixed-length strings in standard modules can be declared as Public or Private. In forms and class modules, fixed-length strings must be declared Private.";
        return text;
    }
    static string Methods()
    {
        string text = @"Clone()	Make clone of string.
CompareTo()	Compare two strings and returns integer value as output. It returns 0 for true and 1 for false.
Contains()	The C# Contains method checks whether specified character or string is exists or not in the string value.
EndsWith()	This EndsWith Method checks whether specified character is the last character of string or not.
Equals()	The Equals Method in C# compares two string and returns Boolean value as output.
GetHashCode()	This method returns HashValue of specified string.
GetType()	It returns the System.Type of current instance.
GetTypeCode()	It returns the Stystem.TypeCode for class System.String.
IndexOf()	Returns the index position of first occurrence of specified character.
ToLower()	Converts String into lower case based on rules of the current culture.
ToUpper()	Converts String into Upper case based on rules of the current culture.
Insert()	Insert the string or character in the string at the specified position.
IsNormalized()	This method checks whether this string is in Unicode normalization form C.
LastIndexOf()	Returns the index position of last occurrence of specified character.
Length()	It is a string property that returns length of string.
Remove()	This method deletes all the characters from beginning to specified index position.
Replace()	This method replaces the character.
Split()	This method splits the string based on specified value.
StartsWith()	It checks whether the first character of string is same as specified character.
Substring()	This method returns substring.
ToCharArray()	Converts string into char array.
Trim()	It removes extra whitespaces from beginning and ending of string.";
        return text;
    }
    static void Main()
    {
        string describe = DescribeString();
        string data = TypicalForStingType();
        string methodDescription = Methods();
        Console.WriteLine("Describe the strings in C#.\n{0}\n", describe);
        Console.WriteLine("What is typical for the string data type? \n{0}\n",data);
        Console.WriteLine("Describe the most important methods of the String class.\n{0}\n", methodDescription);
    }
}

