using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ABC126
{
    public class UnionFind
    {
        int[] par;
        int[] size;

        public UnionFind(int N)
        {
            par = new int[N];
            size = new int[N];
            for (int i = 0; i < N; i++)
            {
                par[i] = i;
                size[i] = 1;
            }
        }

        public int Root(int x)
        {
            if (par[x] == x) return x;
            return par[x] = Root(par[x]);
        }

        public void Unite(int x, int y)
        {
            int rootX = Root(x);
            int rootY = Root(y);
            if (rootX == rootY) return;
            par[rootX] = rootY;
            size[rootY] += size[rootX];
        }

        public bool Same(int x, int y)
        {
            int rootX = Root(x);
            int rootY = Root(y);
            return rootX == rootY;
        }

        public int Size(int x)
        {
            return size[Root(x)];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int now = 1;
            int[] u = new int[N - 1];
            int[] v = new int[N - 1];
            long[] w = new long[N - 1];
            UnionFind U = new UnionFind(N);
            Dictionary<int, int> D = new Dictionary<int, int>();
            for (int i = 0; i < N - 1; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                u[i] = int.Parse(s[0]);
                v[i] = int.Parse(s[1]);
                w[i] = long.Parse(s[2]);
                if (w[i] % 2 == 0)
                {
                    U.Unite(u[i] - 1, v[i] - 1);
                }
            }
            for (int i = 0; i < N; i++)
            {
                if (!D.Keys.Contains(U.Root(i)))
                {
                    D[U.Root(i)] = now;
                    now = -now; 
                }
                if (D[U.Root(i)] == 1)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine("1");
                }
            }
        }
    }
}