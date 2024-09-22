namespace SOLIDPrinciplesPractising.UNSOLID.LSP
{
    public class Bird : IFlayable, IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("I am walking.");
        }
        
        public void Fly()
        {
            Console.WriteLine("I am flying.");
        }
    }

    public interface IFlayable
    {
        void Fly();
    }
    public interface IWalkable
    {
        void Walk();
    }

    public class Penguin : IFlayable
    {
        public void Fly()
        {
            Console.WriteLine("I am flying.");
        }
    }
}
