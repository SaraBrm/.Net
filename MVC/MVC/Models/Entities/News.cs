using System.Collections.Generic;
using System.Xml.Linq;

namespace MVC.Models.Entities
{
    public class News
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public virtual List<Comments> Comments { get; set; }
    }
}
