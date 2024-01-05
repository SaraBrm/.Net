using System;

namespace Entities
{
    public class Order
    {
        public long Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }

}
