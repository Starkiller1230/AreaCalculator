using System;

namespace AreaCalculator.Shapes.Base
{
    public interface IShape
    {
        ShapeType ShapeType { get; }
        double CalculateArea();

    }
}
