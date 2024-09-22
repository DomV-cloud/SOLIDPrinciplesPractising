namespace SOLIDPrinciplesPractising.SOLID.DIP
{
    namespace SOLIDPrinciplesPractising.UNSOLID.DIP
    {
        public class LightBulb : ILightBulb
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

        public interface ILightBulb
        {
            void TurnOn();
            void TurnOff();
        }

        public class Switch
        {
            private readonly ILightBulb _lightBulb;

            public Switch(ILightBulb lightBulb)
            {
                lightBulb = _lightBulb;
            }

            public void Operate()
            {
                _lightBulb.TurnOn();
                _lightBulb.TurnOff();
            }
        }
    }

}
