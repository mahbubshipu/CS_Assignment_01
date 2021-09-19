using System;

namespace Exam_01
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string s1 = Console.ReadLine();
                if (s1 == "end")
                {
                    break;
                }
                else
                {
                    //int sum = 0;
                    //for (int i = 0; i < s1.Length; i++)
                    //{
                    //    char c = s1[i];
                    //    sum += (int)c;
                    //}
                    var sum = 0;
                    foreach (var ch in s1)
                    {
                        sum += (int)ch;
                    }

                    Console.WriteLine(sum);
                }
            }
        }
    }
}
