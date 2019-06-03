using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());
        long[] a = new long[n];
        for (long i = 0; i < n; i++) a[i] = long.Parse(Console.ReadLine());
        long res = a[1] - a[0];
        long minv = Math.Min(a[0], a[1]);
        for (int i = 2; i < n; i++)
        {
            res = Math.Max(res, a[i] - minv);
            minv = Math.Min(minv, a[i]);
        }
        Console.WriteLine(res);
    }
}