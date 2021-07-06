using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Globalization;
using System.Text;

namespace June30_8
{
    class Pro8
    {
                 public static void Main(string[] args)
            {


            string str;
            Console.WriteLine("enter the input string to alternate the letters:");
            str = Console.ReadLine();
            
                char[] ch = str.ToCharArray();

                StringBuilder sb = new StringBuilder(); 
            
            for (int i = 0; i < ch.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        ch[i] = char.ToUpper(ch[i]);
                    }
                    sb.Append(ch[i].ToString());
                }
                Console.WriteLine(sb.ToString());
            }
        }
    }



