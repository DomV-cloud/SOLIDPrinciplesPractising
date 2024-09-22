namespace SOLIDPrinciplesPractising.UNSOLID.SRP
{
    public class OrderProcessor
    {
        public void ProcessOrder(Order order)
        {
            Console.WriteLine("Order was stored to processed.");

            SaveOrderToDatabase(order);
        }

        private void SaveOrderToDatabase(Order order)
        {
            Console.WriteLine("Order was stored to database.");
        }
    }

    public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }

}
