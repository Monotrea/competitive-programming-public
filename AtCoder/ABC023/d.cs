using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ABC023
{
    class Balloon: IComparable
    {
        public long H;
        public long S;
        public long D;
        public Balloon(long H, long S, long D)
        {
            this.H = H;
            this.S = S;
            this.D = D;
        }

        public int CompareTo(object obj)
        {
            Balloon i = obj as Balloon;
            return this.D.CompareTo(i.D);
        }
    }
    class Program
    {
        static bool Check(Balloon[] B, long val)
        {
            long[] h = new long[B.Length];
            for (int i = 0; i < B.Length; i++)
            {
                if (val < B[i].H) return false;
                h[i] = (val - B[i].H) / B[i].S;
            }
            Array.Sort(h);
            for (int i = 0; i < B.Length; i++)
            {
                if (h[i] < i) return false;
            }
            return true;
        }

        static long BinarySearch(Balloon[] B, long left, long right)
        {
            while (left < right)
            {
                long mid = (left + right) / 2;
                bool f = Check(B, mid);
                if (f)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }

        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            Balloon[] B = new Balloon[N];
            long m = 0;
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                long H = long.Parse(s[0]);
                long S = long.Parse(s[1]);
                long D = H + (N - 1) * S;
                m = Math.Max(m, D);
                B[i] = new Balloon(H, S, D);
            }
            // Array.Sort(B);
            long res = BinarySearch(B, 1, m + 1);
            Console.WriteLine(res);
        }
    }
}