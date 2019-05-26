using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] S = Console.ReadLine().Split('/');
            int year = int.Parse(S[0]);
            int month = int.Parse(S[1]);
            int day = int.Parse(S[2]);
            if (year < 2019)
            {
                Console.WriteLine("Heisei");
            }
            else if (year == 2019 && month < 4)
            {
                Console.WriteLine("Heisei");
            }
            else if (year == 2019 && month == 4 && day < 31)
            {
                Console.WriteLine("Heisei");
            }
            else
            {
                Console.WriteLine("TBD");
            }
        }
    }
}