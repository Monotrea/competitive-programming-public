using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] d = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        Array.Sort(d);
        int idx = N / 2;
        int num1 = d[idx - 1];
        int num2 = d[idx];
        Console.WriteLine(num2 - num1);
    }
}