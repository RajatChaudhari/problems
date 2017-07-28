using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class Suquation
    {
        void Equate()
        {
            int cases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(input[0]);
                int m = Convert.ToInt32(input[1]);
                int mul = 1;
                int sum = 0;
                for (int a = 2; a < n; a++)
                {
                    mul = a%m;
                    for (int b = 1; b <= a; b++)
                    {
                        mul *= mul%m;
                    }
                    sum += mul;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(1 % 2);
            Console.ReadLine();
        }
    }
}
