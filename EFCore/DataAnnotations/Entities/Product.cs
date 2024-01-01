using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{

    [Table("tblProduct", Schema = "prod")]
    public class Product
    {
        public long Id { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string Name { get; set; }
        [NotMapped]
        public int Price { get; set; }

        [Column("Des")]
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
    }

    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public long KeyId { get; set; }
    }


}
