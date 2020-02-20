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
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: 0 - Pending Payment/ 1 - Processing / 2 - Shipped / 3 - Delivered  ");
            string status = Console.ReadLine();
            OrderStatus order = (OrderStatus)Enum.Parse(typeof(OrderStatus), status);

           
            Client cliente = new Client(name, email, birthdate);
            Order item = new Order(DateTime.Now, order, cliente);


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
                OrderItem List = new OrderItem(quantityPro, pricePro, pro);
                                
                item.AddItem(List);
               
            }
            Console.WriteLine();
            Console.WriteLine("Order Sumary:");
            Console.WriteLine(item);
                        
        }
    }
}
