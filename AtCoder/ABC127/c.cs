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
            string[] s = Console.ReadLine().Split(' ');
            int N = int.Parse(s[0]);
            int M = int.Parse(s[1]);
            int[] L = new int[M];
            int[] R = new int[M];

            int Lres = 1;
            int Rres = N;

            for (int i = 0; i < M; i++)
            {
                s = Console.ReadLine().Split(' ');
                L[i] = int.Parse(s[0]);
                R[i] = int.Parse(s[1]);
                if (Lres < L[i])
                {
                    Lres = L[i];
                }
                if (R[i] < Rres)
                {
                    Rres = R[i];
                }
            }

            int res = (Lres <= Rres)? Rres - Lres + 1: 0;
            Console.WriteLine(res);
        }
    }
}