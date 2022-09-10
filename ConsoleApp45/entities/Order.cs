using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace ConsoleApp45.entities
{
    class Order
    {
        public DateTime Date = DateTime.Now;
        public OrderStatus Status { get; private set; }
        public Client client { get; private set; }
        public List<OrderItem> Items { get; private set; } = new List<OrderItem>();

        public Order(OrderStatus status, Client client)
        {
            Status = status;
            this.client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine();
            s.AppendLine("Order summary: ");
            s.AppendLine("Order moment: " + Date);
            s.AppendLine("Oder status: " + Status);
            s.AppendLine("Client: " + client);
            s.AppendLine("Order items: ");

            foreach (OrderItem item in Items)
            {
                s.AppendLine(item.ToString());                
            }
            s.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return s.ToString();

        }


    }
}
