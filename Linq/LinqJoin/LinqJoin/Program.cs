using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqJoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>()
            {
                new Category { Id =1 , Name="mobile"},
                new Category { Id =2 , Name="Laptop"},
            };

            List<Product> products = new List<Product>()
            {
                  new Product { Id =1 , Name ="Iphone Se" , CategoryId = 1},
                  new Product { Id =2 , Name ="Sumsoung G8" , CategoryId = 1},
                  new Product { Id =3 , Name ="Asus" , CategoryId = 2},
                  new Product { Id =3 , Name ="hp" , CategoryId = 2}
            };

            var datajoin = products.Join(categories, p => p.CategoryId, c => c.Id, (product, category) =>
              new
              {
                  ProducId = product.Id,
                  ProductName = product.Name,
                  ProductCategry = category.Name
              });

            foreach (var item in datajoin)
            {
                Console.WriteLine($"{item.ProductName}  {item.ProductCategry}");
            }

            Console.WriteLine($"****************************************");
            var groupJoinResult = categories.GroupJoin(products, c => c.Id, p => p.CategoryId
            , (category, product) =>
            new
            {
                prod = product,
                cat = category,
            });

            foreach (var item in groupJoinResult)
            {
                Console.WriteLine($" Category :{item.cat.Name}");
                foreach (var p in item.prod)
                {
                    Console.WriteLine($"    {p.Name}");
                }
            }

            Console.ReadLine();
        }
    }
}
