using System;

namespace Entities.GeneratedValues
{
    public class User
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public int Score { get; set; }
        public DateTime InsertDate { get; set; }
    }

    public class Order
    {
        public long Id { get; set; }
        //S-2001-02-17-100
        public string OrderNumber { get; set; }
        public long UserId { get; set; }
    }
}
