using OOP_Assignment04.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment04.Classes
{
    internal class Circle : ICircle
    {
        decimal raduis;
        public Circle(decimal _raduis)
        {
            raduis = _raduis;
        }
        public decimal Area { get ; set ; }

        public void DisplayShapeInfo()
        {
            Area = (decimal)Math.PI * (raduis * raduis);
            Console.WriteLine($"The Area of Circle : {string.Format("Price: {0:0.00}", Area)}");
        }
    }
}
