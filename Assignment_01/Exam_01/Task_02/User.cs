using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    public class User
    {
        public string Name { get; set; }
        public uint Age { get; set; }
        public uint Fees { get; internal set; }
        public uint Salary { get; internal set; }

        public User()
        {

        }
        public User(string name, uint age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
