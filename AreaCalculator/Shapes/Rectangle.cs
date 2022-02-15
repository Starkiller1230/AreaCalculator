using System;
using AreaCalculator.Shapes.Base;

namespace AreaCalculator.Shapes
{
    public class Rectangle : IShape
    {
        public ShapeType ShapeType => ShapeType.Rectangle;

        private double _w, _h;

        public Rectangle Init(double width, double height)
        {
            _w = width;
            _h = height;

            return this;
        }

        public double CalculateArea()
        {

            if (_w <= 0 || _h <= 0)
                throw new Exception("Одна из сторон меньше или равна нулю.");

            return _w * _h;
        }
    }
}
