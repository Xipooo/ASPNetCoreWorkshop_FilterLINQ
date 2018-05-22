using System;
using System.Collections.Generic;

namespace ASPNetCoreWorkshop_FilterLINQ.Sakila
{
    public partial class Customer
    {
        public Customer()
        {
            Payment = new HashSet<Payment>();
            Rental = new HashSet<Rental>();
        }

        public ushort CustomerId { get; set; }
        public byte StoreId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ushort AddressId { get; set; }
        public sbyte Active { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTimeOffset? LastUpdate { get; set; }

        public Address Address { get; set; }
        public Store Store { get; set; }
        public ICollection<Payment> Payment { get; set; }
        public ICollection<Rental> Rental { get; set; }
    }
}
