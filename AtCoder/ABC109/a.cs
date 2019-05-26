using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ABC109
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int A = int.Parse(s[0]);
            int B = int.Parse(s[1]);
            if ((A % 2 == 0) || (B % 2 == 0))
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
    }
}