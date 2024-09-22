namespace SOLIDPrinciplesPractising.UNSOLID.ISP
{
    public interface IPrinter
    {
        void Print(string content);
        void Scan(string content);
    }

    public class LaserPrinter : IPrinter
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

        public void Scan(string content)
        {
            // Old printer cannot scan
            throw new NotImplementedException();
        }
    }
}
