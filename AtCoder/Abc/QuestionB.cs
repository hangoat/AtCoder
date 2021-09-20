using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionB
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);


            string S1 = Console.ReadLine();
            string S2 = Console.ReadLine();
            string S3 = Console.ReadLine();

            string[] contestArray = new string[4] { "ABC", "ARC", "AGC", "AHC" };
            bool[] flagArray = new bool[4] { false, false, false, false };

            for (int i=0; i<4; i++)
            {
                if (S1 == contestArray[i])
                {
                    flagArray[i] = true;
                }
                if (S2 == contestArray[i])
                {
                    flagArray[i] = true;
                }
                if (S3 == contestArray[i])
                {
                    flagArray[i] = true;
                }
            }

            for (int i=0; i<4; i++)
            {
                if (!flagArray[i])
                {
                    Console.WriteLine(contestArray[i]);
                    Console.Out.Flush();
                    return;
                }
            }


        }
    }
}
