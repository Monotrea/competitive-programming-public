using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void insertionSortStep(int[] A, int idx)
    {
        int v = A[idx];
        int i;
        for (i = idx - 1; i >= 0 && A[i] > v; i--) A[i + 1] = A[i];
        A[i + 1] = v;
    }
    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] A = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        for (int i = 0; i < N; i++)
        {
            insertionSortStep(A, i);
            for (int j = 0; j < N - 1; j++) Console.Write("{0} ", A[j]);
            Console.WriteLine(A[N - 1]);
        }
    }
}