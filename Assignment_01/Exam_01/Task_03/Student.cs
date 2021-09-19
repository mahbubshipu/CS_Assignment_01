using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    public class Student : User
    {
        public int Fees { get; set; }
        public Student()
        {

        }
        public Student(String name, uint age) : base(name, age)
        {

        }
    }
}
