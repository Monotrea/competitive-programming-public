/* 他の人のを若干参考にした */

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static bool Check(long[] W, int k, long P)
    {
        long p = P;
        int wi = 0;
        for (int i = 0; i < k; i++)
        {
            while (true)
            {
                if (W[wi] <= p)
                {
                    p -= W[wi];
                    wi++;
                    if (wi == W.Length) return true;
                }
                else
                {
                    p = P;
                    break;
                }
            }
        }
        return wi == W.Length;
    }
    static long BinarySearch(long[] W, int k)
    {
        long min = 0;
        long max = 1000000000;
        long mid = 0;
        while (min < max)
        {
            mid = (min + max) / 2;
            bool flag = Check(W, k, mid);
            if (flag)
            {
                max = mid;
            }
            else
            {
                min = mid + 1;
            }
        }
        return max;
    }
    public static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split(' ');
        int n = int.Parse(s[0]);
        int k = int.Parse(s[1]);
        long[] W = new long[n];
        for (int i = 0; i < n; i++) W[i] = long.Parse(Console.ReadLine());
        Console.WriteLine(BinarySearch(W, k));
    }
}