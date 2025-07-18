using OOP_Assignment04.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment04.Classes
{
    internal class Rectangle : IRectangle
    {
        decimal width;
        decimal height;
        public Rectangle(decimal _width , decimal _height)
        {
            width = _width;
            height = _height;
        }
        public decimal Area { get ; set ; }

        public void DisplayShapeInfo()
        {
            Area = width * height;
            Console.WriteLine($"The Rectangle of Circle : {string.Format("{0:0.00}",Area)}");

        }
    }
}
