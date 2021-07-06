using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace June30_4
{
    class June30_4
    {
        public static void Main(string[] args)
        {
            //Write a program in C# Sharp to find the length of a string without using library function. 

            string str; 
            int length = 0;
            Console.Write("write a sentence: ");
            str = Console.ReadLine();

            foreach (char characters in str)
            {
                length = length + 1 ;

            }

            Console.Write("Length of the string is : {0}\n", length);
        }
    }
}

/*
 * write a sentence: hi hw r u?
 * output
 * lentght of the string is : 
 * 10
 */ 