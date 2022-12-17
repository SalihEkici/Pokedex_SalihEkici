using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalihEkici_Pokedex.Models
{
    public class PokedexDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = PokemonDb.db");
        }

        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<User> User { get; set; }
    }
}
