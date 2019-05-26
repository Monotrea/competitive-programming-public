using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ABC127
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int r = int.Parse(s[0]);
            int D = int.Parse(s[1]);
            int x = int.Parse(s[2]);
            
            for (int i = 0; i < 10; i++)
            {
                x =  r * x - D;
                Console.WriteLine(x);
            }
        }
    }
}