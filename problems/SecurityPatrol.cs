using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class SecurityPatrol
    {
        /// <summary>
        /// They start from a checkpoint and go in opposite direction for greater coverage.
        /// Isha starts with speed U metre/second and Suhana starts with speed V metre/second. 
        /// They both have a walkie-talkie, operating for maximum distance of X metres. How long will they be able to communicate ?
        /// </summary>
        void TwoGirls()
        {
            //reading no of test cases
            int cases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                //reading the speed of both girls and walikie talkie Range
                string[] U = Console.ReadLine().Split(' ');
                double[] V = Array.ConvertAll(U, double.Parse);

                double A = V[2]/(V[0] + V[1]);
                Console.WriteLine(A);
            }
        }
        //static void Main(string[] args)
        //{
        //    SecurityPatrol call = new SecurityPatrol();
        //    call.TwoGirls();
        //}
    }
}
