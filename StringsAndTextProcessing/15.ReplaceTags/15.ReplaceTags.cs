﻿//  Problem 15. Replace tags

//  Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
//  Example:

//  input	
//  <p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course.
//  Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>

//  output
//  <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course.
//  Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
using System;

class ReplaceTags
{
    static void Main()
    {
        string textHTML = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course.\nAlso visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        textHTML = textHTML.Replace("<a href=\"","[URL=");
        textHTML = textHTML.Replace("</a>","[/URL]");
        Console.WriteLine(textHTML);
    }
}

