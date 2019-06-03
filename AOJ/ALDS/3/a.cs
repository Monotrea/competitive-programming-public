using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split(' ');
        Stack<long> stack = new Stack<long>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == "+")
            {
                long b = stack.Pop();
                long a = stack.Pop();
                stack.Push(a + b);
            }
            else if (s[i] == "-")
            {
                long b = stack.Pop();
                long a = stack.Pop();
                stack.Push(a - b);
            }
            else if (s[i] == "*")
            {
                long b = stack.Pop();
                long a = stack.Pop();
                stack.Push(a * b);
            }
            else
            {
                stack.Push(long.Parse(s[i]));
            }
        }
        Console.WriteLine(stack.Pop());
    }
}