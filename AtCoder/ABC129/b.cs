using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] W = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int l = W[0];
        int r = W.Sum() - W[0];
        int res = Math.Abs(r - l);
        for (int i = 1; i < N; i++)
        {
            l += W[i];
            r -= W[i];
            res = Math.Min(res, Math.Abs(r - l));
        }
        Console.WriteLine(res);
    }
}