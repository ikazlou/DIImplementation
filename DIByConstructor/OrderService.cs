namespace DIByConstructor
{
    public class OrderService
    {
        private DatabaseConnector _databaseConnector;

        public OrderService(DatabaseConnector databaseConnector)
        {
            _databaseConnector = databaseConnector;
        }

        public void ProcessOrder(Order order)
        {
            Console.WriteLine($"Oreder with id {order.Id} has been processed by Service");
            _databaseConnector.Save(order);
        }
    }
}