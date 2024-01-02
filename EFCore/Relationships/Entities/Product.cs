using System.Collections;
using System.Collections.Generic;

namespace Entities
{
    public class Category
    {
        public long Id { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }
    }

    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Category Category { get; set; }
        //public long? FK_CategoryId { get; set; }
        public ProductImage ProductImage { get; set; }
        public ICollection<ProductTag> ProductTags { get; set; }
    }

    public class ProductTag
    {
        public Product Product { get; set; }
        public long ProductId { get; set; }
        public Tag Tag { get; set; }
        public string TagId { get; set; }
    }

    public class Tag
    {
        public string TagId { get; set; }
        public ICollection<ProductTag> ProductTags { get; set; }
    }

    public class ProductImage
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public Product Product { get; set; }
        public long FK_ProductId { get; set; }
    }
}
