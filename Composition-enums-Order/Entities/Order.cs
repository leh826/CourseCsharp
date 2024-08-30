
using Pedido.Entities.Enums;
using System.Globalization;
using System.Text;

namespace Pedido.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Item { get; private set; } = new List<OrderItem>();

        public Order()
        {
        }
        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }
        public void AddItem(OrderItem item)
        {
            Item.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Item.Remove(item);
        }
        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in Item)
            {
                total += item.SubTotal();   
            }
            return total;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (OrderItem item in Item)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
