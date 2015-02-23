//Problem 16. Date difference

//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//Example:

//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days
using System;
using System.Globalization;


class DateDifference
{
    static void Main()
    {
        string firstDate = "27.02.2006";
        string secondDate = "3.03.2006";
        //Uncomment for testing.
        //Console.WriteLine("Enter two dates in format d.MM.yyy to calculate days between them");
        //string firstDate = Console.ReadLine();
        //string secondDate = Console.ReadLine();

        DateTime first = DateTime.ParseExact(firstDate, "d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime second = DateTime.ParseExact(secondDate, "d.MM.yyyy", CultureInfo.InvariantCulture);

        var days = second - first;
        Console.WriteLine("{0} days", days.Days);
    }
}

