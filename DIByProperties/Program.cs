using Microsoft.Extensions.DependencyInjection;

namespace DIByProperties
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

            orderService.DatabaseConnector = serviceProvider.GetService<DatabaseConnector>();
            orderService.ProcessOrder(new Order(2, "Name 2"));

            Console.WriteLine("Finish program");
        }
    }
}