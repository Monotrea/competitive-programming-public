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
                   (a % b == 0)? b:
                                 GCD(b, a % b);
        }

        static long Search(long[] A, int N, int idx)
        {
            int residx = idx;
            long resmin = A[idx];
            for (int i = 0; i < N; i++)
            {
                if (resmin > GCD(A[i], A[idx]))
                {
                    resmin = GCD(A[i], A[idx]);
                    residx = i;
                }
            }
            long res = A[idx];
            for (int i = 0; i < N; i++)
            {
                if (i == residx) continue;
                res = GCD(res, A[i]);
            }
            return res;
        }

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long[] A = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).OrderByDescending(x => x).ToArray();
            
            long res = Search(A, N, 0);
            long res2 = Search(A, N, 2);
            long res3 = A[0];
            for (int i = 0; i < N; i++)
                res3 = GCD(res3, A[i]);
            if (N == 2)
            {
                Console.WriteLine((A[0] < A[1])? A[1]: A[0]);
            }
            else
            {
                Console.WriteLine(Math.Max(Math.Max(res, res2), res3));
            }
        }
    }
}