using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static int Partition(int[] A, int p, int r)
    {
        int x = A[r];
        int i = p - 1;
        int temp = 0;
        for (int j = p; j < r; j++)
        {
            if (A[j] <= x)
            {
                i++;
                temp = A[i];
                A[i] = A[j];
                A[j] = temp;
            }
        }
        i++;
        temp = A[i];
        A[i] = A[r];
        A[r] = temp;
        return i;
    }
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int m = Partition(A, 0, n - 1);
        for (int i = 0; i < m; i++) Console.Write("{0} ", A[i]);
        Console.Write("[{0}] ", A[m]);
        for (int i = m + 1; i < n - 1; i++) Console.Write("{0} ", A[i]);
        Console.WriteLine(A[n - 1]);
    }
}