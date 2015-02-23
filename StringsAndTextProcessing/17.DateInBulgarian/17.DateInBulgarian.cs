// Problem 17. Date in Bulgarian

// Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
// and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
using System;
using System.Globalization;

class DateInBulgarian
{
    static void Main()
    {

        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        string inputDate = "23.02.2015 20:50:34";
        DateTime date = DateTime.ParseExact(inputDate, "dd.MM.yyyy HH:mm:ss", CultureInfo.DefaultThreadCurrentUICulture);
        TimeSpan plusTime = new TimeSpan(06,30,00);
        var newDate = date + plusTime;
        Console.WriteLine("{0:dd.MM.yyyy.dddd HH:mm:ss }",newDate);
    }
}

