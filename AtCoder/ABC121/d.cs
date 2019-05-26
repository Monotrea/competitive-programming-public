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
            long A = long.Parse(s[0]);
            long B = long.Parse(s[1]);
            long diff = B - A + 1;
            int len = Convert.ToString(B, 2).Length;
            string strA = Convert.ToString(A, 2).PadLeft(40, '0');
            string strB = Convert.ToString(B, 2).PadLeft(40, '0');
            char[] resstr = new char[40];
            for (int i = 39; i >= 0; i--)
            {
                if(strA[i] == '0' && strB[i] == '0')
                {
                    if (i >= (40 - len))
                    {
                        if ((diff % 2) == 0)
                        {
                            resstr[i] = '0';
                        }
                        else
                        {
                            resstr[i] = '1';
                        }
                    }
                    else
                    {
                        resstr[i] = '0';
                    }
                    
                }
                else if (strA[i] == '1' && strB[i] == '0')
                {
                    if ((diff % 2) == 0)
                    {
                        resstr[i] = '0';
                    }
                    else
                    {
                        if (i == 39)
                        {
                            resstr[i] = '1';
                        }
                        else
                        {
                            string strC = strA.Substring(i + 1, 39 - i);
                            long tmp = Convert.ToInt64(strC, 2);
                            long tmp2 = Convert.ToInt64(strA.Substring(i, 40 - i), 2);
                            tmp2 -= tmp;
                            tmp2 -= tmp;
                            if ((tmp2 % 2) == 0)
                            {
                                resstr[i] = '0';
                            }
                            else
                            {
                                resstr[i] = '1';
                            }
                        }
                    }
                }
                else if (strA[i] == '0' && strB[i] == '1')
                {
                    if ((diff % 2) == 0)
                    {
                        resstr[i] = '0';
                    }
                    else
                    {
                        if (i == 39)
                        {
                            resstr[i] = '1';
                        }
                        else
                        {
                            string strC = strB.Substring(i + 1, 39 - i);
                            long tmp = Convert.ToInt64(strC, 2) + 1;
                            if ((tmp % 2) == 0)
                            {
                                resstr[i] = '0';
                            }
                            else
                            {
                                resstr[i] = '1';
                            }
                        }
                    }
                }
                else if (strA[i] == '1' && strB[i] == '1')
                {
                    if ((diff % 2) == 0)
                    {
                        resstr[i] = '0';
                    }
                    else
                    {
                        resstr[i] = '1';
                    }
                }
            }
            long res = Convert.ToInt64(new string(resstr), 2);
            Console.WriteLine(res);
        }
    }
}