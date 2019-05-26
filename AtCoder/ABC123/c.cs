using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AtCoderABC123
{
    class Pa
    {
        public long c;
        public int pos;
        public Pa(long n, int p)
        {
            c = n;
            pos = p;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long[] p = new long[5];
            p[0] = long.Parse(Console.ReadLine());
            p[1] = long.Parse(Console.ReadLine());
            p[2] = long.Parse(Console.ReadLine());
            p[3] = long.Parse(Console.ReadLine());
            p[4] = long.Parse(Console.ReadLine());
            Pa[] pp = new Pa[5];
            for (int i = 0; i < 5; i++) pp[i] = new Pa(p[i], i);
            Pa[] ppsort = pp.OrderBy(x => x.c).ToArray();
            long ftime = (N % ppsort[0].c == 0)? N / ppsort[0].c: N / ppsort[0].c + 1;
            ftime += ppsort[0].pos;
            ftime += 4 - ppsort[0].pos;
            Console.WriteLine(ftime);
        }
    }
}