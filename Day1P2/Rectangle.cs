using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1P2
{
    internal class Rectangle : IColor, IShape
    {
        public double Width {  get; set; }
        public double Height { get; set; }
        public string ColorName { get; set; }

        public Rectangle( double width, double height)
        {
            Width = width;
            Height = height;
        }

        public Rectangle(string colorName)
        {
            ColorName = colorName;

        }
        public double CalculateArea()
        {
            return Width * Height;
        }

        public double CalculatePerimeter()
        {
           return 2*(Width + Height);
        }

        public string GetColor()
        {
            return ColorName;
        }
    }
}
