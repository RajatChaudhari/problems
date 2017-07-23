using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    public class Calculator
    {
        //incomplete
        public void CallCalulator()
        {
            int cases = Convert.ToInt32(Console.ReadLine());
            int[,] data = new int[cases,2];

            for (int i = 0; i < cases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                if(!(input.Contains("")||input.Contains("0")))
                {
                    data[i, 0] = Convert.ToInt32(input[0]);
                    data[i, 1] = Convert.ToInt32(input[1]);
                }
            }

            for (int a = 0; a < cases; a++)
            {
                if (!(data[a,0].Equals(0) || data[a,1].Equals(0)))
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
                    if (aa > consumed)
                    {
                        for (int i = 0; i < aa; i = i + consumed)
                        {
                            mul = mul + firstbutton;
                        }
                    }

                    Console.WriteLine(mul);
                }
            }
            
        }

        //public static void Main(string[] args)
        //{
        //    Calculator c = new Calculator();
        //    c.CallCalulator();
        //    Console.ReadLine();
        //}
    }
}
