using System;
using System.Collections.Generic;

namespace ASPNetCoreWorkshop_FilterLINQ.Sakila
{
    public partial class Store
    {
        public Store()
        {
            Customer = new HashSet<Customer>();
            Inventory = new HashSet<Inventory>();
            Staff = new HashSet<Staff>();
        }

        public byte StoreId { get; set; }
        public byte ManagerStaffId { get; set; }
        public ushort AddressId { get; set; }
        public DateTimeOffset LastUpdate { get; set; }

        public Address Address { get; set; }
        public Staff ManagerStaff { get; set; }
        public ICollection<Customer> Customer { get; set; }
        public ICollection<Inventory> Inventory { get; set; }
        public ICollection<Staff> Staff { get; set; }
    }
}
