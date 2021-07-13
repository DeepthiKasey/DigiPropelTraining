using System;

namespace July07
{
    class July07_1
    {
        //Using Interfaces
        // program that implements an IVehicle interface with two methods
        public static void Main(string[] args)
        {
            Car car = new Car(0);
            Console.WriteLine("Enter Car Speed:\n  ");
            int fuel = int.Parse(Console.ReadLine());
            if (car.Refuel(fuel))
            {
                car.Drive();
            }
        }
        public interface IVehicle
        {
            void Drive();
            bool Refuel(int amount);
        }
        public class Car : IVehicle //creating a Car class with a builder
        {
            public int Fuel { get; set; }

            public Car(int fuel)
            {
                Fuel = fuel;
            }
            public void Drive() //Drive method will print on the screen that the car is Driving if fuel is not 0
            {
                if (Fuel > 0)
                {
                    Console.WriteLine("Driving");
                }
                else
                {
                    Console.WriteLine("No fuel");
                }
            }
            public bool Refuel(int amount)
            {
                Fuel += amount;
                return true;
            }
        }
    }
}

