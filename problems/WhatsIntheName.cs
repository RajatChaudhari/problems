using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace problems
{
    public class WhatsIntheName
    {
        public void CallName()
        {
            int cases = Convert.ToInt32(Console.ReadLine());
            List<string> names = new List<string>();
            //if (cases >= 1 && cases <= 100)
            //{ 
                for (int i = 0; i < cases; i++)
                {
                    string name = Console.ReadLine();
                    names.Add(name);
                }
                for (int i = 0; i < names.Count; i++)
                {
                    string[] s = names[i].Split(' ');

                    if (s.Length == 1)
                    {
                        Console.WriteLine(s[0].Substring(0, 1).ToUpper() + s[0].Substring(1).ToLower());
                    }

                    if (s.Length == 2)
                    {
                        Console.WriteLine(s[0].Substring(0, 1).ToUpper() + "." + " " + s[1].Substring(0, 1).ToUpper() + s[1].Substring(1).ToLower());
                    }

                    if (s.Length == 3)
                    {
                        Console.WriteLine(s[0].Substring(0, 1).ToUpper() + "." + " " + s[1].Substring(0, 1).ToUpper() + "." + " " + s[2].Substring(0, 1).ToUpper() + s[2].Substring(1).ToLower());
                    }
                    
                    
                }
        //}
        }
        //static void Main(string[] args)
        //{
        //    WhatsIntheName w = new WhatsIntheName();
        //    w.CallName();
        //    Console.Read();
        //}
    } 
}
