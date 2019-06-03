using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static long GCD(long a, long b)
    {
        return (a < b)? GCD(b, a):
               (a % b == 0)? b:
               GCD(b, a % b);
    }
    public static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split();
        long A = long.Parse(s[0]);
        long B = long.Parse(s[1]);
        Console.WriteLine(GCD(A, B));
    }
}