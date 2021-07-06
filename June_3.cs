using System;

namespace June30_3
{
    class June_3
    {
        static void Main(string[] args)
        {
            int row, column;
            Console.Write("\n\n");
            Console.Write("Display the pattern like 'I' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 3; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    //if (column == 1 || ((row == 0 || row == 3 || row == 6) && (column < 5 && column > 1))
                    //    || (column == 5 && (row != 0 && row != 3 && row != 6)))

                    if ((row == 0 || row == 3 || column == 3 && (column < 4 && row > 1)
                    || (column == 3 && (row != 0 && row != 3 ))))

                        Console.Write("*");

                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

        }
    }
}

/* output
    
******
   *
   *
******
      
 */