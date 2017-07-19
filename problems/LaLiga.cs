using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    public class LaLiga
    {
        public void CallLaLiga()
        {

            int cases = Convert.ToInt32(Console.ReadLine());
            List<string> winner = new List<string>();
            for (int i = 0; i < cases; i++)
            {
                Dictionary<string, int> teams = new Dictionary<string, int>();
                string[] team1 = Console.ReadLine().Split(' ');
                string[] team2 = Console.ReadLine().Split(' ');
                string[] team3 = Console.ReadLine().Split(' ');
                string[] team4 = Console.ReadLine().Split(' ');
                teams.Add(team1[0].ToUpper(), int.Parse(team1[1]));
                teams.Add(team2[0].ToUpper(), int.Parse(team2[1]));
                teams.Add(team3[0].ToUpper(), int.Parse(team3[1]));
                teams.Add(team4[0].ToUpper(), int.Parse(team4[1]));
                if (teams["REALMADRID"] < teams["MALAGA"])
                {
                    if (teams["BARCELONA"] > teams["EIBAR"])
                    {
                        winner.Add("Barcelona");
                    }
                    else
                    {
                        winner.Add("RealMadrid");
                    }
                }
                else
                {
                    winner.Add("RealMadrid");
                }

            }
            foreach (string a in winner)
            {
                Console.WriteLine(a);
            }
        }

        public static void Main(string[] args)
        {
            LaLiga la = new LaLiga();
            la.CallLaLiga();
            Console.ReadLine();
        }
    }
}
