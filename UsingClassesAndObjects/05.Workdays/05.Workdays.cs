// Problem 5. Workdays

// Write a method that calculates the number of workdays between today and given date, passed as parameter.
// Consider that workdays are all days from Monday to Friday except a 
// fixed list of public holidays specified preliminary as array.

using System;
using System.Collections.Generic;
using System.Linq;

class Workdays
{
    static List<DateTime> officialHolidays = new List<DateTime>()
        {
            new DateTime(2015,01,1),
            new DateTime(2015,03,2),
            new DateTime(2015,03,3),
            new DateTime(2015,04,10),
            new DateTime(2015,04,11),
            new DateTime(2015,04,12),
            new DateTime(2015,04,13),
            new DateTime(2015,05,6),
            new DateTime(2015,09,21),
            new DateTime(2015,09,22),
            new DateTime(2015,12,24),
            new DateTime(2015,12,25),
            new DateTime(2015,12,26),
            new DateTime(2015,12,31)
        };
    static void Main()
    {
        Console.WriteLine("Please enter end Date in format YYYY,MM,DD:");
        string endDay = Console.ReadLine();
        CountWorkDays(endDay);
    }

    private static void CountWorkDays(string endDay)
    {
        int businesDays = 0;
        var today = DateTime.Now;
        DateTime dateValue;
        bool isDay = DateTime.TryParse(endDay, out dateValue);
        if (isDay)
        {
            DateTime givenDay = DateTime.Parse(endDay);

            // string[] end = endDay.Split('/');        
            //int[] dreamday = end.Select(x => int.Parse(x))
            //                   .ToArray();
            //var givenDay = new DateTime( dreamday[0],dreamday[1], dreamday[2]);      


            while (givenDay > today)
            {
                if (!(today.DayOfWeek == DayOfWeek.Saturday || today.DayOfWeek == DayOfWeek.Sunday || officialHolidays.Contains(today)))
                {
                    businesDays++;
                }
                today = today.AddDays(1);
            }
            Console.WriteLine("From {0} \n to {1}\n there are {2} working days", DateTime.Now, givenDay, businesDays);
        }
        else
        {
            Console.WriteLine("Invalid Date Format");
        }
    }
}

