using System.Collections.Generic;
using WebAppMvc.Models.Entites;

namespace WebAppMvc.Models.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        Product Add(Product product);
        Product GetById(long id);
        void Remove(long id);
    }
}
