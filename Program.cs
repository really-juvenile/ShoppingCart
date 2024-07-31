using System.Security.Cryptography;
using ShoppingCart.Models;

namespace ShoppingCart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(101, "Comb", 100, 10);
            Product p2 = new Product(102, "Paper", 200, 10);
            Product p3 = new Product(103, "Mop", 150, 20);
            Product p4 = new Product(104, "Cell", 500, 35);

            Customer customer = new Customer(01, "Suresh");
            

            Order o1 = new Order(1001,DateTime.Now);
            Order o2 = new Order (1002,DateTime.Now);

            Lineitem l1 = new Lineitem(1,5,p1);
            Lineitem l2 = new Lineitem(2,5,p2);
            Lineitem l3 = new Lineitem(3,2,p3);
            Lineitem l4 = new Lineitem(4,6,p4);


            customer.Orders.Add(o1);    
            customer.Orders.Add(o2);

            o1.Lineitems.Add(l1);
            o1.Lineitems.Add(l2);

            o2.Lineitems.Add(l3);
            o2.Lineitems.Add(l4);


            PrintDetails(customer);

        }

        static void PrintDetails(Customer customer)
        {
            Console.WriteLine($"Customer Id : {customer.Id}");
            Console.WriteLine($"Customer Name : {customer.Name}");
            Console.WriteLine($"Order Count : {customer.Orders.Count}");

            foreach ( Order o in customer.Orders )
            {
                Console.WriteLine("========================================================================================================================\n");
                
                Console.WriteLine(o);
                Console.WriteLine("LineItemid\tProduct ID\tProduct Name\tQuantity\tUnit Price\tDiscount%\tAfterDiscount\tLineItemCost");
                foreach (Lineitem l in o.Lineitems)
                {
                    Console.WriteLine("========================================================================================================================\n");
                    Console.WriteLine(l);

                    

                }
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t Total Order Price = "+o.CalculateOrderPrice(o));


            }
         



        }

    }    
}
