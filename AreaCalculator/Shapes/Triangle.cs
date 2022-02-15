using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AreaCalculator.Shapes.Base;

namespace AreaCalculator.Shapes
{
    public class Triangle : IShape
    {
        public ShapeType ShapeType => ShapeType.Triangle;
        public bool IsRectangular { get; private set; } = false;

        private double _a, _b, _c;

        public Triangle Init(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;

            if (_a * _a + _b * _b == _c * _c)
                IsRectangular = true;

            return this;
        }
        
        public double CalculateArea()
        {
            if (_a <= 0 || _b <= 0 || _c <= 0)
                throw new Exception("Одна из сторон меньше или равна нулю.");

            double p = (_a + _b + _c) / 2;
            double s = Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));

            return s;
        }
    }
}
