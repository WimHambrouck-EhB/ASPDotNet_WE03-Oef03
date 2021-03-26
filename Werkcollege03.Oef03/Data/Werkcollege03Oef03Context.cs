using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Werkcollege03.Oef03.Models;

namespace Werkcollege03.Oef03.Data
{
    public class Werkcollege03Oef03Context : DbContext
    {
        public Werkcollege03Oef03Context (DbContextOptions<Werkcollege03Oef03Context> options)
            : base(options)
        {
        }

        public DbSet<Student> Studenten { get; set; }
        public DbSet<Vak> Vakken { get; set; }
        public DbSet<Punt> Punten { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // voegt UNIQUE constraint toe aan Vak.Naam (zie: https://docs.microsoft.com/en-us/ef/core/modeling/indexes?tabs=fluent-api#index-uniqueness)
            // vanaf EF Core 5 gaat dit ook met Data Annotations
            modelBuilder.Entity<Vak>()
                .HasIndex(v => v.Naam)
                .IsUnique();
        }
    }
}
