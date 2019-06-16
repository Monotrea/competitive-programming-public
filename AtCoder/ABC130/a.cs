using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        Console.WriteLine((a[0] < a[1])? "0": "10");
    }
}