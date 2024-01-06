using System;
using System.Collections.Generic;

namespace DapperQuery
{
    public class Order
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public Invoice Invoice { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
