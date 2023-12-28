using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqAggregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string>() { "Asp.net Core", "Csharp", "Php", "Java", "nodeJs", "Go" };

            var sep = data.Aggregate((s1, s2) => s1 + "-|-" + s2);
            Console.WriteLine(sep);
            
            Console.WriteLine("\n____________________________________________");

            List<Product> products = new List<Product>()
            {
                new Product { Name = "Asp.Net Core", Price = 10000 },
                 new Product { Name = "C-Shart", Price = 15000 },
                 new Product { Name = "C++", Price = 5000 },
                 new Product { Name = "PHP", Price = 25000 },
                 new Product { Name = "Java", Price = 8000 },
            };

            string sep2 = products.Aggregate<Product, string, string>("Products Name :"
                , (str, p) => str += p.Name + ","
                , str => str.Substring(0, str.Length - 1));

            Console.WriteLine(sep2);

            Console.WriteLine("\n____________________Average__________________");
            Console.WriteLine(products.Average(p => p.Price).ToString());

            Console.WriteLine("\n____________________Count__________________");
            Console.WriteLine(products.LongCount().ToString());

            Console.WriteLine("\n____________________Max__________________");
            Console.WriteLine(products.Max(p => p.Price).ToString());

            Console.WriteLine("\n____________________Min__________________");
            Console.WriteLine(products.Min(p => p.Price).ToString());
            
            Console.WriteLine("\n____________________Sum__________________");
            Console.WriteLine(products.Sum(p => p.Price).ToString());

            Console.ReadLine();
        }
    }
}
