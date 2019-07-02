using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Vertex
{
    public int idx;
    public int steps;
    public List<int> nextVertex;
    public Vertex(int idx)
    {
        this.idx = idx;
        this.steps = -1;
        this.nextVertex = new List<int>();
    }
    public void AddVertex(int id)
    {
        this.nextVertex.Add(id);
    }
}

class Program
{
    static void CalcSteps(Vertex[] vts, int nowidx, int befstep, int steps, int T)
    {
        if (steps == 3)
        {
            if (vts[nowidx].steps == -1)
            {
                vts[nowidx].steps = befstep + 1;
            }
            else
            {
                vts[nowidx].steps = Math.Min(befstep + 1, vts[nowidx].steps);
            }
        }
        if (vts[nowidx].idx == T) return;
        foreach (int i in vts[nowidx].nextVertex)
        {
            if (steps == 3)
            {
                CalcSteps(vts, i, vts[nowidx].steps, 1, T);
            }
            else
            {
                CalcSteps(vts, i, befstep, steps++, T);
            }
        }   
    }

    public static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split(' ');
        int N = int.Parse(s[0]);
        int M = int.Parse(s[1]);
        int[] u = new int[M];
        int[] v = new int[M];
        Vertex[] verteces = new Vertex[N];
        for (int i = 0; i < N; i++) verteces[i] = new Vertex(i);
        for (int i = 0; i < M; i++)
        {
            s = Console.ReadLine().Split(' ');
            u[i] = int.Parse(s[0]) - 1;
            v[i] = int.Parse(s[1]) - 1;
            verteces[u[i]].AddVertex(v[i]);
        }
        s = Console.ReadLine().Split(' ');
        int S = int.Parse(s[0]);
        int T = int.Parse(s[1]);
        verteces[S].steps = 0;
        CalcSteps(verteces, S, 0, 0, T);
        Console.WriteLine(verteces[T].steps);
    }
}