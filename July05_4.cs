using System;

namespace July05_4
{
    class Program
    {
        static void Main()
        {

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
      public class Person
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

    public class Student:Person
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
    public class Teacher: Student
    {
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
