using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // First Program (multiplication of three numbers which will be entered by the user)

            Console.WriteLine("Enter first Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            int c = Convert.ToInt32(Console.ReadLine());
            int d = a * b * c;
            Console.WriteLine("Answer:" + d);




            // Second Program (output of adding, subtracting, multiplying and dividing of two numbers
            // which will be entered by the user)


            Console.WriteLine("Enter Two numbers");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            int Num3 = Num1 + Num2;
            Console.WriteLine("Addition of the given Numbers " + Num3);

            int Num4 = Num1 - Num2;
            Console.WriteLine("Subtraction of the given Numbers " + Num4);

            int Num5 = Num1 * Num2;
            Console.WriteLine("Multiplication " + Num5);

            double Num6 = Num1 / Num2;
            Console.WriteLine("Division " + Num6);



            //Third Program (that takes four numbers as input to calculate and print the average)

            Console.WriteLine("Enter first Value");
            double avg1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Value");
            double avg2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Value");
            double avg3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter fourth Value");
            double avg4 = Convert.ToInt32(Console.ReadLine());
            double Avg = (avg1 + avg2 + avg3 + avg4) / 4;
            Console.WriteLine("Average is :" + Avg);



            //Fourth program(to check two given integers and return true if one is negative and one is positive)


            Console.WriteLine("Enter 1st number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            int y = Convert.ToInt32(Console.ReadLine());


            if (((x > 0 && y < 0) || (x < 0 && y > 0)) && (x != 0 && y != 0))

            {
                Console.WriteLine("True");
            }

            else

                Console.WriteLine("False");

            //Fifth Program (to compute the sum of two given integers,
            //if two values are equal then return the triple of their sum)

            Console.WriteLine("Enter first Value ");
            int Trp1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Value");
            int Trp2 = Convert.ToInt32(Console.ReadLine());


            if (Trp1 == Trp2)

            {
                int sum = Trp1 + Trp2;
                int Trpsum = sum * 3;


                //Trpsum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Triple of their sum :" + Trpsum);

            }

            else

                Console.WriteLine("Given numbers are not equal");


            // 6th Program (To check First word Hello )

            Console.WriteLine("Write a sentence");
            string sentence = Console.ReadLine();
            Console.WriteLine(sentence.StartsWith("Hello"));

            Console.WriteLine(sentence.Split()[0]);



        }


    }
}
















