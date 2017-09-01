using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class Alate
    {
        public static void Main(string[] args)
        {
            int cases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                SMethod();
            }
            //Console.ReadLine();
        }

        public static void SMethod()
        {
            int[] nNq = Array.ConvertAll(Console.ReadLine().Trim().Split(' '),int.Parse);
            Int64[] numbers = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Int64.Parse);
            Int64[] queries=new Int64[3];
            for (int i = 0; i < nNq[1]; i++)
            {
                queries = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Int64.Parse);
                if (queries[0] == 1)
                {
                    long sum = 0;
                    for (long j = queries[1] - 1; j < numbers.Length; j += queries[1])
                        sum = (sum + numbers[j] % 1000000007 * numbers[j] % 1000000007) % 1000000007;
                    Console.WriteLine(sum);
                    
                }
                else if (queries[0] == 2)
                {
                    numbers[queries[1]-1] = queries[2];
                }
            }
        }
               

    }
}
