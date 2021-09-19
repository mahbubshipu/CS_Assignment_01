using System;

namespace Task_03_
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer c = new Computer();
            c.Price = 25000;
            var cDiscount = c.CalculateDiscount(15);
            Console.WriteLine("Discount on Computer:" + cDiscount + " Tk");

            Shoe s = new Shoe();
            s.Price = 10000;
            var sDiscount = s.CalculateDiscount(20);
            Console.WriteLine("Discount on Computer:" + sDiscount + " Tk");

        }
    }
}
