using Microsoft.Extensions.DependencyInjection;

namespace DIByConstructor
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
            
            orderService.ProcessOrder(new Order(1, "Name"));

            Console.WriteLine("Finish program");
        }
    }
}