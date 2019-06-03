using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static int cnt = 0;
    static void InsertionSort(int[] A, int g)
    {
        for (int i = g; i < A.Length; i++)
        {
            int v = A[i];
            int j;
            for (j = i - g; j >= 0 && A[j] > v; j -= g)
            {
                A[j + g] = A[j];
                cnt++;
            }
            A[j + g] = v;
        }
    }

    static int[] ShellSort(int[] A)
    {
        cnt = 0;
        int m = (int) Math.Sqrt(A.Length);
        m = Math.Min(100, m);
        int[] G = new int[m];
        for (int i = 0; i < m; i++)
        {
            G[i] = (m - i) * (m - i);
            InsertionSort(A, G[i]);
        }
        return G;
    }

    static void OutputArray(int[] A)
    {
        for (int i = 0; i < A.Length - 1; i++) Console.Write("{0} ", A[i]);
        Console.WriteLine(A[A.Length - 1]);
    }

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] A = new int[n];
        for (int i = 0; i < n; i++) A[i] = int.Parse(Console.ReadLine());
        int[] G = ShellSort(A);
        Console.WriteLine(G.Length);
        OutputArray(G);
        Console.WriteLine(cnt);
        for (int i = 0; i < n; i++) Console.WriteLine(A[i]);
    }
}