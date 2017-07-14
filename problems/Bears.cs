using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    public class Bears
    {
        int cases = 0;
        int[] max = new int[2];
        
        public void GoBears()
        {
            cases = Convert.ToInt32(Console.ReadLine());
            int[,] arraylist = new int[cases,2];
            for (int i = 0; i < cases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                max = Array.ConvertAll(input, int.Parse);
                arraylist[i,0] = max[0];
                arraylist[i, 1] = max[1];
            }
            for (int a = 0; a < cases; a++)
            {
                Console.WriteLine(arraylist[a,0]+" "+arraylist[a, 1]);
                int lmax = arraylist[a, 0];
                int bmax= arraylist[a, 1];
                int limak = 1;
                int bob = limak + 1;

                //for (int z = 0; z < lmax || bmax; z++)
                //{

                //}
            }
            Console.Read();
        }
    }
}
