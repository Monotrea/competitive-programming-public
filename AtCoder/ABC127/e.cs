using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ABC126
{
    class Program
    {
        static void Main(string[] args)
        {
            int Q = int.Parse(Console.ReadLine());
            List<long> a;
            List<long> b;

            for (int i = 0; i < Q; i++)
            {
                string s = Console.ReadLine().Split(' ');
                int code = int.Parse(s[0]);
                if (code == 1)
                {
                    if (a.Count < 2)
                    {
                        a.Add(long.Parse(s[1]));
                        b.Add(long.Parse(s[2]));
                    }
                    else
                    {
                        if (a.Count > 2)
                        {
                            long x = a[1];
                            long res = 0;
                            for (int j = 0; j < a.Count; j++)
                            {
                                res += b[j] + Math.Abs(a[j] - x);
                            }
                            Console.WriteLine("{0} {1}", x, res);
                        }
                        else
                        {
                            long x = a[1];
                            long res = 0;
                            for (int j = 0; j < a.Count; j++)
                            {
                                res += b[j] + Math.Abs(a[j] - x);
                            }
                            Console.WriteLine("{0} {1}", x, res);
                        }
                    }
                }
            }
            
            Console.WriteLine(c);
        }
    }
}