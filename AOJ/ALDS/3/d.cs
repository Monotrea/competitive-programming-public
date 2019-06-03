/* 他の人の解答を参考にした */

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class WaterInfo
{
    public int area;
    public int startPosition;
    public WaterInfo(int a, int s)
    {
        area = a;
        startPosition = s;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();
        Stack<int> slopeinfo = new Stack<int>();
        Stack<WaterInfo> waterinfo = new Stack<WaterInfo>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '\\')
            {
                slopeinfo.Push(i);
            }
            if (s[i] == '/')
            {
                if (slopeinfo.Count == 0) continue;
                int startPosition = slopeinfo.Pop();
                int area = i - startPosition;
                while (waterinfo.Count > 0 && startPosition < waterinfo.Peek().startPosition)
                {
                    WaterInfo wi = waterinfo.Pop();
                    area += wi.area;
                }
                waterinfo.Push(new WaterInfo(area, startPosition));
            }
        }
        int[] areas = waterinfo.Select(x => x.area).Reverse().ToArray();
        if (areas.Length == 0)
        {
            Console.WriteLine("0");
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine(areas.Sum());
            Console.Write("{0} ", areas.Length);
            for (int i = 0; i < areas.Length - 1; i++) Console.Write("{0} ", areas[i]);
            Console.WriteLine(areas[areas.Length - 1]);
        }
    }
}