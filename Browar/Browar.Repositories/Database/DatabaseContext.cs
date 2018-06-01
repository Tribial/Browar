using Microsoft.EntityFrameworkCore;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Browar.Repositories.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Beer> Beers { get; set; } //to tworzy tabele dla piw

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Beer>()
                .HasKey(x => x.Id); //mówi, że ID to klucz główny dla Beer
        }
    }
}
