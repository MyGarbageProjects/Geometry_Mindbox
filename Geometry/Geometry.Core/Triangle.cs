using Geometry.Core.Abstract;
using System;
using System.Linq;

namespace Geometry.Core
{
    public class Triangle : IFigure, IRightAngleable
    {
        private readonly double[] _sides = new double[3];

        public Triangle(double side1, double side2, double side3)
        {
            _sides[0] = side1;
            _sides[1] = side2;
            _sides[2] = side3;
        }

        #region props

        public double Side1
        {
            get => _sides[0];
            set => _sides[0] = value;
        }

        public double Side2
        {
            get => _sides[1];
            set => _sides[1] = value;
        }

        public double Side3
        {
            get => _sides[2];
            set => _sides[2] = value;
        }

        #endregion

        #region methods

        //<inheritdoc>
        public double Area()
        {
            double halfPerimeter = Perimeter() / 2;
            double composition = 1;
            foreach (var side in _sides) composition *= halfPerimeter - side;
            return Math.Sqrt(halfPerimeter * composition);
        }

        //<inheritdoc>
        public double Perimeter() => _sides.Sum();

        #endregion

        public bool IsRightAngle()
        {
            double max = _sides.Max();
            if (_sides.Count(s => s == max) > 1) return false;
            double sum = _sides.Where(s => s < max).Sum(s => Math.Pow(s, 2));
            return Math.Pow(max, 2) == sum;
        }
    }
}