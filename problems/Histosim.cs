using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class Histosim
    {
        void CheckString()
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
                        
                        a++;
                        
                        

                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Histosim call=new Histosim();
            call.CheckString();
            Console.ReadLine();
        }
    }
}
