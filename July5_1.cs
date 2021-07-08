using System;

namespace July5_1
{
    class July5_1
    {
        static void Main(string[] args)
        {
            //program that requests three names of people from the user and stores them in an array of objects
            //of type Person. 


            int i, ele = 3;
            Person[] person = new Person[3];

            Console.WriteLine("Enter 3 names : \n ", ele);

            for (i = 0; i < ele; i++)
            {
                person[i] = new Person()
                {
                    name = Console.ReadLine()

                };
            }

            for (i = 0; i < ele; i++)

            {
                Console.WriteLine(person[i].ToString());
            }
        }
            public class Person
            {
            public string name { get; set; }


            // method overriding
            public override string ToString()
            {
                // return base.ToString();
                return "Hello my name is:" + name;

            }
        }
    }
}




/* Enter 3 names:
 * 
 * Advika
 * Ivana
 * Samaira
 * 
 * Hello my name is : Advika
 * Hello my name is : Ivana
 * Hello my name is : Samaira
 */ 