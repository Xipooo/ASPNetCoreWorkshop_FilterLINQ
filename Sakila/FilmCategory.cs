using System;
using System.Collections.Generic;

namespace ASPNetCoreWorkshop_FilterLINQ.Sakila
{
    public partial class FilmCategory
    {
        public ushort FilmId { get; set; }
        public byte CategoryId { get; set; }
        public DateTimeOffset LastUpdate { get; set; }

        public Category Category { get; set; }
        public Film Film { get; set; }
    }
}
