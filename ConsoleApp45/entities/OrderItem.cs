using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp45.entities
{
    class OrderItem
    {
        public int Quantity { get; private set; }
        public double Price { get; private set; }
        public Product product { get; private set; }

        public double SubTotal()
        {
            return Quantity * Price;
        }
        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            this.product = product;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append(product + ",  $" + Price.ToString("F2") + ", Quantity: " + Quantity + ", Subtotal: $" + SubTotal().ToString("F2"));


            return s.ToString();
        }
    }
}
