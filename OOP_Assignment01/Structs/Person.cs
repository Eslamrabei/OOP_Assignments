using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment01.Structs
{
    internal struct Person
    {
        public Person(string _Name, int _Age)
        {
            Name = _Name;
            Age = _Age;
        }
        public string Name;
        public int Age;
    }
}
