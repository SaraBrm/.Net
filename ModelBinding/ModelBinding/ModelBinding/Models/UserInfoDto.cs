using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ModelBinding.Models
{
    public class UserInfoDto
    {
        [BindNever]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public string Token { get; set; }
    }
}
