using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace July05_5
{
    class July05_5
    {
        static void Main(string[] args)
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.

                Console.WriteLine("Enter entire location of file along with file extension:"); // to take input from user
                string filename;
                filename = Console.ReadLine();

                //   using (StreamReader sr = new StreamReader("D:/Deepthi.txt"))
                using (StreamReader sr = new StreamReader(filename))

                {
                    string line;
                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch
            (Exception e) // if the file doesn't found it will pass exception message
            {
                Console.WriteLine("The File Couldnot find");
                Console.WriteLine(e.Message);

            }
            Console.ReadKey();

        }
    }
}


/*
 * Enter entire location of file along with file extension:
 * 
 * d:/Deepthi.txt
 * 
 * Hi Hello
 */ 