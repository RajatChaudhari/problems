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

            for (int i = 0; i < cases; i++)
            {
                string sign = Console.ReadLine();
                signCount = signCount + sign.Length;
                signList.Add(sign);
            }
            
            foreach (string s in signList)
            {
                string str=s.Replace("=",string.Empty);
                string[] gt = str.Split('<');
                string[] lt = str.Split('>');
                int maxgt = 0;
                int maxlt = 0;
                for (int i = 0; i < gt.Length; i++)
                {
                    int a=gt[i].Length;
                    if (a > maxgt)
                    {
                        maxgt = a;
                    }
                }
                for (int i = 0; i < lt.Length; i++)
                {
                    int a = lt[i].Length;
                    if (a > maxlt)
                    {
                        maxlt = a;
                    }
                }
                int P = 0;
                P = Math.Max(maxgt, maxlt) + 1;
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
