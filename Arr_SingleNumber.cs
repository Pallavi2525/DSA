using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length of the array:");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[length];
            Console.WriteLine("Enter " + length.ToString() + " numbers:");
            for (int i = 0; i < length; i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Element occurring once is " + SingleNumber(ar) + " ");
        }
        public static int SingleNumber(int[] nums)
        {
            int result = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                result = result ^ nums[i];
            }
            return result;
        }
    }
}
