using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ABC128
{
    class PP: IComparable<PP>
    {
        public string S;
        public int P;
        public int idx;
        public PP(string s, int p, int id)
        {
            S = s;
            P = p;
            idx = id;
        }
        public int CompareTo(PP p)
        {
            if (S.CompareTo(p.S) < 0)
            {
                return 1;
            }
            else if (S.CompareTo(p.S) == 0)
            {
                if (P > p.P)
                {
                    return 1;
                }
                else if (P == p.P)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            PP[] SP = new PP[N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                SP[i] = new PP(s[0], int.Parse(s[1]), i + 1);
            }

            Array.Sort(SP);
            Array.Reverse(SP);
            
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(SP[i].idx);
            }
        }
    }
}