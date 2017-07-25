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
                char curr='a';
                string fromQ;
                List<char> charlist = new List<char>();
                for(int a=0;a<Q.Length;a++)
                {
                    fromQ = Q.Substring(a,1);
                    if(!P.Contains(fromQ))
                    {
                        P.Replace(P.Substring(a, 1), fromQ);
                    }
                }

            }
        }

        static void Main(string[] args)
        {
            Histosim call=new Histosim();
            call.CheckString();
        }
    }
}
