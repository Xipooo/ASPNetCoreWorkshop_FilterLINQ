using System;
using System.Collections.Generic;

namespace ASPNetCoreWorkshop_FilterLINQ.Sakila
{
    public partial class Country
    {
        public Country()
        {
            City = new HashSet<City>();
        }

        public ushort CountryId { get; set; }
        public string Country1 { get; set; }
        public DateTimeOffset LastUpdate { get; set; }

        public ICollection<City> City { get; set; }
    }
}
