namespace SOLIDPrinciplesPractising.UNSOLID.OCP
{
    public class DiscountCalculator
    {
        public double CalculateDiscount(Order order)
        {
            if (order.Quantity > 10)
            {
                return order.TotalPrice * 0.1;
            }
            else if (order.ProductName == "SpecialProduct")
            {
                return order.TotalPrice * 0.2;
            }
            else
            {
                return 0;
            }
        }
    }

    public class Order
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
    }
}
