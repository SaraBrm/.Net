using System.ComponentModel;

namespace MVC.Models.Entities
{
    public class Users
    {
        public int Id { get; set; }
        [DisplayName("نام")]
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
