using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyCodes.Core
{
    public class Vehicle
    {
        public string BrandName { get; set;}
        public string Model { get; set; }
        public Vehicle()
        {

        }
        public Vehicle(string brandname, string model)
        {
            this.BrandName = brandname;
            this.Model = model;
        }
    }
}
