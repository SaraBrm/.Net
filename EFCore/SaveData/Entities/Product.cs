namespace Entities
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public long CategoryId { get; set; }
    }

}
