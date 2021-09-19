using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_
{
    public abstract class Product
    {
        public double Price { get; set; }
        public abstract double CalculateDiscount(double discount);
    }
}
