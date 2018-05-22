using System;
using System.Collections.Generic;

namespace ASPNetCoreWorkshop_FilterLINQ.Sakila
{
    public partial class Film
    {
        public Film()
        {
            FilmActor = new HashSet<FilmActor>();
            FilmCategory = new HashSet<FilmCategory>();
            Inventory = new HashSet<Inventory>();
        }

        public ushort FilmId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte LanguageId { get; set; }
        public byte? OriginalLanguageId { get; set; }
        public byte RentalDuration { get; set; }
        public decimal RentalRate { get; set; }
        public ushort? Length { get; set; }
        public decimal ReplacementCost { get; set; }
        public DateTimeOffset LastUpdate { get; set; }

        public Language Language { get; set; }
        public Language OriginalLanguage { get; set; }
        public ICollection<FilmActor> FilmActor { get; set; }
        public ICollection<FilmCategory> FilmCategory { get; set; }
        public ICollection<Inventory> Inventory { get; set; }
    }
}
