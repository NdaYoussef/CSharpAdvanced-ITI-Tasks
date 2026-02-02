using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1P2
{
    internal class Circle : IColor, IShape
    {

        public double Radious { get; set; }
        public string ColorName { get; set; }
        public Circle(string colorName)
        {
            ColorName = colorName;
        }

        public Circle(double radious)
        {
            Radious = radious;

        }
        public double CalculateArea()
        {
            return Math.PI * Radious * Radious;
        }
        public double CalculatePerimeter()
        {
            return Math.PI * 2 * Radious;
        }

        public string GetColor()
        {
            return ColorName;
        }
    }
}
