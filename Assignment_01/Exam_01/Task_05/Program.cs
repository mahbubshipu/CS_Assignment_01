using System;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Reading r = new Reading();
            r.Complete();

            Writting w = new Writting();
            w.Complete();

        }
    }
}
