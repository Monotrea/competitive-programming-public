using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ABC109
{
    class Program
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<string, int> dict = new Dictionary<string, int>();
            bool flag = true;
            string s = Console.ReadLine();
            char firstchar = s[0];
            char lastchar = s[s.Length - 1];
            dict[s] = 1;
            for (int i = 1; i < N; i++)
            {
                s = Console.ReadLine();
                if (dict.Keys.Contains(s))
                {
                    flag = false;
                    break;
                }
                dict[s] = 1;
                firstchar = s[0];
                if (firstchar != lastchar)
                {
                    flag = false;
                    break;
                }
                lastchar = s[s.Length - 1];
            }
            Console.WriteLine((flag)? "Yes": "No");
        }
    }
}