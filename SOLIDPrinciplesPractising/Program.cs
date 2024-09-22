using SOLIDPrinciplesPractising.SOLID.OCP;

namespace SOLIDPrinciplesPractising
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShapeCalculator calculator = new ();
            IShape rectangle = new Rectangle(5, 10);
            Console.WriteLine($"Rectangle Area: {calculator.CalculateArea(rectangle)}");
        }
    }
}
