using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        private double _topAngle;
        private double _leftAngle;
        private double _rightAngle;
        private double _leftSide;
        private double _rightSide;
        private double _bottomSide;

        public double TopAngle
        {
            get
            {
                return _topAngle;
            }
            set
            {
                if (value > 0 && value < 180)
                {
                    _topAngle = value;
                }
            }
        }

        public double LeftSide
        {
            get
            {
                return _leftSide;
            }
            set
            {
                if (value > 0)
                    _leftSide = value;
            }
        }

        public double RightSide
        {
            get
            {
                return _rightSide;
            }
            set
            {
                if (value > 0)
                    _rightSide = value;
            }
        }

        public Triangle()
        {

        }

        public override double GetArea()
        {
            throw new NotImplementedException();
        }

        public override double GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
