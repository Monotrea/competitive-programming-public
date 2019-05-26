using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AtCoderABC113
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            long H = int.Parse(s[0]);
            long W = int.Parse(s[1]);
            long K = int.Parse(s[2]);
            long[,] A = new long[H + 1, W];
            for (int i = 0; i < H + 1; i++)
            {
                for (int j = 0; j < W; j++)
                {
                    A[i, j] = 0;
                }
            }
            A[0, 0] = 1;
            for (int i = 1; i < H + 1; i++)
            {
                A[i, 0] += A[i - 1, 0] + A[i - 1, 1];
                for (int j = 1; j < W - 1; j++)
                {
                    A[i, j] += A[i - 1, j] + A[i - 1, j - 1] + A[i - 1, j + 1];
                }
                A[i, W - 1] += A[i - 1, W - 1] + A[i - 1, W - 2];
            }
            Console.WriteLine(A[H, K - 1]);
        }
    }
}