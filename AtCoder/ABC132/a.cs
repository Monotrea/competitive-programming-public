using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        string S = Console.ReadLine();
        Dictionary<char, int> d = new Dictionary<char, int>();
        for (int i = 0; i < 4; i++)
        {
            if (!d.Keys.Contains(S[i]))
            {
                d[S[i]] = 1;
            }
            else
            {
                d[S[i]]++;
            }
        }
        bool f = true;
        foreach (int a in d.Values)
        {
            if (a != 2) f = false;
        }
        Console.WriteLine((f)? "Yes": "No");
    }
}