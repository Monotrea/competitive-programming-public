using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int N = int.Parse(s[0]);
            int A = int.Parse(s[1]);
            int B = int.Parse(s[2]);
            int C = int.Parse(s[3]);
            int[] resl = new int[3] {A, B, C};
            int[] l = new int[N];
            for (int i = 0; i < N; i++) { l[i] = int.Parse(Console.ReadLine()); }

            int[] newresl = resl.OrderByDescending(x => x).ToArray();
            int[] newl = l.OrderBy(x => x).ToArray();
            int res = 0;

            int ls = newl.Sum();
            List<int> ll = new List<int>();
            res += (newl.Length - 1) * 10;
            int count = 0;
            for (count = 0; count < newl.Length; count++)
            {
                if (ls <= newresl[0]) { break; }
                ls -= resl[count];
                res -= 10;
                ll.Add(resl[count]);
            }
            if (count > 0 && (newresl[0] - ls) > (ls + resl[count - 1] - newresl[0]))
            {
                ls += resl[count - 1];
                res += 10;
                ll.RemoveAt(ll.Count - 1);
            }
            res += Math.Abs(newresl[0] - ls);

            newl = ll.OrderBy(x => x).ToArray();
            ls = newl.Sum();
            ll = new List<int>();
            res += (newl.Length - 1) * 10;
            count = 0;
            for (count = 0; count < newl.Length; count++)
            {
                if (ls <= newresl[1]) { break; }
                ls -= resl[count];
                res -= 10;
                ll.Add(resl[count]);
            }
            if (count > 0 && (newresl[1] - ls) > (ls + resl[count - 1] - newresl[1]))
            {
                ls += resl[count - 1];
                res += 10;
                ll.RemoveAt(ll.Count - 1);
            }
            res += Math.Abs(newresl[1] - ls);

            newl = ll.OrderBy(x => x).ToArray();
            ls = newl.Sum();
            ll = new List<int>();
            res += (newl.Length - 1) * 10;
            count = 0;
            for (count = 0; count < newl.Length; count++)
            {
                if (ls <= newresl[2]) { break; }
                ls -= resl[count];
                res -= 10;
                ll.Add(resl[count]);
            }
            if (count > 0 && (newresl[2] - ls) > (ls + resl[count - 1] - newresl[2]))
            {
                ls += resl[count - 1];
                res += 10;
                ll.RemoveAt(ll.Count - 1);
            }
            res += Math.Abs(newresl[2] - ls);

            Console.WriteLine(res);
        }
    }
}