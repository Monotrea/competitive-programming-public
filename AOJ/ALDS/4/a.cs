using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static int LinearSearch(List<long> a, long key)
    {
        int i = 0;
        a.Add(key);
        while (a[i] != key) i++;
        a.RemoveAt(a.Count - 1);
        if (i == a.Count) return -1;
        return i;
    }

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<long> ns = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToList();
        int q = int.Parse(Console.ReadLine());
        List<long> qs = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToList();
        int res = 0;
        for (int i = 0; i < qs.Count; i++) res = (LinearSearch(ns, qs[i]) != -1)? res + 1: res;
        Console.WriteLine(res);
    }
}