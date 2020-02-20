using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioMod9Pratica.Entities.Enums;
using ExercicioMod9Pratica.Entities;

namespace ExercicioMod9Pratica
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter Cliente Data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: "+DateTime.Now);
            Console.Write("Status: 0 - Pending Payment/ 1 - Processing / 2 - Shipped / 3 - Delivered  ");
            string status = Console.ReadLine();
            OrderStatus order = (OrderStatus)Enum.Parse(typeof(OrderStatus), status);
            OrderItem item = new OrderItem();
            Client cliente = new Client(name, email, birthdate);
            
            Console.Write("How many itens to this order?: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product Name: ");
                string namepro = Console.ReadLine();
                Console.Write("Product Price: ");
                double pricePro = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantityPro = int.Parse(Console.ReadLine());
                Product pro = new Product(namepro, pricePro);
                OrderItem lista = new OrderItem(quantityPro, pricePro);
                
            }
            Console.WriteLine("Order Sumary:");
            Console.WriteLine("Order moment: " + DateTime.Now);
            Console.WriteLine("Order Status: " + order);
            Console.WriteLine("Client: " + cliente.Name + "(" + cliente.BirthDate + ")" + " - " + cliente.Email);

            Console.WriteLine("Order Items: ");
            
        }
    }
}
