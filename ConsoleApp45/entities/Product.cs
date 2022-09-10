using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp45.entities
{
    class Product
    {
        public string Name { get; private set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append(Name);


            return s.ToString();
        }
    }
}
