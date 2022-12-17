using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalihEkici_Pokedex.Models
{
    public class Pokemon
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Weight { get; set; }
        public string? Height { get; set; }
        public string? Type { get; set; }
        public string? Generation { get; set; }
        public int? PokedexNumber { get; set; }

    }
}
