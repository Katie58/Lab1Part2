using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Part1
{
    class Program
    {
        static void Main(string[] args)
        {

            int input; //placeholder for user input
            int nmbr1 = 0; //input #1
            int nmbr2 = 0; //input #2

            while (true)
            {
                Console.Clear();
                Directions();
                Console.WriteLine("Number 1:  ");
                if (int.TryParse(Console.ReadLine(), out input)) //check for valid input
                {
                    nmbr1 = input;
                }
                else
                {
                    Invalid();
                    Retry();
                    Console.ReadKey();
                    continue;
                }
                Console.WriteLine("Number 2:  ");
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    nmbr2 = input;
                }
                else
                {
                    Invalid();
                    Retry();
                    Console.ReadKey();
                    continue;
                }
                Calculate(nmbr1, nmbr2);
                Retry();
                Console.ReadKey();
            }
        } //**********end main method**********
        static Boolean Calculate(int nmbr1, int nmbr2)
        {
            int value1; //place value of #1
            int value2; //place value of #2

            //find place values
            value1 = nmbr1.ToString().Length;
            value2 = nmbr2.ToString().Length;

            //display place values
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Place value of first number: {0}", value1);
            Console.WriteLine("Place value of second number: {0}", value2);

            //assign digits to arrays
            int[] ray1 = nmbr1.ToString().Select(t => int.Parse(t.ToString())).ToArray();
            int[] ray2 = nmbr2.ToString().Select(p => int.Parse(p.ToString())).ToArray();
            int[] sum = new int[value1];

            if (value1 == value2) //compare place values
            {
                Console.WriteLine("Place Values are Equal");
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Corresponding digits added together: ");
                for (int i = 0; i < value1; i++)
                {
                    sum[i] = ray1[i] + ray2[i]; //add digits into new array
                    Console.Write(sum[i] + " "); //show new digits
                }
                //compare digits 
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Are the sums of the corresponding digits the same?");
                Console.Write(Array.TrueForAll(sum, i => i == sum[0]));
            }
            else
            {
                Console.Write("***Please provide numbers with equal place values.***");
            }
            return true;
        }
        static Boolean Retry()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Press the SPACEBAR to try again.");
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar))
            {
                return false;
            }
            return false;
        }
        static void Directions()
        {
            Console.WriteLine("                  Numbers must have equal place values.");
            Console.WriteLine("        (example: xxx & yyy both have 3 digits and are equal in length)");
            Console.WriteLine("Each digit will be added to the corresponding digit, and the sums must all be equal.");
            Console.WriteLine("                    (example: for abc & xyz, ax=by=cz)");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Please provide two valid numbers...");
        }
        static void Invalid()
        {
            Console.WriteLine("ERROR - Invalid Input");
        }
    }
}