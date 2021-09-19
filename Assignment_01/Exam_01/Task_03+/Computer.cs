using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_
{
    public class Computer : Product
    {
        public override double CalculateDiscount(double discount)
        {
            var discountAmount = this.Price * discount/ 100;
            return discountAmount;
        }
    }
}
