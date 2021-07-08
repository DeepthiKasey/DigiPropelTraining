using System;

namespace July05_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //   program to check if the entered year is a leap year or not

            Console.WriteLine("Please Enter any Year");

            int year;

            year = Convert.ToInt32(Console.ReadLine());

            if (year % 400 == 0) { Console.WriteLine("{0} is a leap year", year); }

            else if (year % 100 == 0) { Console.WriteLine("{0} is not a leap year", year); }

            else if (year % 4 == 0) { Console.WriteLine("{0} is a leap year", year); }
            
            else { Console.WriteLine("Year {0} is not a leap year", year); }

            }
        }
    }

/*ex1: Please Enter any year
 * 2929
 * Year 2929 is not a leap year
 * 
 * ex2 : Please Enter any year
 *  1996
 * year 1996 is a leap year
 */ 
