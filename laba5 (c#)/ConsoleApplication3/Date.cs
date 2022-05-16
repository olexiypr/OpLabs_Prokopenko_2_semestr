using System;

namespace ConsoleApplication3
{
    public static class Date
    {
        public static int year{ get; private set; }
        public static int month { get; private set; }
        public static int day{ get; }

        static Date()
        {
            DateTime now = DateTime.Now;
            year = now.Year;
            month = now.Month;
            day = now.Day;
        }
        
        public static void NextMonth()
        {
            month++;
            if (month==12)
            {
                month = 0;
                year++;
            }
        }

        public static string GetDate()
        {
            return day.ToString() + "-" + month.ToString() + "-" + year.ToString();
        }
    }
}