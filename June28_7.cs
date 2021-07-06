using System;
public class June28_07
{
    public static void Main()
    {
        int[] arr1 = new int[50];
        int i, max, min, ele;


        Console.WriteLine("Enter the number of elements to be stored in the array :");
        ele = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input {0} elements in the array :\n", ele);
        for (i = 0; i < ele; i++)
        {
            Console.WriteLine("element - {0} : ", i);
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }


        max = arr1[0];
        min = arr1[0];

        for (i = 1; i < ele; i++)
        {
            if (arr1[i] > max)
            {
                max = arr1[i];
            }


            if (arr1[i] < min)
            {
                min = arr1[i];
            }
        }
        Console.WriteLine("Maximum element is : {0}\n", max);
        Console.WriteLine("Minimum element is : {0}\n\n", min);
    }
}
/*
Enter number of elements to be stored in the array : 4
*
*element 0 = 23
* element 1 = 2
* element 2 = 54
* element 3 = 4
* 
*
*output :
 *Max is 54
 *min is 2
 * 
 * 