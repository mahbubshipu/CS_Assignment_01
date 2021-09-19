using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    public class Student : User
    {
        public uint Fees { get;set; }
        public Student()
        {

        }
        public Student(string name, uint age) : base(name, age)
        {

        }
    }
}
