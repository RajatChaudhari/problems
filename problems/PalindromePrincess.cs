using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    /// <summary>
    /// Solved
    /// </summary>
    class PalindromePrincess
    {
        //public static void Main(string[] args)
        //{
        //    Mehtod();
        //}
        static void Mehtod()
        {
            int cases = Convert.ToInt32(Console.ReadLine());

            for (long i = 0; i < cases; i++)
            {
                bool isPalin = false;
                char[] s = Console.ReadLine().Trim().ToCharArray();
                if (s.Length <= 1)
                {
                    isPalin = false;
                }
                else if (s.Length > 1 && s.Length < 3)
                {
                    if (s[0] == s[1])
                    {
                        isPalin = true;
                    }
                    else
                    {
                        isPalin = false;
                    }
                }
                else
                {
                    for (long j = 1; j < s.Length - 1; j++)
                    {
                        if (s[j - 1] == s[j + 1] || s[j] == s[j + 1] || s[j - 1] == s[j])
                        {
                            isPalin = true;
                            break;
                        }
                    }
                }

                if (isPalin)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            //Console.ReadLine();
        }
    }
}
