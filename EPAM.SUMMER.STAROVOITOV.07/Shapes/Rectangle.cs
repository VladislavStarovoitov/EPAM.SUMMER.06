using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : Shape
    {
        private double _height;
        private double _width;

        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value > 0)
                    _height = value;
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                    _width = value;
            }
        }

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public override double GetArea()
        {
            return Height * Width;
        }

        public override double GetPerimeter()
        {
            return 2 * (Height + Width);
        }
    }
}
