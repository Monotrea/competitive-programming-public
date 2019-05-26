using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AtCoderABC111
{
    class Program
    {
        static string Cal(char i, char j)
        {
            return (i == '1' && j == '1') ? "R":
                   (i == '1' && j == '0') ? "U":
                   (i == '0' && j == '1') ? "D": "L";
        }
        static long pow(long i, long j)
        {
            return (j > 0)? i * pow(i, j - 1) : 1;
        }

        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long two31 = pow(2, 31);
            long[,] a = new long[N, 2];
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                a[i, 0] = long.Parse(s[0]);
                a[i, 1] = long.Parse(s[1]);
            }
            long mod = Math.Abs(a[0, 0] + a[0, 1]) % 2;
            for (int i = 1; i < N; i++)
            {
                if (Math.Abs(a[i, 0] + a[i, 1]) % 2 != mod)
                {
                    Console.WriteLine("-1");
                    return;
                }
            }

            if (mod == 0)
            {
                for (int i = 0; i < N; i++) a[i, 0]--;
            }

            if (mod == 0)
            {
                Console.WriteLine("32");
                Console.Write("1 ");
                long temp = 1;
                for (int i = 0; i < 30; i++)
                {
                    Console.Write("{0} ", temp);
                    temp *= 2;
                }
                Console.WriteLine(temp);
            }
            else
            {
                Console.WriteLine("31");
                long temp = 1;
                for (int i = 0; i < 30; i++)
                {
                    Console.Write("{0} ", temp);
                    temp *= 2;
                }
                Console.WriteLine(temp);
            }

            for (int i = 0; i < N; i++)
            {
                long x = a[i, 0], y = a[i, 1];
                string u = Convert.ToString((x + y + two31 - 1) / 2, 2).PadLeft(31, '0');
                string v = Convert.ToString((x - y + two31 - 1) / 2, 2).PadLeft(31, '0');

                string s = (mod == 0)? "R": "";

                for (int j = 30; j > -1; j--) s += Cal(u[j], v[j]);

                Console.WriteLine(s);
            }
        }
    }
}