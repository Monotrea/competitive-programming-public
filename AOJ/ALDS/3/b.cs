using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Process
{
    public string name;
    public int time;
    public Process(string n, int t)
    {
        name = n;
        time = t;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split(' ');
        int n = int.Parse(s[0]);
        int q = int.Parse(s[1]);
        Queue<Process> queue = new Queue<Process>();
        for (int i = 0; i < n; i++)
        {
            s = Console.ReadLine().Split(' ');
            string name = s[0];
            int time = int.Parse(s[1]);
            queue.Enqueue(new Process(name, time));
        }
        int now = 0;
        while (queue.Count > 0)
        {
            Process proc = queue.Dequeue();
            int time = Math.Min(proc.time, q);
            now += time;
            proc.time -= time;
            if (proc.time == 0)
            {
                Console.WriteLine("{0} {1}", proc.name, now);
            }
            else
            {
                queue.Enqueue(proc);
            }
        }
    }
}