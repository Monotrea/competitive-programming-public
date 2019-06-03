using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Swap(int[] A, int from, int to)
    {
        int temp = A[from];
        A[from] = A[to];
        A[to] = temp;
    }
    static int SelectionSort(int[] A)
    {
        int swapnum = 0;
        for (int i = 0; i < A.Length; i++)
        {
            int minidx = i;
            for (int j = i; j < A.Length; j++) minidx = (A[j] < A[minidx])? j: minidx;
            Swap(A, i, minidx);
            swapnum = (minidx != i)? swapnum + 1: swapnum;
        }
        return swapnum;
    }

    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] A = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        int res = SelectionSort(A);
        for (int i = 0; i < N - 1; i++) Console.Write("{0} ", A[i]);
        Console.WriteLine(A[N - 1]);
        Console.WriteLine(res);
    }
}