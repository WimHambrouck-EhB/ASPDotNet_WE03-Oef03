using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Werkcollege03.Oef03.Models;

namespace Werkcollege03.Oef03.Data
{
    public static class SeedData
    {
        public static void Initialize(Werkcollege03Oef03Context context)
        {
            //context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            if (!context.Vakken.Any())
            {
                context.AddRange(new Vak[]
                {
                    new Vak { Naam = ".NET Essentials", Semester = 3 },
                    new Vak { Naam = ".NET Advanced", Semester = 4 },
                    new Vak { Naam = "Programming Essentials", Semester = 1 },
                    new Vak { Naam = "Programming Advanced", Semester = 2 },
                    new Vak { Naam = "Data Essentials", Semester = 2 },
                    new Vak { Naam = "Data Advanced", Semester = 3 }
                });

                context.SaveChanges();
            }

            if (!context.Studenten.Any())
            {
                context.AddRange(new Student[] {
                    new Student { Naam = "Paul" },
                    new Student { Naam = "Marvin" },
                    new Student { Naam = "Michael" },
                    new Student { Naam = "Amber" },
                    new Student { Naam = "Anna" },
                    new Student { Naam = "Belle" },
                    new Student { Naam = "Carrie" },
                    new Student { Naam = "Wim",
                        Punten = new List<Punt> {
                            new Punt {
                                Score = 20,
                                Vak = context.Vakken.Single(v => v.Naam == ".NET Essentials")
                            },
                            new Punt
                            {
                                Score = 20,
                                Vak = context.Vakken.Single(v => v.Naam == ".NET Advanced")
                            }
                        }
                    }
                });

                context.SaveChanges();
            }
        }
    }
}
