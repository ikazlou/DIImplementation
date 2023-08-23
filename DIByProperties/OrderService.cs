namespace DIByProperties
{
    public class OrderService
    {
        public DatabaseConnector DatabaseConnector { get; set; }

        public void ProcessOrder(Order order)
        {
            Console.WriteLine($"Oreder with id {order.Id} has been processed by Service");
            DatabaseConnector.Save(order);
        }
    }
}