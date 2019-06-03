using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class MyDictionary
{
    private string[] keys;
    private int[] value;
    public MyDictionary()
    {
        keys = new string[10000000];
        value = new int[10000000];
        for (int i = 0; i < 10000000; i++) value[i] = 0;
    }
    private int ConvertChar(char c)
    {
        return (c == 'A')? 1:
               (c == 'C')? 2:
               (c == 'G')? 3:
               (c == 'T')? 4: 0;
    }
    private int CalcHash(string str)
    {
        int res = 0;
        int temp = 1;
        for (int i = 0; i < str.Length; i++)
        {
            res += ConvertChar(str[i]) * temp;
            temp *= 5;
        }
        return res;
    }
    public void Insert(string str)
    {
        int idx = CalcHash(str);
        keys[idx] = str;
        value[idx] = 1;
    }
    public void Find(string str)
    {
        int idx = CalcHash(str);
        Console.WriteLine((value[idx] == 1)? "yes": "no");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        MyDictionary md = new MyDictionary();
        for (int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split(' ');
            if (s[0] == "insert")
            {
                md.Insert(s[1]);
            }
            if (s[0] == "find")
            {
                md.Find(s[1]);
            }
        }
    }
}