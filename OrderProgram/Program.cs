﻿using System;
using OrderProgram.Entites;

namespace OrderProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();
            
            Console.Write("Birth date (DD//MM//YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data: ");

            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");

                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());
            }

            Client client = new Client(name, email, birthDate);

            Order order = new Order(DateTime.Now, status, client);


            Console.WriteLine("ORDER SUMARY: ");

            Console.WriteLine();

            Console.WriteLine(order.ToString());
        }
    }
}
