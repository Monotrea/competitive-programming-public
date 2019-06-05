using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] ns = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        int q = int.Parse(Console.ReadLine());
        int[] qs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

        bool[,] res = new bool[n + 1, qs.Max() + 1];
        for (int i = 0; i <= n; i++) res[i, 0] = true;
        for (int i = 1; i <= qs.Max(); i++) res[n, i] = false;
        for (int i = n - 1; i >= 0; i--)
        {
            for (int j = 1; j < qs.Max() + 1; j++)
            {
                bool r = res[i + 1, j];
                r = (j - ns[i] >= 0)? (r || res[i + 1, j - ns[i]]): r;
                res[i, j] = r;
            }
        }
        for (int i = 0; i < q; i++) Console.WriteLine((res[0, qs[i]])? "yes": "no");
    }
}