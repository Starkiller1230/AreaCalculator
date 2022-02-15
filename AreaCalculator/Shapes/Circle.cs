using System;
using AreaCalculator.Shapes.Base;

namespace AreaCalculator.Shapes
{
    public class Circle : IShape
    {
        public ShapeType ShapeType => ShapeType.Circle;

        private double _radius;

        public Circle Init(double radius)
        {
            _radius = radius;
            return this;
        }

        public double CalculateArea()
        {
            if (_radius <= 0)
                throw new Exception("Радиус меньше или равен нулю.");

            return Math.PI * Math.Pow(_radius, 2);
        }


    }
}
