using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ABC125
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int A = int.Parse(s[0]);
            int B = int.Parse(s[1]);
            int T = int.Parse(s[2]);
            Console.WriteLine((T / A) * B);
        }
    }
}