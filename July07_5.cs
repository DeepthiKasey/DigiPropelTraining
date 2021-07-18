using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace July07_5
    {
    abstract class Course
    {
        protected string name;
        protected int duration;
        protected int coursefee;

        public Course(string name, int duration, int coursefee)
        {
            //Using this keyword
            this.name = name;
            this.duration = duration;
            this.coursefee = coursefee;
        }

        public virtual void Print()
        {
            Console.WriteLine("Course Name:{0}",name);
            Console.WriteLine("Duration:{0}",duration);
            Console.WriteLine("Course Fee:{0}",coursefee);
        }

        public abstract int GetTotalFee(); 
    }

    class ParttimeCourse : Course
    {
        private string timings;

        public ParttimeCourse(string name, int duration, int coursefee, string timings) : base(name, duration, coursefee)
        {
            this.timings = timings;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(timings);
        }

        public override int GetTotalFee()
        {
            return (int)(coursefee * 0.90); // 10% discount for partime course 
        }

    }

    class OnsiteCourse : Course //inheriting from course
    {
        private string company;
        private int nostud;

        public OnsiteCourse(string name, int duration, int coursefee, string company, int nostud)
            : base(name, duration, coursefee)
        {
            this.company = company;
            this.nostud = nostud;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Company Name:{0}",company);
            Console.WriteLine("No. of Candidates:{0}",nostud);
        }

        public override int GetTotalFee()
        {
            return (int)(coursefee * 1.1);  // 10% more for Onsite course
        }

    }

    class TestCourse
    {

        public static void Main()
        {
            Course c = new OnsiteCourse("ASP.NET", 30, 5000, "ABC Tech", 10);
            c.Print();
            Console.WriteLine("OnsiteCourse with 10% More :{0}",c.GetTotalFee());

            c = new ParttimeCourse("C#", 30, 3000, "7-8pm");
            c.Print();
            Console.WriteLine("Part Time Course After Discount:{0}",c.GetTotalFee());
        }


    }
}

/*
 *Course Name:ASP.NET
Duration:30
Course Fee:5000
Company Name:ABC Tech
No. of Candidates:10
OnsiteCourse with 10% More :5500
Course Name:C#
Duration:30
Course Fee:3000
7-8pm
Part Time Course After Discount:2700

 */ 