using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class GreedyC
    {
        public void Greedy()
        {
            int cases =Convert.ToInt32( Console.ReadLine());

            for(int i=0;i<cases;i++)
            {
                string[] numbers = Console.ReadLine().Trim().Split(' ');
                int Candidates = Convert.ToInt32(numbers[0]);
                int Companies = Convert.ToInt32(numbers[1]);
                string[] minsal = Console.ReadLine().Trim().Split(' ');
                int[] minimumSalaries = Array.ConvertAll(minsal, int.Parse);
                int[, ] jobOffers = new int[Companies, 2];
                int candidatesHired=0;
                int[,] companyAccepts = new int[Candidates, Companies];
                int[,] candidateAccepts=new int[Candidates,Companies];
                for(int m=0;m<Companies;m++)
                {
                    string[] offers = Console.ReadLine().Trim().Split(' ');
                    jobOffers[m,0]= Convert.ToInt32(offers[0]);
                    jobOffers[m, 1] = Convert.ToInt32(offers[1]);                    
                }
                for (int n = 0; n < Candidates; n++)
                {
                    string input =Console.ReadLine().Trim();
                    for (int m = 0; m < Companies; m++)
                    {
                        companyAccepts[n, m] = int.Parse(input[m].ToString());
                    }
                }
                for (int m = 0; m < Companies; m++)
                {
                    Console.WriteLine("Company "+m+" ");
                    for (int n = 0; n < Candidates; n++)
                    {
                        Console.Write("Candidate "+n+" ");
                        if (companyAccepts[n, m] == 1)
                        {
                            Console.WriteLine("company one "+m+" candidate one "+n+" ");
                            if (jobOffers[m, 0] >= minimumSalaries[n] && candidatesHired < jobOffers[m,1])
                            {
                                Console.Write("jobofferSAL " + jobOffers[m, 0] + " jobofferSEL " + jobOffers[m, 1]);
                                candidateAccepts[n,m] = 1;
                                candidatesHired++;
                                
                            }
                        }
                    }
                }
                Console.WriteLine("*********");
                Console.WriteLine(candidatesHired);
            }
        }
        //public static void Main()
        //{
        //    GreedyC CallGreedy = new GreedyC();
        //    CallGreedy.Greedy();
        //    Console.ReadLine();
        //}
    }
}
