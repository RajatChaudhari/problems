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
            int signCount = 0;
            if (cases >= 1 && cases <= 100000)
            {
                for (int i = 0; i < cases; i++)
                {
                    string sign = Console.ReadLine().Trim(' ');

                    if ((sign.Length > 0 && sign.Length <= 100000) && Regex.IsMatch(sign, @"^[<>=]+$"))
                    {
                        signCount = signCount + sign.Length;
                        if (signCount >= 1 && signCount <= 1000000)
                            signList.Add(sign);
                        else
                            break;
                    }
                }
            }
                //if (signCount >= 1 && signCount <= 1000000)
                //{
                foreach (string s in signList)
                {
                    List<int> intlist = new List<int>();
                    int l = s.Length;
                    int[] num = new int[l + 1];
                    num[0] = l + 1;
                    for (int i = 0; i < l; i++)
                    {
                        if (s.Substring(i, 1) == ">")
                        {
                            num[i + 1] = num[i] + 1;
                        }
                        else if (s.Substring(i, 1) == "<")
                        {
                            num[i + 1] = num[i] - 1;
                        }
                        else if (s.Substring(i, 1) == "=")
                        {
                            num[i + 1] = num[i];
                        }
                    }
                    int P = num.Distinct().Count();
                for (int z = 0; z < num.Length; z++)
                {
                    Console.Write(num[z]);

                }
                Console.WriteLine("");
                Console.WriteLine(P);
                }
                //    }
            //}
        }
        //static void Main(string[] args)
        //{
        //    ChefSigns cs = new ChefSigns();
        //    cs.CallChefSigns();
        //    Console.Read();
        //}
    }
}
