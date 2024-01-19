using System.Collections.Generic;

namespace DI_InMiddleware.Services
{

    public interface IProductRepository
    {
        List<Product> GetProducts();
    }

    public class ProductRepository : IProductRepository
    {

        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                 new Product { Id = 1, Name= " Iphone x"},
                 new Product { Id = 2, Name= " Sumsoung g1"},
                 new Product { Id = 3, Name= " Nokia 1100"},
            };
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
