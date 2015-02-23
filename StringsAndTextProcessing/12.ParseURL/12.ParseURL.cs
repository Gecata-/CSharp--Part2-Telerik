//Problem 12. Parse URL

//Write a program that parses an URL address given in the format: 
//[protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
//Example:

//URL	Information
//http://telerikacademy.com/Courses/Courses/Details/212	
//
//[protocol] = http 
//[server] = telerikacademy.com 
//[resource] = /Courses/Courses/Details/212
using System;

class ParseURL
{
    static void Main()
    {
        string input = "http://telerikacademy.com/Courses/Courses/Details/212";
        //string input = "https://www.youtube.com/watch?v=c_9OGUPDamQ";

        int serverLength = (input.IndexOf('/',(input.LastIndexOf("//")+1)+1) - (input.LastIndexOf("//")+1));

        Console.WriteLine("[protocol] = {0}", input.Substring(0,input.IndexOf(':')));
        Console.WriteLine("[server] = {0}", input.Substring(((input.LastIndexOf("//")+1)+1), serverLength-1));
        Console.WriteLine("[resource] = {0}", input.Substring((input.LastIndexOf("//")+1+serverLength)));
                                              
    }
}

