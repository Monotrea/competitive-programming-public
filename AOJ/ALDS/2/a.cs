using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Swap(int[] ary, int i)
    {
        ary[i] = ary[i] ^ ary[i + 1];
        ary[i + 1] = ary[i] ^ ary[i + 1];
        ary[i] = ary[i] ^ ary[i + 1];
    }
    static int BubbleSort(int[] ary)
    {
        int swapnum = 0;
        bool swapped = true;
        while (swapped)
        {
            swapped = false;
            for (int i = 0; i < ary.Length - 1; i++)
            {
                if (ary[i] > ary[i + 1])
                {
                    swapnum++;
                    swapped = true;
                    Swap(ary, i);
                }             
            }
        }
        return swapnum;
    }
    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] A = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        int res = BubbleSort(A);
        for (int i = 0; i < N - 1; i++) Console.Write("{0} ", A[i]);
        Console.WriteLine(A[N - 1]);
        Console.WriteLine(res);
    }
}