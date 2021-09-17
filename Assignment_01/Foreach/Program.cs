using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = "123,343,45,45,47,23,58,42,96";
            var realNumbers = numbers.Split(',');
            int sum = 0;
            foreach(var number in realNumbers)
            {
                sum = sum + Convert.ToInt32(number);
            }
            Console.WriteLine(sum);
        }
    }
}
