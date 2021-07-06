using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Globalization;
using System.Text;


namespace June30_9
{
    class Program
    {
        public static void Main()
        {

            string str;
             Console.WriteLine("enter the sentence:");
             str = Console.ReadLine();
            Console.WriteLine("\nOriginal string: " + str);
            Console.WriteLine("\nReverse all the words of the said string which have even length.:\n" + test(str));

        }
        public static string test(string str)
        {
            return string.Join(" ", str.Split(' ').Select(str2 => str2.Length % 2 != 0 ? str2 :
            new string(str2.Reverse().ToArray())));
        }

    }
}
