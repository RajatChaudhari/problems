using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class HR_gs_BankAccounts
    {
        public void Method()
        {
            int cases = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<cases;i++)
            {
                
                string[] inputs = Console.ReadLine().Trim().Split(' ');
                int transactions = int.Parse(inputs[0]);
                int fee = int.Parse(inputs[1]);
                decimal percent = int.Parse(inputs[2]);
                int upfront = int.Parse(inputs[3]);
                string[] pymnt = Console.ReadLine().Trim().Split(' ');
                int[] payments = Array.ConvertAll(pymnt, int.Parse);
                decimal sum = 0;
                for(int j=0;j<transactions;j++)
                {
                    decimal pccal=((percent/100)*payments[j]);
                    sum += Math.Max(fee, pccal);
                }
                if(sum>upfront)
                {
                    Console.WriteLine("upfront");
                }
                else
                {
                    Console.WriteLine("fee");
                }
            }

        }

        //public static void Main(string[] args)
        //{
        //    HR_gs_BankAccounts obj = new HR_gs_BankAccounts();
        //    obj.Method();
        //    Console.ReadLine();
        //}
    }
}
