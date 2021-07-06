using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June30_2
{
    class June30_2
    {
        //Write a program to accepst two names and sort them in alphabetical order

        public static void Main(string[] args)
        {
           
            string firstname, secondname;
            List<string> name = new List<string>();
            Console.WriteLine("Enter FirstName :\n");
            firstname = Console.ReadLine();
            Console.WriteLine("Enter SecondName:\n");
            secondname = Console.ReadLine();
            name.Add(firstname);
            name.Add(secondname);
            name.Sort();
            
            Console.WriteLine("Entered names in sorted order: ");
            foreach (string srt in name)
           
            {
                Console.WriteLine(srt);

            }

            
        }
    }
}
/*  Raja
 *  Deepthi
 *  Entered names in sorted order :
 *  Deepthi 
 *  raja
 */ 