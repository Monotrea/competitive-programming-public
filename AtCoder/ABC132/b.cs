using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int res = 0;
        for (int i = 1; i < n - 1; i++)
        {
            int cnt = 0;
            if (p[i] < p[i + 1]) cnt++;
            if (p[i] < p[i - 1]) cnt++;
            if (cnt == 1) res++;
        }
        Console.WriteLine(res);
    }
}