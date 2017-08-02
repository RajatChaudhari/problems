using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class LostMax
    {
        void FindMax()
        { 
             int cases = Convert.ToInt32(Console.ReadLine());
             for (int i = 0; i < cases; i++)
             {
                 string[] input = Console.ReadLine().Trim().Split(' ');
                 long[] numbers = Array.ConvertAll(input,long.Parse);
                 List<long> intlist = new List<long>();
                 int count = numbers.Count();
                 for(int j=0; j<numbers.Length;j++)
                 {
                     intlist.Add(numbers[j]);
                 }
                 
                 intlist.Remove(intlist.First(m=>m.Equals(count-1)));
                 Console.WriteLine(intlist.Max());
             }
        }

        //public static void Main(string[] args)
        //{
        //    LostMax la = new LostMax();
        //    la.FindMax();
        //    Console.ReadLine();
        //}
    }
}
