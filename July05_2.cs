using System;

namespace July05_2
{
    class July05_2
    {
        // Program constructo and destructor
        static void Main(string[] args)
        {

            int i,ele=3;

            Person[] person = new Person[3];

            Console.WriteLine("Enter 3 names : \n ", ele);
            
            for (i=0;i<ele;i++)
            {
                person[i] = new Person(Console.ReadLine());

            }

            for (i=0;i<ele;i++)
            
            {
                Console.WriteLine(person[i].ToString());
            }
        }
    }
    public class Person
    {
            public string Name { get; set; }
        public Person(string name)
        {
            Name = name;

        }
        public override string ToString()
        {
            //return base.ToString();
            return " Hello my name is:" + Name;
        }

        //destructor
        ~Person()
        {
            Name = string.Empty;

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