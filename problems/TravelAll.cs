using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class TravelAll
    {
        void FindD()
        {
            int cases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[2];
                int[,] twoarr = new int[n,2];
                List<Array> arrList = new List<Array>();
                for(int j=0;j<n;j++)
                {
                    string[] input = Console.ReadLine().Trim().Split(' ');
                    //array[0] = int.Parse(input[0]);
                    //array[1] = int.Parse(input[1]);
                    //arrList.Add(array);
                    twoarr[j, 0] = int.Parse(input[0]);
                    twoarr[j, 1] = int.Parse(input[1]);
                }
                for (int k = 0; k < n; k++)
                {
                    int ans = Math.Abs(twoarr[k, 0] - twoarr[k + 1, 0]) + Math.Abs(twoarr[k, 1] - twoarr[k + 1, 1]);
                }
                foreach (int[] arr in arrList)
                { 
                    
                }

            }
        }
        //public static void Main(string[] args)
        //{
        //    TravelAll la = new TravelAll();
        //    la.FindD();
        //    Console.ReadLine();
        //}
    }
}
