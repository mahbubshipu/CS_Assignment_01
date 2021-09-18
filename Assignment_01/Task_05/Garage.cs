using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodes.Core
{
   public class Garage
   {
        public int TotalVehicleCount { get; set; }
        public Garage(Vehicle v)
        {
            this.TotalVehicleCount++;
        }
        public void Add(Vehicle v)
        {
            this.TotalVehicleCount++;
        }
   }
}
