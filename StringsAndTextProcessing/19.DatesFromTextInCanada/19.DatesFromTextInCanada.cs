//Problem 19. Dates from text in Canada

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.
using System;
using System.Collections.Generic;
using System.Globalization;

    class DatesFromTextInCanada
    {
        static void Main()
        {
            string text = "Today is 24.02.2015 its a wonderful day. Tomorrow will be 25.02.2015 hope the day will be agains so sunny.";
            var dates = new List<DateTime>();
            DateTime parseDate = new DateTime();
            var culture = new CultureInfo("sa-IN");
            string[] words = text.Split(' ');
            foreach (var word in words)
            {
                if (DateTime.TryParseExact(word,"dd.MM.yyyy",CultureInfo.CurrentCulture,DateTimeStyles.None, out parseDate))
                {
                    dates.Add(parseDate);
                }
            }
            for (int i = 0; i < dates.Count; i++)
            {
                Console.WriteLine("{0}",dates[i].ToString(culture));
            }
        }
    }

