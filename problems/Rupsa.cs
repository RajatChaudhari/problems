using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    public class Rupsa
    {
        public static void solve(StreamReader reader, StreamWriter writer)
        {
            int tests = reader.ReadInt();
            while (tests-- > 0)
            {
                writer.Flush();
                int n = reader.ReadInt() + 1;
                var lst = new List<long>();
                while (n-- > 0)
                {
                    lst.Add(reader.ReadInt());
                }
                long res = 0;
                long run = 0;
                long modul = 1000000007;

                n = lst.Count - 1;
                var cur = new long[n];
                cur[0] = 1;
                for (int i = 1; i < n; ++i)
                {
                    cur[i] = (cur[i - 1] << 1) % modul;
                }
                cur[0] = 2;
                for (int i = 1; i <= n; ++i)
                {
                    run = (run + (lst[i - 1] * cur[i - 1]));// % modul) % modul;
                    res = (res << 1) % modul;
                    res = (res + (run * lst[i]));// % modul) % modul;
                }
                writer.WriteLine(res);
            }
        }
        public void CallRupsa()
        {
            using (var writer = new StreamWriter(Console.OpenStandardOutput()))
            {
                using (var reader = new StreamReader(
#if CODECHIEF_LOCAL
                    "input.txt"
#else
                    Console.OpenStandardInput()
#endif
                ))
                {
                    Rupsa.solve(reader, writer);
                }
            }

            Console.ReadLine();
        }
    }

    static class IOExtensions
    {
        public static string ReadString(this StreamReader reader)
        {
            return reader.ReadToken();
        }

        public static int ReadInt(this StreamReader reader)
        {
            return int.Parse(reader.ReadToken());
        }

        public static long ReadLong(this StreamReader reader)
        {
            return long.Parse(reader.ReadToken());
        }

        static Queue<string> buffer = new Queue<string>(100);

        static string ReadToken(this StreamReader reader)
        {
            while (buffer.Count == 0)
            {
                reader.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList().ForEach((t) =>
                {
                    buffer.Enqueue(t);
                });
            }
            return buffer.Dequeue();
        }
    }
}
