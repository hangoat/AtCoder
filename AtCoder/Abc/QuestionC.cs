using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionC
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            //// 整数の入力
            long N = long.Parse(Console.ReadLine());

            // 整数配列の入力
            var P = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

            int[] Q = new int[N];
            for (int i=0; i < N; i++)
            {
                int pi = P[i] - 1;
                Q[pi] = i + 1;
            }

            for (int i=0; i < N; i++)
            {
                Console.Write(Q[i]);
                if (i == N - 1)
                {
                    Console.Write("\n");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.Out.Flush();
        }
    }
}
