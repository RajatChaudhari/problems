using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class Rough
    {


        //static void Main(string[] args)
        //{
             
        //}
        public void test2()
        {

            //Main
            //int T = int.Parse(Console.In.ReadLine());
            //for (int i = 0; i < T; i++)
            //{
            //    int age = int.Parse(Console.In.ReadLine());
            //    Rough p = new Rough(age);
            //    p.amIOld();
            //    for (int j = 0; j < 3; j++)
            //    {
            //        p.yearPasses();
            //    }
            //    p.amIOld();
            //    Console.WriteLine();
            //}



            //int age;
            //public Rough(int initialAge)
            //{
            //    // Add some more code to run some checks on initialAge
            //    if (initialAge < 0)
            //    {
            //        Console.WriteLine("Age is not valid, setting age to 0.");
            //        age = 0;
            //    }
            //    else
            //    {
            //        age = initialAge;
            //    }
            //}
            //public void amIOld()
            //{
            //    // Do some computations in here and print out the correct statement to the console 
            //    if (age < 13)
            //    {
            //        Console.WriteLine("You are young.");
            //    }
            //    else if (age >= 13 && age < 18)
            //    {
            //        Console.WriteLine("You are a teenager.");
            //    }
            //    else if (age >= 18)
            //    {
            //        Console.WriteLine("You are old.");
            //    }

            //}

            //public void yearPasses()
            //{
            //    // Increment the age of the person in here
            //    age++;
            //}
        }

        public void test1()
        {
            double mealCost = Convert.ToDouble(Console.ReadLine());
            double tipPercent = Convert.ToDouble(Console.ReadLine());
            double taxPercent = Convert.ToDouble(Console.ReadLine());

            double tip = (tipPercent / 100) * mealCost;
            double tax = (taxPercent / 100) * mealCost;
            double total = (mealCost + tip + tax);
            Console.WriteLine("The total meal cost is " + Math.Round(total) + " dollars.");
            Console.ReadLine();
        }

        public void test3()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string name = string.Empty;
            Dictionary<string, Int64> phoneBook = new Dictionary<string, long>();
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(' ');
                phoneBook.Add(data[0], Convert.ToInt64(data[1]));
            }

            do
            {
                name = Console.ReadLine();
                if (name.Length > 0)
                {
                    if (phoneBook.ContainsKey(name))
                    {

                        Console.WriteLine(name + "=" + phoneBook[name]);
                    }
                    else
                    {
                        Console.WriteLine("Not found");
                    }

                }
            } while (name != null || name != "" || name != string.Empty);
        }

        public void test4()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            List<int> relist = new List<int>();
            int remainder = 0;
            int i = 0;
            while (n > 0)
            {
                remainder = n % 2;
                n = n / 2;
                relist.Add(remainder);
            }
            int[] binary = new int[relist.Count];
            binary = relist.ToArray();
            int count = 0, max = 0;

            for (int j = 0; j < binary.Length; j++)
            {
                if (binary[j] == 1)
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                max = Math.Max(max, count);
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
