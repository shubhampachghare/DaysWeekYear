using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthNumber
{
    class Year
    {
        static int DAYS_IN_WEEK = 7;
        static void find(int Number_of_Days)
        {
            int year, week, days;
            year = Number_of_Days / 365;
            week = (Number_of_Days % 365) / DAYS_IN_WEEK;
            days = (Number_of_Days % 365) % DAYS_IN_WEEK;
            Console.WriteLine("Years = " + year);
            Console.WriteLine("Weeks = " + week);
            Console.WriteLine("Days = " + days);
        }

        public static void Main()
        {
            int Number_of_Days = 367;
            find(Number_of_Days);
        }

    }
}