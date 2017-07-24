using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class Traverse
    {
        /// <summary>
        /// 
        /// </summary>
        void CallTraverse()
        {
            int cases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cases;i++ )
            {
                int M = Convert.ToInt32(Console.ReadLine());
                int x = 0;
                int y = 0;
                int count=0;
                for (int j = 0; j < M;)
                {
                    if (count%2==0)
                    {
                        if (j < M)
                        {
                            x++;
                            j++;
                        }
                        
                    }
                    else
                    {
                        if (j < M)
                        {
                            y++;
                            j++;
                        }
                        if(j<M)
                        {
                            y++;
                            j++; 
                        }
                        
                    }
                    count++;
                }
                
                Console.WriteLine(x+" "+y);
            }
            
        }
        static void Main(string[] args)
        {
            Traverse tObj = new Traverse();
            tObj.CallTraverse();
            Console.Read();
        }
    }
}
