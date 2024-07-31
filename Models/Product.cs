using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
       // public int Quantity { get; set; }
        public double DiscountPercent {get; set; }


        public Product(int id,string name, double price,double discountPercent)
        {
            Id = id;
            Name = name;
            Price = price;
            DiscountPercent = discountPercent;

        }

        public double CalculateDiscountedPrice()
        {
            return Price * (1 -(DiscountPercent/ 100));
        }



    }
}
