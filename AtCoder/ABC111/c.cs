using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AtCoderABC111
{
    class Pa
    {
        public int v;
        public int count;
        public Pa(int a)
        {
            v = a;
            count = 0;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Pa[] v_odd = new Pa[100001];
            Pa[] v_even = new Pa[100001];
            for (int i = 0; i < 100001; i++)
            {
                v_odd[i] = new Pa(i);
                v_even[i] = new Pa(i);
            }
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    v_even[int.Parse(s[i])].count++;
                }
                else
                {
                    v_odd[int.Parse(s[i])].count++;
                }
            }
            List<Pa> sorted_odd = v_odd.OrderByDescending(x => x.count).ToList();
            List<Pa> sorted_even = v_even.OrderByDescending(x => x.count).ToList();
            int odd_num = n / 2;
            int even_num = n - odd_num;
            Pa odd_first = sorted_odd[0];
            Pa odd_second = sorted_odd[1];
            Pa even_first = sorted_even[0];
            Pa even_second = sorted_even[1];
            int res_ff = odd_num + even_num - odd_first.count - even_first.count;
            int res_fs = odd_num + even_num - odd_first.count - even_second.count;
            int res_sf = odd_num + even_num - odd_second.count - even_first.count;
            if (odd_first.v != even_first.v)
            {
                Console.WriteLine(res_ff);
            }
            else
            {
                Console.WriteLine((res_fs > res_sf)? res_sf: res_fs);
            }
        }
    }
}