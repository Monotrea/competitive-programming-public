using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split(' ');
        int N = int.Parse(s[0]);
        int X = int.Parse(s[1]);
        int[] L = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int cnt = 1;
        int sum = 0;
        for (int i = 0; i < N; i++)
        {
            sum += L[i];
            if (sum > X) break;
            cnt++;
        }
        Console.WriteLine(cnt);
    }
}