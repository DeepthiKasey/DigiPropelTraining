using System;

namespace July05_8
{
    class July05_8
    {
        static void Main(string[] args)
        {

            //int min = 0;
            //int max = 1000;
            
            
            Random random = new Random();
            int number = random.Next(1000);

            //int number = random.Next(min,max);// it gives random value in between min n max values

            Console.WriteLine(number);
            Console.ReadKey();

          
        }
    }
}


// It generates one random number below 1000