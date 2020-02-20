using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExercicioMod9Pratica.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public int MyProperty { get; set; }
        public List<OrderItem> itens { get; set; } = new List<OrderItem>();


        public Order() 
        {
        
        }

        public Order(DateTime moment, int myProperty)
        {
            Moment = moment;
            MyProperty = myProperty;
           
        }
    }

   


}
