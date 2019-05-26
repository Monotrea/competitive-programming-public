using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ABC127
{
    class P
    {
        public int B;
        public long C;
        public P(int a, long b)
        {
            B = a;
            C = b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int N = int.Parse(s[0]);
            int M = int.Parse(s[1]);
            long[] A = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).OrderByDescending(x => x).ToArray();
            P[] BC = new P[M];

            for (int i = 0; i < M; i++)
            {
                s = Console.ReadLine().Split(' ');
                int B = int.Parse(s[0]);
                long C = long.Parse(s[1]);
                BC[i] = new P(B, C);
            }

            BC = BC.OrderByDescending(x => x.C).ToArray();

            long res = 0;
            int Acount = 0;
            int Bcount = 0;

            for (int i = 0; i < N; i++)
            {
                if (Acount < N && Bcount < M)
                {
                    if (A[Acount] < BC[Bcount].C)
                    {
                        res += BC[Bcount].C;
                        BC[Bcount].B--;
                        if (BC[Bcount].B == 0)
                        {
                            Bcount++;
                        }
                    }
                    else
                    {
                        res += A[Acount];
                        Acount++;
                    }
                }
                else if (Acount < N)
                {
                    res += A[Acount];
                    Acount++;
                }
                else if (Bcount < M)
                {
                    res += BC[Bcount].C;
                    BC[Bcount].B--;
                    if (BC[Bcount].B == 0)
                    {
                        Bcount++;
                    }
                }
            }

            Console.WriteLine(res);
        }
    }
}