using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }

       // public int Quantity { get; set; }

        public List <Lineitem> Lineitems { get; set; } = new List<Lineitem> ();

        public Order(int id, DateTime time)
        {
            Id = id;
            Time = time;
            //Quantity = quantity;
        }

        public double CalculateOrderPrice(Order order)
        {
            double Order = 0;
            foreach (Lineitem lineitem in Lineitems)
            {
                Order += lineitem.CalculateLineItemCost();

            }
            return Order;
                

        }

        public override string ToString()
        {
            return $"Order id : {Id}\n" +
                $"Order Time : {Time}\n";
        }


    }
}
