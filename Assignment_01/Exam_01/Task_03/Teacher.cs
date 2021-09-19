using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    public class Teacher : User
    {
        public int Salary { get; set; }
        public Teacher()
        {

        }
        public Teacher(string name, uint age) : base(name, age)
        {

        }
    }
}
