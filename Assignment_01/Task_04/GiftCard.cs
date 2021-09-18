using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    public class GiftCard : Item
    {
        public override double GetDiscount(double originalPrice)
        {
            throw new NotImplementedException();
        }
        public GiftCard(double Price) : base(Price)
        {

        }
    }
}
