using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class Chefsum
    {
        public static void Main(string[] args)
        {
            int cases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int[] nums = Array.ConvertAll(Console.ReadLine().Trim(' ').Split(' '), int.Parse);
                Dictionary<int, int> sumsDict = new Dictionary<int, int>();
                long[] sums = new long[n];
                int[] pre = new int[n];
                int[] suf = new int[n];
                int ans = 0;
                for (int j = 0; j < n; j++)
                {
                    nums.CopyTo(pre, j);
                    sums[j] = prefixSum(j,nums) + suffixSum(j,nums);
                }
                
                ans = Array.IndexOf(sums,sums.Min());
                Console.WriteLine(ans+1);
            }
            Console.ReadLine();

        }

        public static long prefixSum(int j, int[] nums)
        {
            long sum = 0;

            //for (int i = 0; i <= j; i++)
            //{
            //    sum += nums[i];
            //}
            Array.ForEach(nums, delegate (int i) { sum += i; });
            return sum;
        }

        public static long suffixSum(int j,int[] nums)
        {
            int last = nums.Length;
            long sum = 0;
            for (int i = j; i < last; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}
