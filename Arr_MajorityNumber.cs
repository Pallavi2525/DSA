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
            var result = MajorityNumber(ar);
            Console.Write("Majority element is " + ((!(result == -1)) ? result.ToString() : "NONE") + " ");
        }
        public static int MajorityNumber(int[] nums)
        {
            int maxCount = nums.Length/2;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                        count++;
                }
                if(count > maxCount)
                    return nums[i];
            }
            return -1;
        }
    }
}
