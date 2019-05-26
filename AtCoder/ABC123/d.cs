using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AtCoderABC123
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int X = int.Parse(s[0]);
            int Y = int.Parse(s[1]);
            int Z = int.Parse(s[2]);
            int K = int.Parse(s[3]);
            long[] A = new long[X];
            long[] B = new long[Y];
            long[] C = new long[Z];
            string[] s1 = Console.ReadLine().Split(' ');
            string[] s2 = Console.ReadLine().Split(' ');
            string[] s3 = Console.ReadLine().Split(' ');
            for (int i = 0; i < X; i++)
            {
                A[i] = long.Parse(s1[i]);
            }
            for (int i = 0; i < Y; i++)
            {
                B[i] = long.Parse(s2[i]);
            }
            for (int i = 0; i < Z; i++)
            {
                C[i] = long.Parse(s3[i]);
            }
            long[] D = new long[X * Y];
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    D[i * Y + j] = A[i] + B[j];
                }
            }
            Array.Sort(D);
            int k = (X * Y < K)? X * Y: K;
            long[] newD = new long[k];
            for (int i = 0 ; i < k; i++) newD[i] = D[X * Y - 1 - i];
            long[] D2 = new long[k * Z];
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < Z; j++)
                {
                    D2[i * Z + j] = newD[i] + C[j];
                }
            }
            Array.Sort(D2);
            for (int i = k * Z - 1; i >= k * Z - K; i--) Console.WriteLine(D2[i]);
        }
    }
}