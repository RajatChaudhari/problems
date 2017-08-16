using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class Rainbow
    {
        public string FindRainbow2()
        {

            int n = Convert.ToInt32(Console.ReadLine());
            string[] numbers = Console.ReadLine().Trim().Split(' ');
            int[] nintegers = Array.ConvertAll(numbers, int.Parse);
            int m = (nintegers.Length / 2);
            
            if (nintegers.Length % 2 == 0)
            {
                int l = (nintegers.Length / 2)-1;
                for (int k = 0; k < l; k++)
                {
                    if (nintegers[k + 1] - nintegers[k] > 1)
                    {
                        return "no";
                    }
                }
                for (int j = 0; j <= l; j++)
                {
                    if (nintegers[l + j+1] != nintegers[l - j])
                    {
                        return "no";
                    }
                }
                return "yes";
            }
            else
            {
                for (int k = 0; k < m; k++)
                {
                    if (nintegers[k + 1] - nintegers[k] > 1)
                    {
                        return "no";
                    }
                }

                for (int j = 0; j <= m; j++)
                {
                    if (nintegers[m + j] != nintegers[m - j])
                    {
                        return "no";
                    }
                }
                return "yes";
            }


        }

        public int FindRainbow()
        {

            int n = Convert.ToInt32(Console.ReadLine());
            string[] numbers = Console.ReadLine().Trim().Split(' ');
            int[] nintegers = Array.ConvertAll(numbers, int.Parse);
            int mid = 0;
            //if(n<7 || n>100)
            //{
            //    Console.WriteLine("no");
            //    return 0;
            //}
            if(nintegers.Min()<1)
            {
                Console.WriteLine("no");
                
                return 0;
            }
            
                mid = n/2;
            
            for(int i=0,j=n-1;i<mid;i++,j--)
            {
                if(nintegers[i]!=nintegers[j] || nintegers[i+1]<nintegers[i] || nintegers[j]>nintegers[j-1] )
                {
                    Console.WriteLine("no");
                   
                    return 0;
                }
                if (nintegers[i + 1] - nintegers[i] > 1)
                {
                    Console.WriteLine("no");
                    return 0;
                }
                if (nintegers[0]!= 1)
                {
                    Console.WriteLine("no");
                    return 0;
                }
            }
            Console.WriteLine("yes");
            return 0;
        }

        //public static void Main(string[] args)
        //{
        //    Rainbow obj = new Rainbow();
        //    int cases = Convert.ToInt32(Console.ReadLine());
        //    for (int i = 0; i < cases; i++)
        //    {
        //        obj.FindRainbow();
        //    }
        //    Console.ReadLine();
        //}
    }
}
