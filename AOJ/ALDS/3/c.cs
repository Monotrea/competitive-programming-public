using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        LinkedList<int> l = new LinkedList<int>();
        for (int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split(' ');
            if (s[0] == "insert")
            {
                l.AddFirst(int.Parse(s[1]));
            }
            else if (s[0] == "delete")
            {
                l.Remove(int.Parse(s[1]));
            }
            else if (s[0] == "deleteFirst")
            {
                l.RemoveFirst();
            }
            else if (s[0] == "deleteLast")
            {
                l.RemoveLast();
            }
        }
        int cnt = l.Count;
        for (int i = 0; i < cnt - 1; i++)
        {
            Console.Write("{0} ", l.First.Value);
            l.RemoveFirst();
        }
        Console.WriteLine(l.First.Value);
    }
}