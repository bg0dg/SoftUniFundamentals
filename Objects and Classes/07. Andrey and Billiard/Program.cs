using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

//От видео: https://softuni.bg/trainings/resources/video/10560/video-screen-11-october-2016-group-2-simeon-sheitanov-programming-fundamentals-september-2016

namespace _07._Andrey_and_Billiard
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> productsPrice = new Dictionary<string, decimal>();
            int productsCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= productsCount; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string productName = input[0];
                decimal productPrice = decimal.Parse(input[1]);

                if (!productsPrice.ContainsKey(productName))
                {
                    productsPrice.Add(productName, productPrice);
                }

                productsPrice[productName] = productPrice;
            }

            string inputLine = Console.ReadLine();

            List<Customer> customers = new List<Customer>();

            while (!inputLine.Equals("end of clients"))
            {
                string[] customerInfo = inputLine.Split(',', '-');
                string customerName = customerInfo[0];
                string customerProduct = customerInfo[1];
                int quantity = int.Parse(customerInfo[2]);

                if (!productsPrice.ContainsKey(customerProduct))
                {
                    inputLine = Console.ReadLine();
                    continue;
                }

                if(customers.Any(c => c.Name == customerName))
                {
                    Customer customer = customers.First(c => c.Name == customerName);
                    if (!customer.OrdersQuantity.ContainsKey(customerProduct))
                    {
                        customer.OrdersQuantity.Add(customerProduct, quantity);
                    }
                    else
                    {
                        customer.OrdersQuantity[customerProduct] += quantity;
                    }

                    customer.Bill += quantity * productsPrice[customerProduct];
                }

                else
                {
                    Customer customer = new Customer();
                    customer.Name = customerName;
                    customer.OrdersQuantity = new Dictionary<string, int>();
                    customer.OrdersQuantity.Add(customerProduct, quantity);
                    customer.Bill += quantity * productsPrice[customerProduct];
                    customers.Add(customer);
                }
                

                inputLine = Console.ReadLine();
            }

            foreach (Customer customer in customers.OrderBy(c => c.Name))
            {
                Console.WriteLine(customer.Name);
                foreach (KeyValuePair<string, int> customerOrders in customer.OrdersQuantity)
                {
                    Console.WriteLine($"-- {customerOrders.Key} - {customerOrders.Value}");
                }

                Console.WriteLine($"Bill: {customer.Bill:F2}");
            }

            decimal totalBill = customers.Sum(c => c.Bill);
            Console.WriteLine($"Total bill: {totalBill}");
        }

        class Customer
        {
            public string Name { get; set; }
            public Dictionary<string, int> OrdersQuantity { get; set; }
            public decimal Bill { get; set; }
        }
    }
}
