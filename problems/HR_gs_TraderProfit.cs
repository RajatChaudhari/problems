using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class HR_gs_TraderProfit
    {
        static int traderProfit(int k, int n, int[] A)
        {
            int[] profit = new int[n*n];
            int[] maxprofit = new int[n * n];
            // Complete this function
            int a = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    Console.WriteLine("A i "+A[i]+" A j "+A[j]);
                    if (A[i] < A[j])
                    {
                        profit[a] = A[j] - A[i];
                        Console.WriteLine(profit[a]);
                        a++;
                    }
                }
                maxprofit[i] = profit.Max();
                    
            }
            return 0;
        }

        //static void Main(String[] args)
        //{
        //    int q = Convert.ToInt32(Console.ReadLine());
        //    for (int a0 = 0; a0 < q; a0++)
        //    {
        //        int k = Convert.ToInt32(Console.ReadLine());
        //        int n = Convert.ToInt32(Console.ReadLine());
        //        string[] arr_temp = Console.ReadLine().Split(' ');
        //        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        //        int result = traderProfit(k, n, arr);
        //        Console.WriteLine(result);
        //    }
        //}
    }
}
