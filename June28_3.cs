using System;

namespace June28_03
{
    class June28_3
    {
        public static void Main()
        {
            int[] arr1 = new int[50];
            int[] frq1 = new int[50];
            int ele, i, j, occr;

            Console.WriteLine("Enter the number of elements to be stored in the array:");
            ele = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input {0} elements in the array :", ele);
            for (i = 0; i < ele; i++)
            {
                Console.WriteLine("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                frq1[i] = -1;
            }
            for (i = 0; i < ele; i++)
            {
                occr = 1;
                for (j = i + 1; j < ele; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        occr++;
                        frq1[j] = 0;
                    }
                }

                if (frq1[i] != 0)
                {
                    frq1[i] = occr;
                }
            }
            Console.WriteLine("The frequency of all elements of the array : ");
            for (i = 0; i < ele; i++)
            {
                if (frq1[i] != 0)
                {
                    Console.Write("{0} occurs {1} times\n", arr1[i], frq1[i]);
                }
            }
        }

    }
}

/*
 * 

Enter the number of elements to be stored in the array: 4
element 0= 1
1 = 1
2 = 4
3= 5
output:
1 occurs 2 times
4 occurs 1 times
5 occurs 1 time


*/