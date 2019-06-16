using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Point
{
    public double x;
    public double y;
    public Point(double x = 0.0, double y = 0.0)
    {
        this.x = x;
        this.y = y;
    }
}

class Program
{
    static List<Point> Koch(int n, Point p1, Point p2)
    {
        List<Point> res = new List<Point>();
        res.Add(p1);
        KochSub(n, res, p1, p2);
        res.Add(p2);
        return res;
    }

    static void KochSub(int n, List<Point> plist, Point p1, Point p2)
    {
        if (n == 0) return;
        Point s = new Point((p1.x * 2.0 + p2.x) / 3.0, (p1.y * 2.0 + p2.y) / 3.0);
        Point t = new Point((p1.x + p2.x * 2.0) / 3.0, (p1.y + p2.y * 2.0) / 3.0);
        Point u = new Point();
        u.x = (t.x - s.x) * Math.Cos(Math.PI / 3.0) - (t.y - s.y) * Math.Sin(Math.PI / 3.0) + s.x;
        u.y = (t.x - s.x) * Math.Sin(Math.PI / 3.0) + (t.y - s.y) * Math.Cos(Math.PI / 3.0) + s.y;
        KochSub(n - 1, plist, p1, s);
        plist.Add(s);
        KochSub(n - 1, plist, s, u);
        plist.Add(u);
        KochSub(n - 1, plist, u, t);
        plist.Add(t);
        KochSub(n - 1, plist, t, p2);
    }

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Point> res = Koch(n, new Point(0.0, 0.0), new Point(100.0, 0.0));
        for (int i = 0; i < res.Count; i++) Console.WriteLine("{0:F8} {1:F8}", res[i].x, res[i].y);
    }
}