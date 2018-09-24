using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lab1Part2
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime input; //placeholder for user input
            DateTime date1; //input #1
            DateTime date2; //input #2
            Boolean retry = true;

            while (retry)
            {
                Console.Clear();
                DisplayDirections();
                Console.WriteLine("First date (mm/dd/yyy):  ");
                if (DateTime.TryParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out input))
                {
                    date1 = input;
                }
                else
                {
                    DisplayInvalid();
                    retry = Retry();
                    continue;
                }
                Console.WriteLine("Second date (mm/dd/yyy):  ");
                if (DateTime.TryParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out input))
                {
                    date2 = input;
                }
                else
                {
                    DisplayInvalid();
                    retry = Retry();
                    continue;
                }
                DisplayDateDiff(date1, date2);
                DisplayTimeDiff(date1, date2);
                retry = Retry();
            }
        } //**********end main method**********
        static void DisplayTimeDiff(DateTime date1, DateTime date2)
        {
            //difference in days, hours, and minutes
            DateTime start = date1;
            DateTime end = date2;
            TimeSpan duration = end - start;

            Console.WriteLine(Environment.NewLine + "The difference in days is " + duration.TotalDays);
            Console.WriteLine(Environment.NewLine + "The difference in hours is " + duration.TotalHours);
            Console.WriteLine(Environment.NewLine + "The difference in minutes is " + duration.TotalMinutes);
        }
        static Boolean Retry()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Press the SPACEBAR to enter two new dates.");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                return true;
            }
            return false;
        }
        static void DisplayInvalid()
        {
            Console.WriteLine("ERROR - Invalid Input");
        }
        static void DisplayDirections()
        {
            Console.WriteLine("To find the difference in time, please provide two dates.");
            Console.WriteLine(Environment.NewLine);
        }
        static void DisplayDateDiff(DateTime date1, DateTime date2)
        {
            //get date integers
            int year1 = date1.Year;
            int year2 = date2.Year;
            int month1 = date1.Month;
            int month2 = date2.Month;
            int day1 = date1.Day;
            int day2 = date2.Day;

            //days in month (except February)
            int[] thirty = new int[4];
            thirty[0] = 4;
            thirty[1] = 6;
            thirty[2] = 9;
            thirty[3] = 11;
            int[] thirty1 = new int[7];
            thirty1[0] = 1;
            thirty1[1] = 3;
            thirty1[2] = 5;
            thirty1[3] = 7;
            thirty1[4] = 8;
            thirty1[5] = 10;
            thirty1[6] = 12;

            //remove possibility of negative
            if (year1 < year2 || ((year1 == year2) && (month1 < month2)) || ((year1 == year2) && (month1 == month2) && (day1 < day2)))
            {
                SwapYear(ref year1, ref year2);
                SwapMonth(ref month1, ref month2);
                SwapDay(ref day1, ref day2);
            }
            if (month1 < month2)
            {
                month1 = month1 + 12;
                year1 = year1 - 1;
            }
            if (day1 < day2)
            {
                if (thirty.Contains(month1))
                {
                    day1 = day1 + 30;
                    month1 = month1 - 1;
                    if (month1 < 0)
                    {
                        month1 = month1 + 12;
                        year1 = year1 - 1;
                    }
                }
                if (thirty1.Contains(month1))
                {
                    day1 = day1 + 31;
                    month1 = month1 - 1;
                    if (month1 < 0)
                    {
                        month1 = month1 + 12;
                        year1 = year1 - 1;
                    }
                }
                if (month1 == 2)
                {
                    if (month1 % 4 == 0)
                    {
                        day1 = day1 + 29;
                        month1 = month1 - 1;
                        if (month1 < 0)
                        {
                            month1 = month1 + 12;
                            year1 = year1 - 1;
                        }
                    }
                    else
                    {
                        day1 = day1 + 28;
                        month1 = month1 - 1;
                        if (month1 < 0)
                        {
                            month1 = month1 + 12;
                            year1 = year1 - 1;
                        }
                    }
                }
            }
            Console.WriteLine(Environment.NewLine + "The difference between the two dates is {0} years, {1} months, and {2} days", (year1 - year2), (month1 - month2), (day1 - day2));
        }
        //swap input dates to make sure difference is positive...
        static void SwapYear(ref int year1, ref int year2)
        {
            year1 ^= year2;
            year2 ^= year1;
            year1 ^= year2;
        }
        static void SwapMonth(ref int month1, ref int month2)
        {
            month1 ^= month2;
            month2 ^= month1;
            month1 ^= month2;
        }
        static void SwapDay(ref int day1, ref int day2)
        {
            day1 ^= day2;
            day2 ^= day1;
            day1 ^= day2;
        }
    }
}