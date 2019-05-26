using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AtCoder124
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int[] ss = new int[2];
            ss[0] = int.Parse(s[0]);
            ss[1] = int.Parse(s[1]);
            ss = ss.OrderByDescending(x => x).ToArray();
            int res = 0;
            res += ss[0];
            ss[0]--;
            ss = ss.OrderByDescending(x => x).ToArray();
            res += ss[0];
            Console.WriteLine(res);
        }
    }
}