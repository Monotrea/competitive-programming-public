using System;
using System.Linq;
using System.Collections.Generic;

namespace ExaWiz
{
    class Mass
    {
        public char s;
        public long gorem;
        public Mass(char c, long n)
        {
            s = c;
            gorem = n;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            long N = long.Parse(s[0]);
            long Q = long.Parse(s[1]);
            string ss = Console.ReadLine();
            List<Mass> m = new List<Mass>();
            long res = 0;
            for (int i = 0; i < N; i++)
            {
                m.Add(new Mass(ss[i], 1));
            }
            for (int i = 0; i < Q; i++)
            {
                s = Console.ReadLine().Split(' ');
                char t = s[0][0];
                char d = s[1][0];
                if (d == 'R')
                {
                    for (int j = (int)N - 1; j >= 0; j--)
                    {
                        if (m[j].s == t)
                        {
                            if (j != N - 1)
                            {
                                m[j + 1].gorem += m[j].gorem;
                                m[j].gorem = 0;
                            }
                            else
                            {
                                res += m[j].gorem;
                                m[j].gorem = 0;
                            }
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (m[j].s == t)
                        {
                            if (j != 0)
                            {
                                m[j - 1].gorem += m[j].gorem;
                                m[j].gorem = 0;
                            }
                            else
                            {
                                res += m[j].gorem;
                                m[j].gorem = 0;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(N - res);
        }
    }
}