using Pedido.Entities;
using Pedido.Entities.Enums;
using System.Globalization;

namespace Pedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime dataBirth = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, dataBirth);

            Console.WriteLine();
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            DateTime date = DateTime.Now;
            Order order = new Order(date, status);

            Console.WriteLine("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data:");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product product = new Product(productName, price);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem item = new OrderItem( quantity, price);
                order.AddItem(item);
            }

            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine($"Order moment: {order.Moment}");
            Console.WriteLine($"Order status: {order.Status}");
            Console.WriteLine(client);
            Console.WriteLine("Order items:");
            Console.WriteLine(order);


        }
    }
}