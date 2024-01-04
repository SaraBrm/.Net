using System.Collections.Generic;

namespace Entities
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public bool IsRemoved { get; set; }
    }
}
