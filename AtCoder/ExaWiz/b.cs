using System;
using System.Linq;
using System.Collections.Generic;

namespace ExaWiz
{
    class Program
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int c = s.Count(x => x == 'R');
            Console.WriteLine((c > (N - c))? "Yes":"No");
        }
    }
}