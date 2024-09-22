namespace SOLIDPrinciplesPractising.SOLID.ISP
{
    public interface IPrinter
    {
        void Print(string content);
    }

    public interface IScanner
    {
        void Scan(string content);
    }

    public class LaserPrinter : IPrinter, IScanner
    {
        public void Print(string content)
        {
            Console.WriteLine($"Laser print: {content}");
        }

        public void Scan(string content)
        {
            Console.WriteLine($"Laser scanning: {content}");
        }
    }

    public class OldPrinter : IPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine($"Old printer: {content}");
        }
    }
}
