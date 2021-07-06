using System;

namespace June30_5
{
    class June5
    {
        public static void Main()
        {
            string str;
            int word;

            Console.WriteLine("Write a sentence : ");
            str = Console.ReadLine();
            word = 1;

            for (int length = 0; length < str.Length; length++)
            {

                if (str[length] == ' ' || str[length] == '\t' || str[length] == '\n')
                {
                    word++;
                }

            }

                Console.Write("Number of words in the sentence: {0}\n", word);
            }
        }
    }
/*
 * Write a sentence: Hello, what r u doing?
 * 
 * Number of words in the sentence :5  
 * 
 * 
 */