using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace problems
{
    public class ChefSignsRough
    {
        public void CallChefSigns()
        {
            int cases = Convert.ToInt32(Console.ReadLine());
            List<string> signList = new List<string>();
            int signCount = 0;

            for (int i = 0; i < cases; i++)
            {
                string sign = Console.ReadLine();

                signCount = signCount + sign.Length;
                if (sign.Length > 0)
                    signList.Add(sign);
            }
            foreach (string s in signList)
            {
                int l = s.Length;
                int[] num = new int[l + 1];
                num[0] = l+1;
                for (int i = 0; i < l; i++)
                {
                    if (s.Substring(i, 1) == ">")
                    {
                        num[i + 1] = num[i] - 1;
                    }
                    else if (s.Substring(i, 1) == "<")
                    {
                        num[i + 1] = num[i] + 1;
                    }
                    else if (s.Substring(i, 1) == "=")
                    {
                        num[i + 1] = num[i];
                    }
                }
                //int P = (num.Max()- num.Min())+1;
                int P = num.Distinct().Count();

                for (int z = 0; z < num.Length; z++)
                {
                    Console.Write(num[z] + " ");

                }
                Console.WriteLine("");
                Console.WriteLine(P);
            }
        }
        //static void Main(string[] args)
        //{
        //    ChefSignsRough cs = new ChefSignsRough();
        //    cs.CallChefSigns();
        //    Console.Read();
        //}
    }
}
