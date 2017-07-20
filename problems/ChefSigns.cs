using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace problems
{
    public class ChefSigns
    {
        public void CallChefSigns()
        {
            int cases = Convert.ToInt32(Console.ReadLine());
            List<string> signList = new List<string>();

            for (int ii = 0; ii < cases; ii++)
            {
                string sign = Console.ReadLine().Trim(' ');

                int l = sign.Length;
                int[] num = new int[l + 1];
                num[0] = l + 1;
                for (int i = 0; i < l; i++)
                {
                    if (sign.Substring(i, 1) == ">")
                    {
                        num[i + 1] = num[i] + 1;
                    }
                    else if (sign.Substring(i, 1) == "<")
                    {
                        num[i + 1] = num[i] - 1;
                    }
                    else if (sign.Substring(i, 1) == "=")
                    {
                        num[i + 1] = num[i];
                    }
                }
                int P = num.Distinct().Count();
                Console.WriteLine(P);
            }
            
        }
        //static void Main(string[] args)
        //{
        //    ChefSigns cs = new ChefSigns();
        //    cs.CallChefSigns();
        //    Console.ReadLine();
        //}
    }
}
