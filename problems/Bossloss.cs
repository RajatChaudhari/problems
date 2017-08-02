using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    /*
     * Boss has gone to the market to buy chocolates for his brother. 
     * There are total N shops in the market in a linear manner from 1 to N. 
     * Boss starts shopping from the 1st shop, then goes to the 2nd shop, then the 3rd and so on. 
     * The ith shop has i chocolates. 
     * At any shop Boss visits, he buys all the chocolates at that shop.
     * Now Boss wants to know the minimum number of shops he needs to visit starting from 
     * the 1st shop so that he can have at least M chocolates for his brother. 
     * Print -1 if he can't have M chocolates even after visiting all the N shops.
    Input
    The first line of input contains T, denoting the number of test cases. Next T lines will contain N and M as described above.
    Output
    For each test case, print the required answer in a new line.
     */
    class Bossloss
    {
        //
        
        void Chocolates4()
        {
            int cases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');
                long shops = input[0] == "" ? 0 : Convert.ToInt64(input[0]);
                long target = input[1] == "" ? 0 : Convert.ToInt64(input[1]);
                long totalSum= (shops*(shops+1))/2;
                long lo = 1, hi = shops;
                if (target > totalSum)
                {
                    Console.WriteLine(-1);
                }
                else
                {

                    while (lo <= hi)
                    {
                        long mid = lo + (hi - lo) / 2;
                        long midsum = mid * (mid + 1) / 2;

                        if (target == midsum)
                        {
                            Console.WriteLine(mid);
                            break;

                        }
                        if (midsum < target)
                        {
                            lo = mid + 1;

                            long midsum2 = (lo * (lo + 1)) / 2;
                            if (midsum2 > target)
                            {
                                Console.WriteLine(lo);
                                break;
                            }

                        }
                        else
                        {
                            hi = mid - 1;
                            long midsum2 = (hi * (hi + 1)) / 2;
                            if (target > midsum2)
                            {
                                Console.WriteLine((hi + 1));
                                break;
                            }

                        }
                    }
                }
            }
        }




        //static void Main(string[] args)
        //{
        //    Bossloss obj = new Bossloss();
        //    obj.Chocolates4();
        //    Console.ReadLine();
        //}
    }
}
