namespace DIByConstructor
{
    public class DatabaseConnector
    {
        public void Save(Order order)
        {
            Console.WriteLine($"Order with name {order.OrderName} have been saved");
        }
    }
}