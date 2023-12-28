using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqQuantifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                 new Product { Name = "Asp.Net Core", Price = 10000 },
                 new Product { Name = "C-Shart", Price = 15000 },
                 new Product { Name = "C++", Price = 5000 },
                 new Product { Name = "PHP", Price = 25000 },
                 new Product { Name = "Java", Price = 8000 },
            };

            Console.WriteLine("__________ALL___________");
            var allResult = products.All(p => p.Price > 9000);
            Console.WriteLine(allResult);


            Console.WriteLine("__________Any___________");
            var anyResult = products.Any(p => p.Price > 9000);
            Console.WriteLine(anyResult);


            Console.WriteLine("__________Contains___________");
            var ContainsResult = products.Where(p => p.Name.Contains("C"));
            foreach (var item in ContainsResult)
            {
                Console.WriteLine($"{item.Name}");
            }

            Console.ReadLine();
        }
    }
}
