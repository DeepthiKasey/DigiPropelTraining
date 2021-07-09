using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace July05_10
{
    class July05_10
    {
        static void Main(string[] args)
        {
            CreateDirectory();
            CreateFile();
            Console.ReadKey();
        }
        //Creating Directory
        static void CreateDirectory()
        {
            DirectoryInfo dir = new DirectoryInfo("D:/Example");
            try
            {
                //to check Directory Exists
                if (dir.Exists)
                {
                    Console.WriteLine("Directory Already Exists");
                    Console.WriteLine("Directory Name:" + dir.Name);
                    Console.WriteLine("Path" + dir.FullName);
                    Console.WriteLine("Created on" + dir.CreationTime);
                    Console.WriteLine("Last Accessed" + dir.LastAccessTime);
                }
                else // creating directory if it doesn't exists
                {
                    dir.Create();
                    Console.WriteLine("Directory Created Successfully. Information of Directory:");
                    Console.WriteLine("Directory Name:" + dir.Name);
                    Console.WriteLine("Path" + dir.FullName);
                    Console.WriteLine("Created on" + dir.CreationTime);
                    Console.WriteLine("Last Accessed" + dir.LastAccessTime);
                }
            }
            catch (DirectoryNotFoundException d)
            {
                Console.WriteLine(d.Message.ToString());
            }
        }
        //Creating File 
        static void CreateFile()
        {
            FileInfo file = new FileInfo("D:\\Example\\test.txt");
            using (StreamWriter sw = file.CreateText())
            {
                sw.WriteLine("Hello File Handling");
            }
            //Diplaying File Info
            Console.WriteLine("File Create on : " + file.CreationTime);
            Console.WriteLine("Directory Name : " + file.DirectoryName);
            Console.WriteLine("Full Name of File : " + file.FullName);
            Console.WriteLine("File is Last Accessed on : " + file.LastAccessTime);

        }
    }
}


/*output:
 * 
 * 
 * Directory Already Exists
Directory Name:Example
PathD:\Example
Created on09-07-2021 22:55:24
Last Accessed09-07-2021 23:28:15
File Create on : 09-07-2021 23:08:51
Directory Name : D:\Example
Full Name of File : D:\Example\test.txt
File is Last Accessed on : 09-07-2021 23:30:05
System.IO.StreamReader
 */


