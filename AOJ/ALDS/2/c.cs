using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Swap(string[] A, int from, int to)
    {
        string temp = A[from];
        A[from] = A[to];
        A[to] = temp;
    }

    static void BubbleSort(string[] ary)
    {
        bool swapped = true;
        while (swapped)
        {
            swapped = false;
            for (int i = 0; i < ary.Length - 1; i++)
            {
                if (ary[i].Substring(1, 1)[0] > ary[i + 1].Substring(1, 1)[0])
                {
                    swapped = true;
                    Swap(ary, i, i + 1);
                }             
            }
        }
    }

    static void SelectionSort(string[] A)
    {
        for (int i = 0; i < A.Length; i++)
        {
            int minidx = i;
            for (int j = i; j < A.Length; j++) minidx = (A[j].Substring(1, 1)[0] < A[minidx].Substring(1, 1)[0])? j: minidx;
            Swap(A, i, minidx);
        }
    }

    static bool isSame(string[] A, string[] B)
    {
        if (A.Length != B.Length) return false;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] != B[i]) return false;
        }
        return true;
    }

    static void OutputArray(string[] A)
    {
        for (int i = 0; i < A.Length - 1; i++) Console.Write("{0} ", A[i]);
        Console.WriteLine(A[A.Length - 1]);
    }

    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string[] A = Console.ReadLine().Split(' ');
        string[] B = new string[N];
        string[] C = new string[N];
        A.CopyTo(B, 0);
        A.CopyTo(C, 0);
        BubbleSort(B);
        SelectionSort(C);
        OutputArray(B);
        Console.WriteLine((isSame(B, B))? "Stable": "Not stable");
        OutputArray(C);
        Console.WriteLine((isSame(B, C))? "Stable": "Not stable");
    }
}