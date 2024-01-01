using DAL;
using Entities;
using System;

namespace Ui
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataBaseContext context = new DataBaseContext();

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();


            Order order = new Order()
            {
                KeyId = 1,
            };
            context.Orders.Add(order);

            Order order2 = new Order()
            {
                KeyId = 2,
            };
            context.Orders.Add(order2);
            context.SaveChanges();
            Console.WriteLine("Hello World!");
        }
    }
}
