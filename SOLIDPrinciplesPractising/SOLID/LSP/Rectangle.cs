namespace SOLIDPrinciplesPractising.SOLID.LSP
{
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area()
        {
            return Width * Height;
        }
    }

    public class Square : IShape
    {
        public double Side { get; set; }

        public double Area()
        {
            return Side * Side;
        }
    }

    public interface IShape
    {
        public double Area();
    }
}
