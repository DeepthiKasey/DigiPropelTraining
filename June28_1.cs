using System;
class June28_1
{
    static void Main()
    {

        int[] arr = new int[50];
        int i, ele, sum = 0;

        Console.WriteLine("Enter the element count:\n");
        ele = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input {0} elements in the array : \n ", ele);

        for (i = 0; i < ele; i++)
        {
            Console.WriteLine("element - {0} : ", i);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

    
        for (i = 0; i < ele; i++)
        {
            sum = sum + arr[i];
        }
        Console.WriteLine("Sum of the elements in the array : {0}", sum);
    }
}

/* Enter the size of the elements : 4
 * element 0 = 1
 * element 1= 3
 * element 2 = 3
 * element 3 = 2
 * 
 * sum of the elements in the array : 9
 * */