using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] S = Console.ReadLine().Split(' ');
            int N = int.Parse(S[0]);
            int M = int.Parse(S[1]);
            int C = int.Parse(S[2]);
            int[] B = new int[M];
            int[,] A = new int[N, M];

            string[] S2 = Console.ReadLine().Split(' ');
            for (int i = 0; i < M; i++)
            {
                B[i] = int.Parse(S2[i]);
            }

            int res = 0;
            C = -C;

            for (int i = 0; i < N; i++)
            {
                string[] S3 = Console.ReadLine().Split(' ');
                int tmp = 0;
                for (int j = 0; j < M; j++)
                {
                    A[i, j] = int.Parse(S3[j]);
                    tmp += A[i, j] * B[j];
                }
                if (tmp > C) res++;
            }
            
            Console.WriteLine("{0}", res);
        }
    }
}