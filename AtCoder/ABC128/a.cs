using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ABC128
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int A = int.Parse(s[0]);
            int P = int.Parse(s[1]);
            
            Console.WriteLine((A * 3 + P) / 2);
        }
    }
}