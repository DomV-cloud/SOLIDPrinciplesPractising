namespace SOLIDPrinciplesPractising.SOLID.OCP
{
    /// <summary>
    /// THIS SOLUTION STILL DOES NOT RESPECT SRP PRINCIPLE
    /// </summary>
    public class DiscountCalculator
    {
        private readonly IDiscount _discount;

        public DiscountCalculator(IDiscount discount)
        {
            _discount = discount;
        }

        public double CalculateDiscount(Order order)
        {
            return 0;
        }
    }

    public class Order : IDiscount
    {
        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public double TotalPrice { get; set; }

        public double GetQuantityDiscount()
        {
            return Quantity > 10 ? TotalPrice * 0.1 : 0;
        }

        public double GetSpecialProductDiscount()
        {
            return ProductName == "SpecialProduct" ? TotalPrice * 0.1 : 0;
        }
    }

    public interface IDiscount
    {
        double GetQuantityDiscount();

        double GetSpecialProductDiscount();
    }
}
