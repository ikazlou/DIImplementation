namespace DIByMethods
{
    public class Order
    {
        public Order()
        {
        }

        public Order(int id, string orderName)
        {
            Id = id;
            OrderName = orderName;
        }

        public int Id { get; set; }
        public string OrderName { get; set; }
    }
}
