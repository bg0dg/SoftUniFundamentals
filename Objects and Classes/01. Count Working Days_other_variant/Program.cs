﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace _01._Count_Working_Days_other_variant
{
    class Program
    {
        private static object holiday;

        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            int workingDaysCounter = 0;

            List<DateTime> hollidays = new List<DateTime>();

            hollidays.Add(new DateTime(2016, 1, 1));
            hollidays.Add(new DateTime(2016, 3, 3));
            hollidays.Add(new DateTime(2016, 5, 1));
            hollidays.Add(new DateTime(2016, 5, 6));
            hollidays.Add(new DateTime(2016, 5, 24));
            hollidays.Add(new DateTime(2016, 9, 6));
            hollidays.Add(new DateTime(2016, 9, 22));
            hollidays.Add(new DateTime(2016, 11, 1));
            hollidays.Add(new DateTime(2016, 12, 24));
            hollidays.Add(new DateTime(2016, 12, 25));
            hollidays.Add(new DateTime(2016, 12, 26));

            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {

                if (!currentDate.DayOfWeek.Equals(DayOfWeek.Saturday) && !currentDate.DayOfWeek.Equals(DayOfWeek.Sunday))
                {
                    bool flag = true;

                    foreach (var holiday in hollidays)
                    {
                        if (holiday.Day == currentDate.Day && holiday.Month == currentDate.Month)
                        {
                            flag = false;
                            break;
                        }
                    }

                    if (flag)
                    {
                        workingDaysCounter++;
                    }
                }
            }

            Console.WriteLine(workingDaysCounter);
        }
    }
}
