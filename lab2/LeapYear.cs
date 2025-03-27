using System;

namespace lab2
{
    public class LeapYear
    {
        public void leapYearCheck()
        {
            Console.WriteLine("Check whether a given year is leap year or not");

            Console.Write("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"The year {year} is leap year");
            }
            else 
            {
                Console.WriteLine($"The year {year} is not leap year");
            }
        }
    }
}