using System;
public class June28_05
{
    public static void Main()
    {
        int[,] arr1 = new int[50, 50];
        int[,] brr1 = new int[50, 50];
        int i, j, r1, c1, r2, c2, valid = 1;

        
        Console.Write("Enter the number of rows in the 1st matrix : ");
        r1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("ENter the number of columns in  the 1st matrix : ");
        c1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of rows in the 2nd matrix : ");
        r2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the number of columns in  the 2nd matrix : ");
        c2 = Convert.ToInt32(Console.ReadLine());


        for (i = 0; i < r1; i++)
        {
            for (j = 0; j < c1; j++)
            {
                Console.Write("element - [{0}],[{1}] : ", i, j);
                arr1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.Write("Enter elements in the second matrix :\n");
        for (i = 0; i < r2; i++)
        {
            for (j = 0; j < c2; j++)
            {
                Console.Write("element - [{0}],[{1}] : ", i, j);
                brr1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.Write("The first matrix is :\n");
        for (i = 0; i < r1; i++)
        {
            for (j = 0; j < c1; j++)
                Console.Write("{0}  ", arr1[i, j]);
            Console.Write("\n");
        }
        Console.Write("The second matrix is :\n");
        for (i = 0; i < r2; i++)
        {
            for (j = 0; j < c2; j++)
                Console.Write("{0}  ", brr1[i, j]);
            Console.Write("\n");
        }



        // Comparing two matrices for equality */

        if (r1 != r2 && c1 != c2)
        {
           Console.WriteLine("Size of two matrices are not same");

        }
        else
        {
            Console.WriteLine("Size of two Matrices are same \n");

            // to check the values given in two matrices are equal or not 

            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c2; j++)
                {
                    if (arr1[i, j] != brr1[i, j])
                    {
                        valid = 0;
                        break;
                    }
                }
            }
            if (valid == 1)
                Console.Write("Two matrices are equal.\n\n");
            else
                Console.Write("But,two matrices are not equal\n\n");
        }

    }
    }