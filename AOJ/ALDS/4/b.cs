using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static int BinarySearch(long[] a, long key)
    {
        int left = 0, right = a.Length;
        while (left < right)
        {
            int mid = (left + right) / 2;
            if (a[mid] == key) return mid;
            if (a[mid] < key) left = mid + 1;
            if (a[mid] > key) right = mid;
        }
        return -1;
    }
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        long[] ns = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
        int q = int.Parse(Console.ReadLine());
        long[] qs = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
        int res = 0;
        for (int i = 0; i < q; i++) res = (BinarySearch(ns, qs[i]) != -1)? res + 1: res;
        Console.WriteLine(res); 
    }
}