using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioMod9Pratica.Entities.Enums;


namespace ExercicioMod9Pratica.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();


        public Order() 
        {
        
        }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem Item) 
        {
            Itens.Add(Item);
        
        }
        public void RemoveItem(OrderItem Item) 
        {
            Itens.Remove(Item);

        }

        

    }

   


}
