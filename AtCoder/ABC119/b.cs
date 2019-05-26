using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder
{
    class Program
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double su = 0.0;
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                double x = double.Parse(s[0]);
                if (s[1] == "JPY")
                {
                    su += x;
                }
                else if (s[1] == "BTC")
                {
                    su += x * 380000.0;
                }
            }
            Console.WriteLine("{0:0.00000}", su);
        }
    }
}