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
            string[] s = Console.ReadLine().Split(' ');
            int N = int.Parse(s[0]);
            int M = int.Parse(s[1]);
            int[] X = new int[M];
            int[] Y = new int[M];
            int[] Z = new int[M];
            Dictionary<int, int> D = new Dictionary<int, int>();
            UnionFind U = new UnionFind(N);
            for (int i = 0; i < M; i++)
            {
                s = Console.ReadLine().Split();
                X[i] = int.Parse(s[0]);
                Y[i] = int.Parse(s[1]);
                Z[i] = int.Parse(s[2]);
                U.Unite(X[i] - 1, Y[i] - 1);
            }
            int res = 0;
            for (int i = 0; i < N; i++)
            {
                if (!D.Keys.Contains(U.Root(i)))
                {
                    D[U.Root(i)] = 1;
                    res++;
                }
            }
            Console.WriteLine(res);
        }
    }
}