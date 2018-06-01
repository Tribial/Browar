using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Binding
{
    public class AddBeer // model do dodawania piwa
    {
        [Required(ErrorMessage = "Nazwa jest wymagana")] // to znaczy ze pole pod nim ejst wymagane
        [StringLength(50, ErrorMessage = "Nazwa może mieć maksymalnie 50 znaków")] //to że nie moze meic wiecej niz 50 znakow
        public string Name { get; set; } // nazwa
        public string Brand { get; set; } // marka
        public string Kind { get; set; } // rodzaj
        public string Country { get; set; } // kraj
        public decimal Alcohol { get; set; } // zawartosc alkoholu
        public string Description { get; set; } // opis
        public int Rate { get; set; } // ocena
    }
}
