using System;
using System.Collections.Generic;

namespace ASPNetCoreWorkshop_FilterLINQ.Sakila
{
    public partial class Inventory
    {
        public Inventory()
        {
            Rental = new HashSet<Rental>();
        }

        public uint InventoryId { get; set; }
        public ushort FilmId { get; set; }
        public byte StoreId { get; set; }
        public DateTimeOffset LastUpdate { get; set; }

        public Film Film { get; set; }
        public Store Store { get; set; }
        public ICollection<Rental> Rental { get; set; }
    }
}
