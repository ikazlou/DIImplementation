using Microsoft.Extensions.DependencyInjection;

namespace DIByMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start program");

            var serviceProvider = new ServiceCollection()
                .AddTransient<DatabaseConnector>()  // Dependency registration
                .AddTransient<OrderService>()      // Dependency registration
                .BuildServiceProvider();

            var orderService = serviceProvider.GetService<OrderService>();

            orderService.SetDatabaseConnector(serviceProvider.GetService<DatabaseConnector>());
            orderService.ProcessOrder(new Order(3, "Name 3"));

            Console.WriteLine("Finish program");
        }
    }
}