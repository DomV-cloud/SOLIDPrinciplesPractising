namespace SOLIDPrinciplesPractising.UNSOLID.DIP
{
    public class LightBulb
    {
        public void TurnOn()
        {
            Console.WriteLine("LightBulb is turn on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("LightBulb is turn off.");
        }
    }

    public class Switch
    {
        private LightBulb _lightBulb;

        public Switch()
        {
            _lightBulb = new();
        }

        public void Operate()
        {
            _lightBulb.TurnOn();
            _lightBulb.TurnOff();
        }
    }
}
