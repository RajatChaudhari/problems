using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class MaxOr
    {
        void FindValid()
        {
            int cases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());
                string[] input = Console.ReadLine().Trim().Split(' ');
                int[] numbers = Array.ConvertAll(input, int.Parse);
                List<int> intList = new List<int>();
                int count=0;
                int[] choosen = new int[numbers.Length];
                for (int j = 0; j < numbers.Length; j++)
                {
                    if(numbers[j]>=1&&numbers[j]<=n)
                    {
                        intList.Add(numbers[j]);
                    }
                }
                int[,] arrArray = new int[intList.Count, 2];
                ArrayList arrList = new ArrayList();
                for (int k = 0; k < intList.Count; k++)
                {
                    for (int l = k+1; l < intList.Count; l++)
                    {
                        int[] pair=new int[]{intList.ElementAt(k),intList.ElementAt(l)};
                        if(!arrList.Contains(pair))
                            arrList.Add(pair);
                    }
                }

                foreach (int[] ar in arrList)
                {
                    if ((ar[0] | ar[1]) <= ar.Max())
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
        }
        //public static void Main(string[] args)
        //{
        //    MaxOr la = new MaxOr();
        //    la.FindValid();
        //    Console.ReadLine();
        //}
    }
}
