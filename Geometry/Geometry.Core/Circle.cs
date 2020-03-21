using Geometry.Core.Abstract;
using System;

namespace Geometry.Core
{
    public class Circle : IFigure
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Radius
        {
            get => _radius;
            set => _radius = value;
        }

        #region methods

        //<inheritdoc>
        public double Area() => Math.PI * Math.Pow(_radius, 2);
        
        //<inheritdoc>
        public double Perimeter() => 2 * Math.PI * _radius;

        #endregion
    }
}
