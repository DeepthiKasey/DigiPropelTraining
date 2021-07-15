using System;
using System.Text;
public class sumString
{
    public static void Main(string[] args)
    {
        int n1, n2,  tempS3, tempS4, sum = 0;
        //String s1, s2;
        Console.Write("Input the size of array1 : ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the size of array2 : ");
        n2 = Convert.ToInt32(Console.ReadLine());
        int[] arr1 = new int[n1];
        int[] arr2 = new int[n2];
        Console.Write("Input {0} elements in the array :\n", n1);
        for (int i = 0; i < n1; i++)
        {
            Console.Write("element - {0} : ", i);
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Input {0} elements in the array :\n", n2);
        for (int i = 0; i < n2; i++)
        {
            Console.Write("element - {0} : ", i);
            arr2[i] = Convert.ToInt32(Console.ReadLine());
        }

        string[] strArray1 = Array.ConvertAll(arr1, ele => ele.ToString());
        string[] strArray2 = Array.ConvertAll(arr2, ele => ele.ToString());


        tempS3 = Convert.ToInt32(string.Join("", strArray1));
        tempS4 = Convert.ToInt32(string.Join("", strArray2));

        sum = tempS3 + tempS4;
        Console.Write("{0} + {1} = {2}", tempS3, tempS4, sum);


    }
}