using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class HR_gs_BuyMaxStocks
    {
        static long buyMaximumProducts(int n, long k, int[] a)
        {
            long stock=0;

            for (int i = 1; i <= n; i++)
            {
                long amount = 0;
                long cc = k / a[i - 1];
                long min = Math.Min(cc, i);
                stock += min;
                amount += min * a[i - 1];
                k -= amount;
            }
            return stock;
        }

        //static void Main(String[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    string[] arr_temp = Console.ReadLine().Trim(' ').Split(' ');
        //    int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        //    long k = Convert.ToInt64(Console.ReadLine());
        //    long result = buyMaximumProducts(n, k, arr);
        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}


        #region 1sttry
        //static long buyMaximumProducts(int n, long k, int[] a)
        //{
        //    long stock = 0;

        //    for (int i = 1, j = 0; i <= n; i++, j++)
        //    {
        //        int amount = 0;
        //        amount = i * a[j];
        //        while (amount > k)
        //        {
        //            i--;
        //            amount = i * a[j];
        //        }
        //        if (i > 0)
        //        {
        //            k -= amount;
        //            stock += i;
        //        }

        //        i = j + 1;


        //    }
        //    return stock;
        //} 
        #endregion
    }
}
