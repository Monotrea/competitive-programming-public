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
            int[] ss = new int[3];
            ss[0] = int.Parse(s[0]);
            ss[1] = int.Parse(s[1]);
            ss[2] = int.Parse(s[2]);
            if (ss[0] < ss[1])
            {
                if (ss[0] < ss[2] && ss[2] < ss[1])
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            else
            {
                if (ss[1] < ss[2] && ss[2] < ss[0])
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}