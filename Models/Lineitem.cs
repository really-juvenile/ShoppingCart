using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    internal class Lineitem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public Product Product { get; set; }

        public Lineitem(int id , int quantity, Product product)
        {
            Id = id;
            Quantity = quantity; 
            Product = product;
            
        }

        public double CalculateLineItemCost()
        {
            return Product.CalculateDiscountedPrice() * Quantity ;
        }


        public override string ToString()
        {
            return $"{Id}\t\t {Product.Id}\t\t {Product.Name}\t\t {Quantity}\t\t {Product.Price}\t\t {Product.DiscountPercent}\t\t {Product.CalculateDiscountedPrice()}\t\t {CalculateLineItemCost()}\n";
        }

    }
}
