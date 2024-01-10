using System.ComponentModel.DataAnnotations;

namespace Filters.Models
{
    public class ProductViewmodel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int price { get; set; }
    }
}
