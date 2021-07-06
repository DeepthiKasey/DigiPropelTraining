using System;
using System.Linq;
namespace June28_6
{
    class June28_06
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine("Original array elements:");
            Array.ForEach(nums, Console.WriteLine);
            Console.WriteLine("Missing number in the said array (10-20): " + test(nums));
            int[] nums1 = { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine("\nOriginal array elements:");
            Array.ForEach(nums1, Console.WriteLine);
            Console.WriteLine("Missing number in the said array (10-20): " + test(nums1));
            int[] nums2 = { 10, 11, 12, 13, 14, 16, 17, 18, 19, 20 };
            Console.WriteLine("\nOriginal array elements:");
            Array.ForEach(nums2, Console.WriteLine);
            Console.WriteLine("Missing number in the said array (10-20): " + test(nums2));
            int[] nums3 = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            Console.WriteLine("\nOriginal array elements:");
            Array.ForEach(nums3, Console.WriteLine);
            Console.WriteLine("Missing number in the said array (10-20): " + test(nums3));

        }
        public static int test(int[] arr)

        {
            return 165 - arr.Sum();
        } 

    }
}
