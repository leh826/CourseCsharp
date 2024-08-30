using Emuns.Entities;
using Enums.Entities.Enums;

namespace Enums
{
    class Program
    {
        static void Main (string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PandingPaymet
            };

            Console.WriteLine(order);

            //coversão
            string txt = OrderStatus.PandingPaymet.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
            Console.WriteLine(txt);

        }
    }
}