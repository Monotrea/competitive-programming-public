/* なぜ通らないんだ・・・ */

using System;
using System.Collections;

class Program
{
    static void CountingSort(ushort[] A, ushort[] B, int n, int k)
    {
        int[] C = new int[k + 1];
        for (int i = 0; i < n; i++) C[A[i]]++;
        for (int i = 1; i <= k; i++) C[i] += C[i - 1];
        GC.Collect();
        for (int i = n - 1; i >= 0; i--)
        {
            B[C[A[i]] - 1] = A[i];
            C[A[i]]--;
        }
    }
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        ushort[] A = Array.ConvertAll(Console.ReadLine().Split(' '), ushort.Parse);
        ushort[] B = new ushort[n];
        CountingSort(A, B, n, 2000001);
        for (int i = 0; i < n - 1; i++) Console.Write("{0} ", B[i]);
        Console.WriteLine(B[n - 1]);
    }
}