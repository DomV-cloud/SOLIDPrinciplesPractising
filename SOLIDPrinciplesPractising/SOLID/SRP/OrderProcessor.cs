namespace SOLIDPrinciplesPractising.SOLID.SRP
{
    public class OrderProcessor
    {
        private readonly IOrderRepository _orderRepository;

        public OrderProcessor(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void ProcessOrder(Order order)
        {
            Console.WriteLine("Order was processed.");

            _orderRepository.SaveOrder(order);
        }
    }

    public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }

    public interface IOrderRepository
    {
        void SaveOrder(Order order);
    }

    public class OrderRepository : IOrderRepository
    {
        public void SaveOrder(Order order)
        {
            if (order is null)
            {
                throw new ArgumentException("Order is null");
            }

            Console.WriteLine($"Saved order with id {order.Id} to database");
        }
    }
}
