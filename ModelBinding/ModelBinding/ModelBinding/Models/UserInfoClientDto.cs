using Microsoft.AspNetCore.Mvc;

namespace ModelBinding.Models
{
    public class UserInfoClientDto
    {

        public string Name { get; set; }
        public string LastName { get; set; }

        [FromHeader]
        public string Token { get; set; }
    }
}
