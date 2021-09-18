using MyCodes.Core;
using System;


namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Bus("Nishan","200X");
            Vehicle t = new Truck();
            Garage g = new Garage(v);
            g.Add(v);
            Console.WriteLine($"Total VehicleCount{g.TotalVehicleCount}");
        }
    }
}

