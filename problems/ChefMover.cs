using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class ChefMover
    {
        public void MoveNum()
        {
            string[] NandD = Console.ReadLine().Trim().Split(' ');
            int n = Convert.ToInt32(NandD[0]);
            int d = Convert.ToInt32(NandD[1]);
            string[] numbers = Console.ReadLine().Trim().Split(' ');
            double[] nintegers = Array.ConvertAll(numbers, double.Parse);
            double sum=0;
            int count = 0;
            for (int i = 0; i < nintegers.Length; i++ )
            {
                sum += nintegers[i];
            }
            double res = sum/n;
            if((res)%1!=0)
            {
                Console.WriteLine(-1);
            }
            else
            {
               int o= nintegers.Count(m => m > res);
               if (o <= d)
               {
                   for (int i = 0; i < nintegers.Length; i++)
                   {
                       int a = d;
                       while (nintegers[i] > res)
                       {
                           nintegers[i]--;
                           count++;
                       }
                   }
                   Console.WriteLine(count);
               }
               else
               {
                   Console.WriteLine(-1);
               }
            }
            

        }
        //public static void Main(string[] args)
        //{
        //    ChefMover obj = new ChefMover();
        //    int cases = Convert.ToInt32(Console.ReadLine());
        //    for (int i = 0; i < cases; i++)
        //    {
        //        obj.MoveNum();
        //    }
        //    Console.ReadLine();
        //}
    }
}
