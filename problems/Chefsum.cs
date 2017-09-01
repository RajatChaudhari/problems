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
                Dictionary<int, int> sums = new Dictionary<int, int>();


            }


        }

        public static long prefixSum(int n)
        {
            return 0;
        }

        public static long suffixSum(int n)
        {
            return 0;
        }
    }
}
