using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using static System.Console;
using static System.Math;

namespace AtCoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new Program().Solve(new ConsoleInput(Console.In, ' '));
        }

        public void Solve(ConsoleInput cin)
        {
            int N, M;
            N = cin.ReadInt;
            M = cin.ReadInt;
            int[] res =  new int[M];
            for (int i = 0; i < M; i++)
            {
                res[i] = 1;
            }
            for (int i = 0 ; i < N; i++)
            {
                int K = cin.ReadInt;
                int [] nowres = new int[M];
                for (int j = 0; j < M; j++)
                {
                    nowres[j] = 0;
                }
                for (int j = 0; j < K; j++)
                {
                    int A = cin.ReadInt;
                    nowres[A - 1] = 1;
                }
                for (int j = 0; j < M; j++)
                {
                    if (res[j] == 1 && nowres[j] == 0) { res[j] = 0; }
                }
            }
            int finres = Array.FindAll(res, x => x == 1).Length;
            Console.WriteLine("{0}", finres);
        }
    }

    public class ConsoleInput
    {
        private readonly System.IO.TextReader _stream;
        private char _separator = ' ';
        private Queue<string> inputStream;
        public ConsoleInput(System.IO.TextReader stream, char separator = ' ')
        {
            this._separator = separator;
            this._stream = stream;
            inputStream = new Queue<string>();
        }
        public string Read
        {
            get
            {
                if (inputStream.Count != 0) { return inputStream.Dequeue(); }
                string[] tmp = _stream.ReadLine().Split(_separator);
                for (int i = 0; i < tmp.Length; i++)
                {
                    inputStream.Enqueue(tmp[i]);
                }
                return inputStream.Dequeue();
            }
        }
        public string ReadLine { get { return _stream.ReadLine(); } }
        public int ReadInt { get { return int.Parse(Read); } }
        public long ReadLong { get { return long.Parse(Read); } }
        public double ReadDouble { get { return double.Parse(Read); } }
        public string[] ReadStrArray(long N)
        {
            string[] ret = new string[N];
            for (long i = 0; i < N; i++)
            {
                ret[i] = Read;
            }
            return ret;
        }
        public int[] ReadIntArray(long N)
        {
            int[] ret = new int[N];
            for (int i = 0; i < N; i++)
            {
                ret[i] = ReadInt;
            }
            return ret;
        }
        public long[] ReadLongArray(long N)
        {
            long[] ret = new long[N];
            for (long i = 0; i < N; i++)
            {
                ret[i] = ReadLong;
            }
            return ret;
        }
    }
}