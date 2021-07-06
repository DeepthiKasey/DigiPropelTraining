using System;

namespace June30_6
{
    class pro6
    {
        public static void Main(string[] args)
        {
            string str1 = "welcome to digipropel India pvt ltd";
            Console.WriteLine("Original string: " + str1);
            //callig a function "test"
            Console.WriteLine("Position of the word 'welcome' in the said string: " + test(str1, "welcome"));
            Console.WriteLine("Position of the word 'digipropel' in the said string: " + test(str1, "digipropel"));
            Console.WriteLine("Position of the word 'India' in the said string: " + test(str1, "India"));
        }
        public static int test(string text, string word)
        {

            string[] arry = text.Split(' ');
            return Array.IndexOf(arry, word) + 1;

        }
    }
}
/*
 *         Original string: welcome to digipropel India pvt ltd";
           Position of the word 'welcome' in the said string: 1
           Position of the word 'digipropel' in the said string:3 
           Position of the word 'India' in the said string:4
       
 * 
*/