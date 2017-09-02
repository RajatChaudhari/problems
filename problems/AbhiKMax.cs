using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class AbhiKMax
    {
        //public static void Main(string[] args)
        //{
        //    int cases = Convert.ToInt32(Console.ReadLine());
        //    for (int i = 0; i < cases; i++)
        //    {
        //        int[] nNK = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
        //        long[] numbers= Array.ConvertAll(Console.ReadLine().Trim().Split(' '), long.Parse);
        //        List<long> tempset = new List<long>();
        //        long[] kmax = new long[nNK[1]];
        //        long sum = 0;
        //        for (int j = 0; j < nNK[0]; j++)
        //        {
        //          sum+= SMethod(nNK[0], nNK[1],numbers,j);
        //        }
        //        Console.WriteLine(sum);
        //    }
        //    Console.ReadLine();
        //}
        public static long SMethod(int mN,int mK,long[] arr,int l)
        {
            long sum = 0;
            for (int j = 1; j <= mN; j++)
            {
                List<long> tempset = new List<long>();
                for (int k = l; k < j; k++)
                {
                    tempset.Add(arr[k]); 
                }
                sum += findMax(tempset, mK);
            }
            return sum;
        }

        public static long findMax(List<long> arrayy, int k)
        {
            long sum = 0;
            long max = 0;
            int le = arrayy.Count;
            
            for (int i =0; i < Math.Min(k, le); i++)
            {
                max = arrayy.Max();
                sum += max%1000000007;
                arrayy.Remove(max);
            }
            return sum;
        }
    }
}
