using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string s1 = "";
            while (true)
            {
                s1 = Console.ReadLine().ToLower();
                string s2 = "";

                if (s1 == "end")
                {
                    break;
                }
                else
                {
                    for (int i = s1.Length - 1; i >= 0; i--)
                    {
                        char c = s1[i];
                        s2 += c.ToString();

                    }
                    if (s1 == s2)
                    {
                        Console.WriteLine("Palindrome");
                    }
                    else
                    {
                        Console.WriteLine("Not Palindrome");
                    }
                }
            }
        }
    }
}
