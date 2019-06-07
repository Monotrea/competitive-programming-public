using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Card
{
    public string s;
    public long val;
    public Card(string s, long val)
    {
        this.s = s;
        this.val = val;
    }
}

class Program
{
    static long INF = 1000000001;
    static void Merge(Card[] A, int left, int mid, int right)
    {
        int n1 = mid - left;
        int n2 = right - mid;
        Card[] B = new Card[n1 + 1];
        Card[] C = new Card[n2 + 1];
        for (int i = 0; i < n1; i++) B[i] = A[left + i];
        for (int i = 0; i < n2; i++) C[i] = A[mid + i];
        B[n1] = new Card("H", INF);
        C[n2] = new Card("H", INF);
        int f1 = 0, f2 = 0;
        for (int k = left; k < right; k++)
        {
            if (B[f1].val <= C[f2].val)
            {
                A[k] = B[f1];
                f1++;
            }
            else
            {
                A[k] = C[f2];
                f2++;
            }
        }
    }

    static void MergeSort(Card[] A, int left, int right)
    {
        if (left + 1 < right)
        {
            int mid = (left + right) / 2;
            MergeSort(A, left, mid);
            MergeSort(A, mid, right);
            Merge(A, left, mid, right);
        }
    }

    static int Partition(Card[] A, int p, int r)
    {
        Card x = A[r];
        int i = p - 1;
        Card temp = new Card("H", 0);
        for (int j = p; j < r; j++)
        {
            if (A[j].val <= x.val)
            {
                i++;
                temp = A[i];
                A[i] = A[j];
                A[j] = temp;
            }
        }
        i++;
        temp = A[i];
        A[i] = A[r];
        A[r] = temp;
        return i;
    }

    static void QuickSort(Card[] A, int p, int r)
    {
        if (p < r)
        {
            int q = Partition(A, p, r);
            QuickSort(A, p, q - 1);
            QuickSort(A, q + 1, r);
        }
    }

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Card[] A = new Card[n];
        Card[] B = new Card[n];
        for (int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split(' ');
            A[i] = new Card(s[0], long.Parse(s[1]));
            B[i] = new Card(s[0], long.Parse(s[1]));
        }
        MergeSort(A, 0, n);
        QuickSort(B, 0, n - 1);
        bool flag = true;
        for (int i = 0; i < n; i++) flag = flag && (A[i].s == B[i].s && A[i].val == B[i].val);
        Console.WriteLine((flag)? "Stable": "Not stable");
        for (int i = 0; i < n; i++) Console.WriteLine("{0} {1}", B[i].s, B[i].val);
    }
}