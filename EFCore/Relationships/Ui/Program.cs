using DLA;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ui
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataBaseContext context = new DataBaseContext();

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();


            //Category category=new Category()
            //{
            //    CategoryName="Laptop"
            //};
            //context.Categories.Add(category);

            //List<Product> products = new List<Product>()
            //{
            //    new Product{ Category= category, Name="Asus m21" , Price=10000},
            //    new Product{ Category= category, Name="Asus k551" , Price=15000}
            //};
            //context.Products.AddRange(products);

            //context.Categories.Where(p=>p.Id==1).ToList();
            //context.Categories.Remove(new Category { Id = 2 });
            //context.SaveChanges();

            //Product product = new Product()
            //{
            //    Category= new Category() { CategoryName= "Laptop"},
            //    Name="Asus",
            //    Price=10000
            //};

            //context.Products.Add(product);

            //var Fk = context.Entry(product).Property("CategoryId").CurrentValue;
            //context.SaveChanges();

            //var Fk2 = context.Entry(product).Property("CategoryId").CurrentValue;
            
            var product=context.Products.FirstOrDefault();

            context.Entry(product).Property("InsertDate").CurrentValue = DateTime.Now;
            context.SaveChanges();

            Console.WriteLine("Hello World!");
        }
    }
}
