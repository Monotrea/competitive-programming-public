using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ABC125
{
    class Program
    {
        static long GCD(long a, long b)
        {
            return (a < b)? GCD(b, a):
                   (a == 0)? b:
                   (b == 0)? a:
                   (a % b == 0)? b: GCD(b, a % b);
        }
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long[] A = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            long[] L = new long[N + 1];
            long[] R = new long[N + 1];
            long[] res = new long[N];
            L[0] = 0; R[N] = 0;
            for (int i = 1; i <= N; i++)
            {
                L[i] = GCD(L[i - 1], A[i - 1]);
                R[N - i] = GCD(R[N - i + 1], A[N - i]);
            }
            for (int i = 0; i < N; i++) res[i] = GCD(L[i], R[i + 1]);
            Array.Sort(res);
            Console.WriteLine(res[N - 1]); 
        }
    }
}