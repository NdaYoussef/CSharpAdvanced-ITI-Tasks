using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1P2
{
    internal class Square : IColor, IShape
    {
        public double SideLength { get; set; }
        public string ColorName { get; set; }

        public Square(double sideLength)
        {
            SideLength = sideLength;
        }
        public Square(string colorName)
        {
            ColorName = colorName;

        }
        public double CalculateArea()
        {
           return 2 * SideLength;   
        }

        public double CalculatePerimeter()
        {
            return 4* SideLength;
        }

        public string GetColor()
        {
            return ColorName;
        }
    }
}
