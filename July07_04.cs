using System;


public class Student
{
    private int rollno;
    private string name;
    private string course;
    private int feepaid;

    //Service Tax set to 12.3%
    private static double servicetax = 12.3;

    public Student(int rollno, string name, string course) //Defining Constructor
    {
        this.rollno = rollno;
        this.name = name;
        this.course = course;
    }

    public void Payment(int amount)
    {
        feepaid += amount;
    }

    public void PrintStdDetails() // Displaying Variables
    {
        Console.WriteLine("RollNO:{0}", rollno);
        Console.WriteLine("Name:{0}", name);
        Console.WriteLine("course: {0}", course);
        Console.WriteLine("Feepaid: {0}", feepaid);
    }

    public int DueAmount
    {
        get
        {
            return TotalFee - feepaid; //(TotalFee - amount paid (1000))
        }
    }

    public int TotalFee
    {
        get
        {
            double total = course == "c#" ? 2000 : 3000; // Caluculation for c# then fee will be 2000 else 3000)
                                                         
            total = total + total * servicetax / 100; // (Caluculation for Asp.net then total is 12.3/100 * 2000 + 2000)
            return (int)total;
        }
    }

    public static double ServiceTax // defining Static servicetax 
    {
        get
        {
            return servicetax;
        }
        set
        {
            servicetax = value; // which is 12.3
        }
    }
}

public class UseStudent2
{

    public static void Main()
    {

        Student obj1 = new Student(1, "Raja", "Asp.net");
        obj1.Payment(500);
        obj1.PrintStdDetails();
        Console.WriteLine("Due Amount: {0}", obj1.DueAmount); // will call due amount for asp.net refer comment call_1 at line 49
        Console.WriteLine();//for next line

        Student obj2 = new Student(2, "Deepthi", "c#");
        obj2.Payment(1500);
        obj2.PrintStdDetails();
        Console.WriteLine("Due Amount: {0}", obj2.DueAmount);


    }
}
/*
RollNO:1
Name:Raja
course: Asp.net
Feepaid: 500
Due Amount: 2869

RollNO:2
Name:Deepthi
course: c#
Feepaid: 1500
Due Amount: 746
*/
