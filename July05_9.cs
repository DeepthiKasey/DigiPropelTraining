using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace July05_10
{
    class July05_9
    {

        //Program to Make D:\csharp\example.dat file using BinaryWriter class,
        //store current date and time and read that text using BinaryReader class.
        static void Main(string[] args)
        {
            string file = @"D:\csharp\example.dat";
            //Creating a file in a folder which return Date and Time
            using (BinaryWriter writer=new BinaryWriter(File.Open(file,FileMode.Create)))
            {
                writer.Write("Current Date and Time is :" + DateTime.Now.ToString());
                writer.Write(true);
            }
            //Reading Data(Date and Time) from the File 
            using (BinaryReader reader = new BinaryReader(File.Open(file, FileMode.Open, FileAccess.Read)))
            {
                Console.WriteLine(reader.ReadString());
            }
            Console.ReadKey();
        }
    }
}
/*
 * Output:
 * 
 * Current Date and Time is :09-07-2021 20:47:30
 */ 