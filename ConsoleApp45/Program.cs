using System;
using ConsoleApp45.entities;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client cliente = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            Order order = new Order(status, cliente);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine( $"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string nameP = Console.ReadLine();
                Console.Write("Product price: ");
                double precoP = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int qte = int.Parse(Console.ReadLine());

                Product p1 = new Product(nameP, precoP);
                OrderItem pp1 = new OrderItem(qte, precoP, p1);
                order.AddItem(pp1);
            }

            Console.WriteLine(order);

        }
    }
}
