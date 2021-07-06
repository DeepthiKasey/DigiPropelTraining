using System;

namespace UsingStringVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string Myname = "                        I'm Deepthi";

            string trimmedMyname = Myname.TrimStart();

            Console.WriteLine($"{ trimmedMyname }");


            string EmployeeId = "EmployeeID DPE10193";

          //  Console.ReadLine();




             string greeting = "                 Hiiiiiiii                  ";
              string trimmedGreeting = greeting.TrimStart();
               Console.WriteLine($"{trimmedGreeting}");
            


               Console.WriteLine("Hello"+ "  " + Myname + "  " + EmployeeId);
                  Console.WriteLine(EmployeeId);
                 Console.WriteLine("Hello" + Myname);
               Console.WriteLine($"Hello { Myname}");

              




             string sayHello = "Hello World!";
            
               Console.WriteLine(sayHello);
               sayHello = sayHello.Replace("Hello", "Greetings");
               Console.WriteLine(sayHello);
               Console.WriteLine(sayHello.ToUpper());
               Console.WriteLine(sayHello.ToLower());
           


          
            string sentence = "I'm blessed, Thank you God";
              Console.WriteLine("I'm blessed, Thank you God");
              Console.WriteLine(sentence.Contains("blessed"));
             Console.WriteLine(sentence.Contains("Grateful"));
           

           
            
            string sentence1 = "I'm blessed, Thank you God";
            Console.WriteLine(sentence1.StartsWith("I'm"));
            Console.WriteLine(sentence1.StartsWith("goodbye"));

            Console.WriteLine(sentence1.EndsWith("God"));
            Console.WriteLine(sentence1.EndsWith("goodbye"));

             
        }
    }
}
