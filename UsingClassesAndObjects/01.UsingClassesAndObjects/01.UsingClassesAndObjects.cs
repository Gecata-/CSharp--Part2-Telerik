//Problem 1. Leap year

//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.
using System;

class UsingClassesAndObjects
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());
       bool isLeapYear =  DateTime.IsLeapYear(year);
       Console.WriteLine(isLeapYear);

    }
}

