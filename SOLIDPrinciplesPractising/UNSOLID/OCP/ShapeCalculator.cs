namespace SOLIDPrinciplesPractising.UNSOLID.OCP
{
    public class ShapeCalculator
    {
        public double CalculateArea(object shape)
        {
            if (shape is Rectangle rectangle)
            {
                return rectangle.Width * rectangle.Height;
            }
            else if (shape is Circle circle)
            {
                return Math.PI * circle.Radius * circle.Radius;
            }
            else
            {
                throw new ArgumentException("Neznámý tvar");
            }
        }
    }

    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public class Circle
    {
        public double Radius { get; set; }
    }

}
