/* ちょっと参考にしたものあり */

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static long INF = 1000000001;
    static long cnt = 0;
    static void Merge(long[] A, int left, int mid, int right)
    {
        int n1 = mid - left;
        int n2 = right - mid;
        long[] B = new long[n1 + 1];
        long[] C = new long[n2 + 1];
        for (int i = 0; i < n1; i++) B[i] = A[left + i];
        for (int i = 0; i < n2; i++) C[i] = A[mid + i];
        B[n1] = INF;
        C[n2] = INF;
        int f1 = 0, f2 = 0;
        for (int k = left; k < right; k++)
        {
            if (B[f1] <= C[f2])
            {
                A[k] = B[f1];
                f1++;
            }
            else
            {
                A[k] = C[f2];
                f2++;
                cnt += (n1 - f1);
            }
        }
    }

    static void MergeSort(long[] A, int left, int right)
    {
        if (left + 1 < right)
        {
            int mid = (left + right) / 2;
            MergeSort(A, left, mid);
            MergeSort(A, mid, right);
            Merge(A, left, mid, right);
        }
    }

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        long[] S = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
        MergeSort(S, 0, n);
        Console.WriteLine(cnt);
    }
}