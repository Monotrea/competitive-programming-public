using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int N = int.Parse(s[0]);
            int K = int.Parse(s[1]);
            long[,] td = new long[N, 2];
            long[] r = new long[K + 1];
            long[] sp = new long[K + 1];
            for (int i = 0; i < K + 1; i++)
            {
                sp[i] = 0;
            }
            for (int i = 0; i < N; i++)
            {
                string[] ss = Console.ReadLine().Split(' ');
                td[i, 0] = long.Parse(ss[0]);
                td[i, 1] = long.Parse(ss[1]);
            }
            r[0] = 0;
            for (int i = 1; i < K + 1; i++)
            {
                
            }
        }
    }
}