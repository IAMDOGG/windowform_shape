using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_shape
{
    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(string name, int sides, double length, double width)
        {
            base.Name = name;
            base.Sides = sides;
            this.Length = length;
            this.Width = width;
        }

        public Rectangle()
        {

        }

        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }

        public override double ComputeArea()
        {
            return Length * Width;
        }

        public override double ComputePerimeter()
        {
            return 2 * this.length + 2 * this.width;
        }

        public override string ToString()
        {
            return "\nName: " + base.Name +
                   "\nSides: " + base.Sides +
                   "\nLength: " + this.Length +
                   "\nWidth: " + this.Width +
                   "\nArea: " + this.ComputeArea() +
                   "\nPerimeter: " + this.ComputePerimeter();
        }
    }
}
