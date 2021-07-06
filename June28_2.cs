using System;

namespace June28_002
{
    class June28_002
    {
        public static void Main(string[] args)
        {
            int ele, i, j;
            int dupl = 1, occr = 0;
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int[] arr3 = new int[100];

            Console.WriteLine("Enter the element count:\n");
            ele = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input {0} elements in the array : \n ", ele);

            for (i = 0; i < ele; i++)
            {
                Console.WriteLine("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            // copying entered array values to another array

            for (i = 0; i < ele; i++)
            {
                arr2[i] = arr1[i];
                arr3[i] = 0;
            }

            // Identifying Duplicates

            for (i = 0; i < ele; i++)
            {
                for (j = 0; j < ele; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        arr3[j] = dupl;

                        dupl++;
                    }
                }
                dupl = 1;

            }

            //displaying occurances

            for (i = 0; i < ele; i++)
            {
                if (arr3[i] == 2) { occr++; }
                //  occr++; 
            }
            Console.WriteLine("The number of duplicate elements are: {0} \n", occr);

            Console.WriteLine("\n\n");

        }
    }

}


/*
 * element size = 4
 * 0= 1
 * 1 = 1
 * 2 =3
 * 3 = 2
 * number of duplicate elements are : 1
 * */




