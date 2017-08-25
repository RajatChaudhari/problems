using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class HR_gs_TimeSeries
    {
        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int q = Convert.ToInt32(tokens_n[1]);
            string[] t_temp = Console.ReadLine().Split(' ');
            int[] time = Array.ConvertAll(t_temp, Int32.Parse);
            string[] p_temp = Console.ReadLine().Split(' ');
            int[] price = Array.ConvertAll(p_temp, Int32.Parse);
            for (int a0 = 0; a0 < q; a0++)
            {
                string[] tokens__type = Console.ReadLine().Split(' ');
                int _type = Convert.ToInt32(tokens__type[0]);
                int v = Convert.ToInt32(tokens__type[1]);

                if(_type==1)
                {

                }
            }


        }
    }
}
