using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class Histosim
    {
        void Check_String()
        {
            int cases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cases;i++ )
            {
                string[] input = Console.ReadLine().Split(' ');
                string P = input[0];//.ToCharArray();
                string Q = input[1];//.ToCharArray();
                char[] Pc = P.ToCharArray();
                char[] Qc = Q.ToCharArray();
                char curr = 'a';
                int count = 0;
                for (int a = 0; a < Q.Length;)
                {
                    curr = Q.Substring(a, 1).ToCharArray()[0];
                    if (P.Substring(a, 1) != Q.Substring(a, 1))
                    {
                        while (P.Contains(curr))
                        {
                            curr++;                            
                        }
                        P = P.Replace(P.Substring(a, 1).ToCharArray()[0], curr);
                        //a++;
                    }
                    a++;
                    if (a==Q.Length && P!= Q)
                    {
                        a = 0;
                        count++;
                    }
                    if(P==Q)
                    {
                        Console.WriteLine("YES");
                        break;
                    }
                    if(count==2)
                    {
                        Console.WriteLine("NO");
                        break;
                    }
                }

            }
        }

        void CheckString()
        {
            int T;
            T = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= T; i++)
            {
                string P, Q;
                string[] inpargs = Console.ReadLine().Split(' ');
                P = inpargs[0];
                Q = inpargs[1];
                bool breaked = false;
                for (int j = 1; j <= P.Length; j++)
                {
                    if (Q.IndexOf(Q[j - 1]) != P.IndexOf(P[j - 1]))
                    {
                        breaked = true;
                        Console.WriteLine("NO");
                        break;
                    }
                }

                if (!breaked)
                    Console.WriteLine("YES");
            }
        }

        //static void Main(string[] args)
        //{
        //    Histosim call=new Histosim();
        //    call.CheckString();
        //    Console.ReadLine();
        //}
    }
}
