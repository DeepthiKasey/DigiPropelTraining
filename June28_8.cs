using System;
public class June28_08
{
    public static void Main()
    {
        int i, ele;
        int[] a = new int[100];

        Console.Write("Enter the number of elements to store in the array :");
        ele = Convert.ToInt32(Console.ReadLine());


        Console.Write("Input {0} number of elements in the array :\n", ele);
        for (i = 0; i < ele; i++)
        {
            Console.Write("element - {0} : ", i);
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("\n Values store into Array are : ");
        for (i = 0; i < ele; i++)
        {
            Console.Write("{0}  ", a[i]);
        }

        Console.Write("\n  Values into the Array in Reverse are :");
        for (i = ele - 1; i >= 0; i--)
        {
            Console.Write("{0} ", a[i]);
        }
    }
}


/*
Enter number of elements to be stored in the array :5
*
*element 0 = 2
* element 1 = 1
* element 2 = 24
* element 3 = 7
element 4 = 6
* 
*
*output :
 *Values store into array 2 1 24 7 6
 *Values in reverse are 6 7 24 1 2 
 *
 * 
 */