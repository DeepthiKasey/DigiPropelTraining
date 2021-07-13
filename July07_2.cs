

using System;

namespace July07_2
{
    //Using Abstract Class 
    //program that implements an abstract class Animal that has a Name property of type text 
    // and three methods
    public class July07_2
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine("Enter the name of the Dog:");
            dog.SetName(Console.ReadLine());
            Console.WriteLine(dog.GetName());
            dog.Eat();
        }
        public class Dog : Animal
        {
            public override void Eat()
            {
                Console.WriteLine("is Eating");
            }
        }

        // Defining a AbstractClass
        public abstract class Animal
        {
            private string Name;

            public void SetName(string name)
            {
                Name = name;
            }

            public string GetName()
            {
                return Name;
            }
            public abstract void Eat();
        }
    }
}

/*
 * Enter the name of the Dog:
 * Snaphy
 * Snaphy
 * is Eating
 */ 