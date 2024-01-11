using System.ComponentModel;

namespace TagHelper.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        [DisplayName("نام محصول")]
        public string Name { get; set; }
    }
}
