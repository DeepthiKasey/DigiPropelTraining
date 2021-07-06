using System;
public class June28_09
{
    public static void Main()
    {
        int[] arr1 = new int[10];
        int ele, i, j, tmp;

        Console.WriteLine("Enter the size of array : ");
        ele = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input {0} elements in the array :\n", ele);
        for (i = 0; i < ele; i++)
        {
            Console.Write("element - {0} : ", i);
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < ele; i++)
        {
            for (j = i + 1; j < ele; j++)
            {
                if (arr1[j] < arr1[i])
                {
                    tmp = arr1[i];
                    arr1[i] = arr1[j];
                    arr1[j] = tmp;
                }
            }
        }
        Console.WriteLine("\nElements of array in sorted ascending order:\n");
        for (i = 0; i < ele; i++)
        {
            Console.WriteLine("{0}  ", arr1[i]);
        }
        Console.WriteLine("\n\n");
    }

}

/*
Enter number of elements to be stored in the array :6
*
*element 0 = 2
* element 1 = 1
* element 2 = 24
* element 3 = 7
element 4 = 6
element 5 = 4
*
*
*output :
 *elements of array sorted :1 2 4 6 7 24
