using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static bool isPrime(long a)
    {
        if (a <= 1) return false;
        for (long i = 2; i <= (long)Math.Sqrt(a); i++)
        {
            if (a % i == 0) return false;
        }
        return true;
    }
    public static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());
        long[] a = new long[n];
        for (long i = 0; i < n; i++) a[i] = long.Parse(Console.ReadLine());
        int res = 0;
        for (int i = 0; i < n; i++) res = (isPrime(a[i]))? res + 1: res;
        Console.WriteLine(res);
    }
}