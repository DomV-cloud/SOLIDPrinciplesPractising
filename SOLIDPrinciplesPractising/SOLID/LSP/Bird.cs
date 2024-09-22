namespace SOLIDPrinciplesPractising.SOLID.LSP
{
    public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("I am flying.");
        }
    }

    public class Penguin : Bird
    {
        public override void Fly()
        {
            throw new NotSupportedException("Penguins cannot fly.");
        }
    }
}
