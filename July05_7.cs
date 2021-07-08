using System;

namespace July05_7
{
    class July05_7
    {
        static void Main()
        {
            // Program to compare two dates

            Console.WriteLine("Enter date in format (yyyy,mm,dd)");
            DateTime date1 = new DateTime();
            date1 = Convert.ToDateTime(Console.ReadLine());
           
            Console.WriteLine("Enter date in format (yyyy,mm,dd)");
            DateTime date2 = new DateTime();
            date2 = Convert.ToDateTime(Console.ReadLine());
            
            Console.WriteLine("Date 1 : {0}", date1);
            Console.WriteLine("Date 2 : {0}", date2);

            //Comparing dates by condition
            if (date1 < date2)

                Console.WriteLine("{0} comes before {1}", date1, date2);
            else
                Console.WriteLine("{1} comes before {0}", date1, date2);

            Console.ReadKey();
        }
    }
}


/*
 * Enter date in format (yyyy,mm,dd)
 * 2018,09,08
 * Enter date in format (yyyy,mm,dd)
 * 2017,09,08
 * Date 1:   08-09-2018 00:00:00
 * Date 2:   08-09-2017 00:00:00
 * 08-09-2017 00:00:00 comes before 08-09-2018 00:00:00
 */ 