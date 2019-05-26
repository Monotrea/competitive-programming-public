using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ABC126
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            int first = int.Parse(S.Substring(0, 2));
            int second = int.Parse(S.Substring(2, 2));
            if (first == 0 && second > 12)
            {
                Console.WriteLine("NA");
            }
            else if (first > 12 && second == 0)
            {
                Console.WriteLine("NA");
            }
            else if (first == 0 && second == 0)
            {
                Console.WriteLine("NA");
            }
            else if (first <= 12 && second == 0)
            {
                Console.WriteLine("MMYY");
            }
            else if (first == 0 && second <= 12)
            {
                Console.WriteLine("YYMM");
            }
            else if (first > 12 && second <= 12)
            {
                Console.WriteLine("YYMM");
            }
            else if (first <= 12 && second > 12)
            {
                Console.WriteLine("MMYY");
            }
            else if (first <= 12 && second <= 12)
            {
                Console.WriteLine("AMBIGUOUS");
            }
            else
            {
                Console.WriteLine("NA");
            }
        }
    }
}