using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace June30_7
{
    class Pro7
    {
        public static void Main(string[] args)
        {

            string str1 = "i'm deepthi";
            Console.WriteLine("Original string: " + str1);
            // Calling a funtion "test"
            Console.WriteLine("After converting string to camalcase:\n" + test(str1));

            str1 = "Have a blessed day";
            Console.WriteLine("\nOriginal string: " + str1);
            Console.WriteLine("After converting the string to camalcase:\n" + test(str1));
        }

        public static string test(string str1)
        {
            string[] strArry = str1.Split(' ');
            for (int i = 0; i < strArry.Length; i++)
            {
                // convert the first character of each word of a given string to uppercase and appending substring

                strArry[i] = strArry[i].Substring(0, 1).ToUpper() + strArry[i].Substring(1);
            }

            return string.Join(" ", strArry);


        }

    }
}
/*
 * Original string: i'm deepthi
After converting the first character of each word of the said string:
I'm Deepthi
Original string: Have a blessed day
After converting the first character of each word of the said string:
Have A Blessed Day
 * 
 * 
 */
