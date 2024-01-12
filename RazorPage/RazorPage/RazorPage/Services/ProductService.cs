using RazorPage.Data;
using System.Collections.Generic;
using System.Linq;

namespace RazorPage.Services
{
    public class ProductService : IProductService
    {
        private readonly DataBaseContext _context;
        public ProductService(DataBaseContext context)
        {
            _context = context;
        }
        public int Add(ProductDto product)
        {
            Models.Product entity = new Models.Product
            {
                Description = product.Description,
                Name = product.Name,
                Price = product.Price,
            };
            _context.Products.Add(entity);
            _context.SaveChanges();
            return entity.Id;
        }

        public int Delete(int Id)
        {
            _context.Products.Remove(new Models.Product
            {
                Id = Id,
            });
            return _context.SaveChanges();
        }

        public ProductDto Edit(ProductDto product)
        {
            var entity = _context.Products.Find(product.Id);
            entity.Description = entity.Description;
            entity.Name = entity.Name;
            entity.Price = entity.Price;
            _context.SaveChanges();
            return product;
        }

        public ProductDto Find(int Id)
        {
            var product = _context.Products.Find(Id);
            return new ProductDto
            {
                Description = product.Description,
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
            };
        }

        public List<ProductDto> List()
        {
            var products = _context.Products.OrderByDescending(p => p.Id)
               .Select(p => new ProductDto
               {
                   Description = p.Description,
                   Id = p.Id,
                   Name = p.Name,
                   Price = p.Price
               }).ToList();
            return products;
        }

        public List<ProductDto> Search(string name)
        {
            var products = _context.Products
                .Where(p => p.Name.Contains(name))
                .OrderByDescending(p => p.Id)
                .Select(p => new ProductDto
                {
                    Description = p.Description,
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price
                }).ToList();
            return products;
        }
    }
}
