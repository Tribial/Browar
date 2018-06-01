using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models
{
    public class Beer //tu jest model piwa
    {
        public long Id { get; set; }
        public string Name { get; set; } // nazwa
        public string Brand { get; set; } // marka
        public string Kind { get; set; } // rodzaj
        public string Country { get; set; } // kraj
        public decimal Alcohol { get; set; } // zawartosc alkoholu
        public string Description { get; set; } // opis
        public int Rate { get; set; } // ocena
        public DateTime AddedAt { get; set; } // kiedy dodano
        public bool IsDeleted { get; set; } //czy usuniete
    }
}
