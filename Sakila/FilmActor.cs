using System;
using System.Collections.Generic;

namespace ASPNetCoreWorkshop_FilterLINQ.Sakila
{
    public partial class FilmActor
    {
        public ushort ActorId { get; set; }
        public ushort FilmId { get; set; }
        public DateTimeOffset LastUpdate { get; set; }

        public Actor Actor { get; set; }
        public Film Film { get; set; }
    }
}
