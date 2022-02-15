using System;
using AreaCalculator.Shapes;
using AreaCalculator.Shapes.Base;

namespace AreaCalculator
{
    public sealed class Calculator
    {
        public IShape Shape { get; private set; }

        public double CalculateArea()
        {
            if (Shape == null)
                throw new Exception("Фигура не выбрана.");

            return Shape.CalculateArea();
        }

        public void SetShapeCircle(double radius) => Shape = new Circle().Init(radius);

        public void SetShapeTriangle(double a, double b, double c) => Shape = new Triangle().Init(a, b, c);

        public void SetShapeRectangle(double width, double height) => Shape = new Rectangle().Init(width, height);


    }
}