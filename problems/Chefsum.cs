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
                long[] sums = new long[n];
                int ans = 0;
                for (int j = 0; j < n; j++)
                {
                    int[] pre = new int[n];
                    int[] suf = new int[n];
                    Array.Copy(nums, 0, pre, 0,j+1);
                    Array.Copy(nums, j, suf, 0, n - j);
                    sums[j] = pre.Sum() + suf.Sum();
                }   
                ans = Array.IndexOf(sums,sums.Min());
                Console.WriteLine(ans+1);
            }
        }
    }
}
