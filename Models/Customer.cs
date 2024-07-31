﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List <Order> Orders { get; set; } = new List <Order> ();

        public Customer(int id,string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Customer Id : {Id}\n" +
                $"Customer Name : {Name}\n" +
                $"Customer count : {Orders.Count}";
        }

    }
}
