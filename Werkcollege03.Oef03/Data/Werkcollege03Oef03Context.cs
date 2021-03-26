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

    }
}
