namespace SOLIDPrinciplesPractising.UNSOLID.ISP
{
    public interface IWorker
    {
        void Work();
        void Eat();
    }

    public class HumanWorker : IWorker
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

        public void Eat()
        {
            // Robots don't need to eat, but you have to implement this method
            throw new NotImplementedException();
        }
    }
}
