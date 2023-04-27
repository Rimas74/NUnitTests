using System;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Uzduotis13.Divide995By3());
            Console.WriteLine(Uzduotis13.WhatIsWeekDayToday());
            Console.WriteLine(Uzduotis13.WhatTimeIsNow());
            Console.WriteLine(Uzduotis13.EvenNumbersInRange1To10());

        }
    }
    public class Uzduotis13
        {
        public static double Divide995By3()
        {
            return (double)995 % 3;
        }
        public static string WhatIsWeekDayToday()
        {
            return Convert.ToString(DateTime.Today.DayOfWeek);
        }
        public static string WhatTimeIsNow()
        {
            return (Convert.ToString(DateTime.Now.Hour));
        }
        public static int EvenNumbersInRange1To10()
        {
            int count = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static bool Is995DivisibleBy3WithoutRemainder()
        {
            return 995 % 3 == 0;
        }

        public static bool IsTodayWednesday()
        {
            return DateTime.Today.DayOfWeek == DayOfWeek.Wednesday;
        }

        public static bool IsNow13h()
        {
            return DateTime.Now.Hour == 13;
        }

        public static bool AreThere4EvenNumbersInRange1To10()
        {
            int count = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    count++;
                }
            }
            return count == 4;
        }
    }
}

