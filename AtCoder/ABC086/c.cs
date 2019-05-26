using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AtCoderABC086
{
    class Program
    {
        public static void Main(string[] args)
        {
            string S = Console.ReadLine();
            string T = Console.ReadLine();
            bool flag = true;
            Dictionary<char, char> dict =  new Dictionary<char, char>();
            for (int i = 0; i < S.Length; i++)
            {
                if (dict.ContainsValue(T[i]) && !dict.ContainsKey(S[i]))
                {
                    flag = false;
                    break;
                }
                if (dict.ContainsValue(S[i]) && !dict.ContainsKey(T[i]))
                {
                    flag = false;
                    break;
                }
                dict[S[i]] = T[i];
                dict[T[i]] = S[i];
            }
            Console.WriteLine((flag)? "Yes": "No");
        }
    }
}