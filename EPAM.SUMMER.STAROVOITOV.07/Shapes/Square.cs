using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Shape
    {
        private double _size;

        public double Size
        {
            get
            {
                return _size;
            }
            set
            {
                if (value > 0)
                    _size = value;
            }
        }

        public Square(double sideSize)
        {
            Size = sideSize;
        }

        public override double GetArea()
        {
            return Size * Size;
        }

        public override double GetPerimeter()
        {
            return 4 * Size;
        }
    }
}
