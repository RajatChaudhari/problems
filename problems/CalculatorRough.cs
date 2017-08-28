using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace problems
    {
        public class CalculatorRough
        {
            public void CallCalulator()
            {
                int cases = Convert.ToInt32(Console.ReadLine());
                int[,] data = new int[cases, 2];
                
                for (int i = 0; i < cases; i++)
                {
                    string[] input = Console.ReadLine().Split(' ');
                    data[i, 0] = Convert.ToInt32(input[0]);
                    data[i, 1] = Convert.ToInt32(input[1]);
                }
                for (int a = 0; a < cases; a++)
                {
                    int power = data[a, 0];

                    int consumed = data[a, 1];
                    int unit = 0;
                    if (consumed > 1)
                    {
                        unit = power / 2 - 1;
                    }
                    else
                    {
                        unit = power / 2;
                    }

                    int firstbutton = unit * 1;
                    int mul = 0;
                    int aa = power - firstbutton;
                    for (int i = 0; i < aa; i = i + consumed)
                    {
                        mul = mul + firstbutton;
                    }
                    int second = firstbutton + mul;
                    Console.WriteLine(power + " " + consumed + " " + unit + " " + mul);
                    Console.WriteLine("answer: " + mul);
                }


            }

            public int ExpoSearch(int[] arr, int n, int x)
            {
                int lo=0, hi=9;

                int a = lo + (
                                (  (hi - lo) /(arr[hi] - arr[lo])  ) * (x - arr[lo])
                             );

                if (arr[0] == x)
                    return 0;

                int i = 1;
                while(i<n&&arr[i]<x)
                {
                    i *= 2;
                }

                return 0;// arr, i/2, Math.Min(1,n),x to binary search

            }



            //public static void Main(string[] args)
            //{
            //    CalculatorRough c = new CalculatorRough();
            //    c.CallCalulator();
            //    Console.ReadLine();
            //}
        }
    }

}
