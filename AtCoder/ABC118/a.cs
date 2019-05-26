using System;

namespace AtCoder.ABC118
{
    class A
    {
        public static void Solve()
        {
            int a, b;
            string[] str = Console.ReadLine().Split(' ');
            a = int.Parse(str[0]);
            b = int.Parse(str[1]);
            if ((b % a) == 0) { Console.WriteLine("{0}", a + b); }
            else { Console.WriteLine("{0}", b - a); }
        }
    }
}


namespace AtCoder
{
    class Program
    {
        public static void Main(string[] args)
        {
            ABC118.A.Solve();
        }
    }
}