using System;
using System.Collections.Generic;

namespace Entities
{
    public class Post
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime InsertDate { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Tags> Tags { get; set; }
        public Category Category { get; set; }
    }
}
