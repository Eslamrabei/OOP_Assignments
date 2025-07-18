using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment04.Interfaces
{
    internal interface IShape
    {
        public decimal Area { get; set; }
        void DisplayShapeInfo();
    }
}
