using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split(' ');
        long W = long.Parse(s[0]);
        long H = long.Parse(s[1]);
        long x = long.Parse(s[2]);
        long y = long.Parse(s[3]);
        double area = (double)W / 2.0 * (double)H;
        bool flag = false;
        if ((x + x == W) && (y + y == H)) flag = true;
        int l = (flag)? 1: 0;
        Console.WriteLine("{0:f6} {1}", area, l);
    }
}