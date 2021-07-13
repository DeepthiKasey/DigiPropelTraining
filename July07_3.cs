using System;

namespace July07_3
{
    class July07_3
    {
        static void Main()
        {
            //Program to create three classes plus another class to test the logic in your code. 
            //The main classes of the program are the following classes:

            Person person = new Person();
            person.Greet();


            Student student = new Student();
            student.SetAge(25);
            student.Greet();
            student.ShowAge();
            student.Study();

            Teacher teacher = new Teacher();
            teacher.Greet();
            teacher.SetAge(40);
            teacher.ShowAge();
            teacher.TeacherIntro();
            teacher.Explian();


        }
    }


    public class Person  // Creating Person Class 
    {
        protected int age;

        public void Greet()
        {
            Console.WriteLine("Hello");

        }
        public void SetAge(int n)
        {
            age = n;

        }
    }

    public class Student : Person  // student Class Inherit from Person Class

    // Creating method Study and ShowAge in Student Class
    {
        public void Study()
        {
            Console.WriteLine("Im studying");

        }
        public void ShowAge()
        {
            Console.WriteLine("My age is {0}", age);

        }
    }
    public class Teacher : Student // Teacher Class Inherit From Student Class
    {

        //Creating methos TeacherIntro And Explain in Class Teacher

        public void TeacherIntro()
        {
            Console.WriteLine("Im a Teacher");

        }
        public void Explian()
        {
            Console.WriteLine("Im explaining");

        }
    }
}



/*
 * Hello
 * Hello
 * My age is 25
 * Im studying
 * Hello
 * My age is 40
 * Im a Teacher
 * Im explaining
 * 
 * 
 * 
 * 
 */