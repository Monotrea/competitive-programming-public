using System;
using System.Linq;
using System.Collections.Generic;

namespace ExaWiz
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int A = int.Parse(s[0]);
            int B = int.Parse(s[1]);
            int C = int.Parse(s[2]);
            if (A == B && B == C && C == A)
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