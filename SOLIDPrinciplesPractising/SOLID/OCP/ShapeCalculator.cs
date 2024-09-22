namespace SOLIDPrinciplesPractising.SOLID.OCP
{
    public class ShapeCalculator
    {
        public double CalculateArea(IShape shape)
        {
            return shape.Area();
        }
    }

    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area()
        {
            return Width * Height;
        }
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public interface IShape
    {
        public double Area();
    }
}
