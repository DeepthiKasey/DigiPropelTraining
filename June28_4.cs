using System;
public class June28_04
{
    public static void Main()
    {
        int[] arr1 = new int[50];
        int[] arr2 = new int[50];
        int[] arr3 = new int[50];
        int i, j = 0, k = 0, ele;

        Console.WriteLine("Enter number of elements to be stored in the array :");
        ele = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input {0} elements in the array :\n", ele);
        for (i = 0; i < ele; i++)
        {
            Console.WriteLine("element - {0} : ", i);
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < ele; i++)
        {
            if (arr1[i] % 2 == 0)
            {
                arr2[j] = arr1[i];
                j++;
            }
            else
            {
                arr3[k] = arr1[i];
                k++;
            }
        }

        Console.WriteLine("\nThe Even elements are : \n");
        for (i = 0; i < j; i++)
        {
            Console.WriteLine("{0} ", arr2[i]);
        }

        Console.WriteLine("\nThe Odd elements are :\n");
        for (i = 0; i < k; i++)
        {
            Console.Write("{0} ", arr3[i]);
        }
        Console.WriteLine("\n\n");
    }
}


/*
 * Enter number of elements to be stored in the array : 4
 * 
 * element 0 = 1
 * element 1 =4
 * 2 = 5
 * 3 = 6
 * 
 * output :
 * the even elemets are 4 6
 * odd elements are 1 5 
 * 
 * 
 * 
 * 
 * */
