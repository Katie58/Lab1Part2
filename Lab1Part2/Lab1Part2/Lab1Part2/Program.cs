using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Part2
{
    class Program
    {
        //start main method...
        static void Main(string[] args)
        {

        //create label to restart program...
        Start:

            //create arrays to differentiate how many days are in the month (february not included)...
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

            int error; //placeholder to check for valid input

            //request user input, check if input is valid, declare and assign valid values to variables, restart if invalid...
            Console.WriteLine("Please enter two dates");
            Console.WriteLine("First month number (example: enter 1 for January):  ");
            if (!int.TryParse(Console.ReadLine(), out error)) //checks for valid input
            {
                Retry();
                while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar))
                {
                    Console.Clear();
                    goto Start;
                }
            }
            int month1 = Convert.ToInt32(Console.ReadLine());
            if (month1 < 1 || month1 > 12)
            {
                Retry();
                while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar))
                {
                    Console.Clear();
                    goto Start;
                }
            }
            Console.WriteLine("First day:  ");
            if (!int.TryParse(Console.ReadLine(), out error))
            {
                Retry();
                while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar))
                {
                    Console.Clear();
                    goto Start;
                }
            }
            int day1 = Convert.ToInt32(Console.ReadLine());
            if (Array.Exists(thirty, element => element == month1))
            {
                if (day1 < 1 || day1 > 30)
                {
                    Retry();
                    while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar))
                    {
                        Console.Clear();
                        goto Start;
                    }
                }
            }
            if (Array.Exists(thirty1, element => element == month1))
            {
                if (day1 < 1 || day1 > 31)
                {
                    Retry();
                    while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar))
                    {
                        Console.Clear();
                        goto Start;
                    }
                }
            }
            if (month1 == 2)
            {
                if (day1 < 1 || day1 > 29)
                {
                    Retry();
                    while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar))
                    {
                        Console.Clear();
                        goto Start;
                    }
                }
            }
            Console.WriteLine("First year:  ");
            if (!int.TryParse(Console.ReadLine(), out error))
            {
                Retry();
                while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar))
                {
                    Console.Clear();
                    goto Start;
                }
            }
            int year1 = Convert.ToInt32(Console.ReadLine());
            if (day1 == 29)
            {
                if (year1 % 4 != 0)
                {
                    Console.WriteLine("you entered 29 days, however, the year you entered is not a leap year");
                    Retry();
                    while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar))
                    {
                        Console.Clear();
                        goto Start;
                    }
                }
            }
            Console.WriteLine("Second month:  ");
            if (!int.TryParse(Console.ReadLine(), out error))
            {
                Retry();
                while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar))
                {
                    Console.Clear();
                    goto Start;
                }
            }
            int month2 = Convert.ToInt32(Console.ReadLine());
            if (month2 < 1 || month2 > 12)
            {
                Retry();
                while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar))
                {
                    Console.Clear();
                    goto Start;
                }
            }
            Console.WriteLine("Second day:  ");
            if (!int.TryParse(Console.ReadLine(), out error))
            {
                Retry();
                while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar))
                {
                    Console.Clear();
                    goto Start;
                }
            }
            int day2 = Convert.ToInt32(Console.ReadLine());
            if (Array.Exists(thirty, element => element == month2))
            {
                if (day2 < 1 || day2 > 30)
                {
                    Retry();
                    while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar))
                    {
                        Console.Clear();
                        goto Start;
                    }
                }
            }
            if (Array.Exists(thirty1, element => element == month2))
            {
                if (day2 < 1 || day2 > 31)
                {
                    Retry();
                    while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar))
                    {
                        Console.Clear();
                        goto Start;
                    }
                }
            }
            if (month2 == 2)
            {
                if (day2 < 1 || day2 > 29)
                {
                    Retry();
                    while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar))
                    {
                        Console.Clear();
                        goto Start;
                    }
                }
            }
            Console.WriteLine("Second year:  ");
            if (!int.TryParse(Console.ReadLine(), out error))
            {
                Retry();
                while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar))
                {
                    Console.Clear();
                    goto Start;
                }
            }
            int year2 = Convert.ToInt32(Console.ReadLine());
            if (day2 == 29)
            {
                if (year2 % 4 != 0)
                {
                    Console.WriteLine("you entered 29 days, however, the year you entered is not a leap year");
                    Retry();
                    while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar))
                    {
                        Console.Clear();
                        goto Start;
                    }
                }
            }

            //combine user input and display in console...
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("First date is {0}/{1}/{2}", month1, day1, year1);
            Console.WriteLine("Second date is {0}/{1}/{2}", month2, day2, year2);

            //clone variables to keep originals unchanged...
            int day1t = day1;
            int month1t = month1;
            int year1t = year1;
            int day2t = day2;
            int month2t = month2;
            int year2t = year2;

            //calculate to make sure difference is positive and that numbers are carried over correctly...
            if (year1 < year2 || ((year1 == year2) && (month1 < month2)) || ((year1 == year2) && (month1 == month2) && (day1 < day2)))
            {
                SwapYear(ref year1t, ref year2t);
                SwapMonth(ref month1t, ref month2t);
                SwapDay(ref day1t, ref day2t);
            }

            if (month1t < month2t)
            {
                month1t = month1t + 12;
                year1t = year1t - 1;
            }

            if (day1t < day2t)
            {
                if (thirty.Contains(month1))
                {
                    day1t = day1t + 30;
                    month1t = month1t - 1;
                    if (month1t < 0)
                    {
                        month1t = month1 + 12;
                        year1t = year1 - 1;
                    }
                }
                if (thirty1.Contains(month1))
                {
                    day1t = day1t + 31;
                    month1t = month1t - 1;
                    if (month1t < 0)
                    {
                        month1t = month1t + 12;
                        year1t = year1t - 1;
                    }
                }
                if (month1 == 2)
                {
                    if (month1 % 4 == 0)
                    {
                        day1t = day1t + 29;
                        month1t = month1t - 1;
                        if (month1t < 0)
                        {
                            month1t = month1t + 12;
                            year1t = year1t - 1;
                        }
                    }
                    else
                    {
                        day1t = day1t + 28;
                        month1t = month1t - 1;
                        if (month1t < 0)
                        {
                            month1t = month1t + 12;
                            year1t = year1t - 1;
                        }
                    }

                }
            }

            //output time difference...
            int yeardiff = year1t - year2t;
            int monthdiff = month1t - month2t;
            int daydiff = day1t - day2t;

            //**********Library code...
            if (year1 <= 0 || year1 > 9999 || year2 <= 0 || year2 > 9999)
            {
                Console.WriteLine("LibraryCODE: Difference in days: ERROR");
            }
            else
            {
                DateTime start = new DateTime(year1, month1, day1);
                DateTime end = new DateTime(year2, month2, day2);
                TimeSpan difference = end - start;
            }
            //end Library code**********

            Console.WriteLine("KTCODE: Time difference is {0} years, {1} months, and {2} days", yeardiff, monthdiff, daydiff);
            Console.WriteLine(Environment.NewLine);

            //calculate time difference in days...
            int yearCurrent = year1;
            int monthCurrent = month1;
            int daysCurrent = day1;
            int totalDays1 = 0;
            int totalDays2 = 0;


            Math:
            int DICY; //total days in current year assigned from list
            int DIY = (yearCurrent * 365) - 365; //days in full years
            int yearRemain = yeardiff % 4;
            int leapYears = 0;

            if (yeardiff + monthdiff + daydiff != 0)
            {            
                //list of # of days in current year to that month (in non leap years)...
                var daysInCurrentYear = new Dictionary<int, int>
                {
                    {1, daysCurrent},
                    {2, 31 + daysCurrent},
                    {3, 59 + daysCurrent},
                    {4, 90 + daysCurrent},
                    {5, 120 + daysCurrent},
                    {6, 151 + daysCurrent},
                    {7, 181 + daysCurrent},
                    {8, 212 + daysCurrent},
                    {9, 243 + daysCurrent},
                    {10, 273 + daysCurrent},
                    {11, 304 + daysCurrent},
                    {12, 334 + daysCurrent},
                };
                if (year1 % 4 == 0) //if leap year
                {
                    if (month1 > 2) //and after february
                    {
                        leapYears = leapYears + 1; //add a day
                    }
                    if (yeardiff > 4) //if more than 1 leap years
                    {
                        leapYears = leapYears + ((yeardiff - yearRemain) / 4) + 1; //add prior leap years + current
                    }
                }
                if ((year1 + 1) % 4 == 0)
                {
                    if (yeardiff > 1)
                    {
                        if (month1 > 2)
                        {
                            leapYears = leapYears + 1;
                        }
                        if (yeardiff > 5)
                        {
                            leapYears = leapYears + ((yeardiff - yearRemain) / 4) + 1;
                        }
                    }
                }
                if ((year1 + 2) % 4 == 0)
                {
                    if (yeardiff > 2)
                    {
                        if (month1 > 2)
                        {
                            leapYears = leapYears + 1;
                        }
                        if (yeardiff > 6)
                        {
                            leapYears = leapYears + ((yeardiff - yearRemain) / 4) + 1;
                        }
                    }
                }
                if ((year1 + 3) % 4 == 0)
                {
                    if (yeardiff > 3)
                    {
                        if (month1 > 2)
                        {
                            leapYears = leapYears + 1;
                        }
                        if (yeardiff > 7)
                        {
                            leapYears = leapYears + ((yeardiff - yearRemain) / 4) + 1;
                        }
                    }
                }
                if (yearCurrent == year1 && monthCurrent == month1 && daysCurrent == day1)
                {
                    DICY = daysInCurrentYear[monthCurrent];
                    totalDays1 = DICY + DIY;

                    yearCurrent = year2;
                    monthCurrent = month2;
                    daysCurrent = day2;
                    goto Math;
                }
                else
                {
                    DICY = daysInCurrentYear[monthCurrent];
                    totalDays2 = DICY + DIY;
                }
            }
            else
            {
                Console.WriteLine("You entered the same dates");
                Retry();
                while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar))
                {
                    Console.Clear();
                    goto Start;
                }
            }
            int totalDays = (totalDays2 - totalDays1) + leapYears;

            Console.WriteLine("KTCODE: Time difference in days is {0}", Math.Abs(totalDays));
            if (year1 <= 0 || year1 > 9999 || year2 <= 0 || year2 > 9999)
            {
                Console.WriteLine("LibraryCODE: Difference in days: ERROR");
            }
            else
            {
                DateTime start = new DateTime(year1, month1, day1);
                DateTime end = new DateTime(year2, month2, day2);
                TimeSpan difference = end - start;
                Console.WriteLine("LibraryCODE: Difference in days: " + difference.Days);
            }


            //calculate time difference in hours...
            Console.WriteLine("KTCODE: Time difference in hours is {0}", Math.Abs(totalDays * 24));
            if (year1 <= 0 || year1 > 9999 || year2 <= 0 || year2 > 9999)
            {
                Console.WriteLine("LibraryCODE: Difference in days: ERROR");
            }
            else
            {
                DateTime start = new DateTime(year1, month1, day1);
                DateTime end = new DateTime(year2, month2, day2);
                TimeSpan difference = end - start;
                Console.WriteLine("LibraryCODE: Difference in hours: " + (difference.Days * 24)); //error w/ difference.Hours = 0
            }


            //calculate time difference in minutes...
            Console.WriteLine("KTCODE: Time difference in minutes is {0}", Math.Abs(totalDays * 1440));
            if (year1 <= 0 || year1 > 9999 || year2 <= 0 || year2 > 9999)
            {
                Console.WriteLine("LibraryCODE: Difference in days: ERROR");
            }
            else
            {
                DateTime start = new DateTime(year1, month1, day1);
                DateTime end = new DateTime(year2, month2, day2);
                TimeSpan difference = end - start;
                Console.WriteLine("LibraryCODE: Difference in minutes: " + (difference.Days * 1440)); //error w/ difference.Minutes = 0
            }


            //restart program...
            Restart();

            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar))
            {
                Console.Clear();
                goto Start;
            }

            Console.ReadKey();

        }
        //***end main method***    

        //swap input dates to make sure difference is positive...
        static void SwapYear(ref int year1t, ref int year2t)
        {
            year1t ^= year2t;
            year2t ^= year1t;
            year1t ^= year2t;
        }
        static void SwapMonth(ref int month1t, ref int month2t)
        {
            month1t ^= month2t;
            month2t ^= month1t;
            month1t ^= month2t;
        }
        static void SwapDay(ref int day1t, ref int day2t)
        {
            day1t ^= day2t;
            day2t ^= day1t;
            day1t ^= day2t;
        }
        //invalid data entry restart...
        static void Retry()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("invalid input...");
            Console.WriteLine("Press SPACEBAR to enter new dates");
            Console.ReadKey();
        }
        //end program restart...
        static void Restart()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Press SPACEBAR to enter new dates");
            Console.ReadKey();
        }
    }
}
