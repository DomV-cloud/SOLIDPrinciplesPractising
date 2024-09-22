namespace SOLIDPrinciplesPractising.SOLID.ISP
{
    public interface IWorker
    {
        void Work();
    }

    public interface IEater
    {
        void Eat();
    }

    public class HumanWorker : IWorker, IEater
    {
        public void Work()
        {
            Console.WriteLine("I work.");
        }

        public void Eat()
        {
            Console.WriteLine("I eat.");
        }
    }

    public class RobotWorker : IWorker
    {
        public void Work()
        {
            Console.WriteLine("I work.");
        }
    }
}
