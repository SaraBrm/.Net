using System;
using System.Collections.Generic;

namespace Entities.GeneratedValues
{
    public class User
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int Score { get; set; }
        public DateTime InsertDate { get; set; }
        public ICollection<Order> Orders { get; set; }
        public Address Home { get; set; }
        public Address Workplace { get; set; }

    }

    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string Alley { get; set; }
        public string Plaque { get; set; }
    }

    public class Order
    {
        public long Id { get; set; }
        //S-2001-02-17-100
        public string OrderNumber { get; set; }
        public long UserId { get; set; }
        public bool Done { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }

    public enum OrderStatus
    {
        Processing,
        Sent,
        Delivered,
    }
}
