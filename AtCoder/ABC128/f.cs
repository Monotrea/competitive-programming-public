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
            int B = int.Parse(s[1]);
            
            Console.WriteLine((A <= 5)? 0:
                              (A < 13)? B / 2: B);
        }
    }
}