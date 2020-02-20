using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExercicioMod9Pratica.Entities
{
    class OrderItem
    {
        public int  Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }// por que ???
        

        public OrderItem() 
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product  = product; // perguntar depois o Thiago
        }


        public double SubTotal() 
        {
            return Quantity * Price;
        
        }
        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
