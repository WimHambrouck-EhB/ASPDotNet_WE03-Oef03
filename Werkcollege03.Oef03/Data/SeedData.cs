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
            context.Database.EnsureCreated();

            if (!context.Vakken.Any())
            {
                context.Vakken.AddRange(new Vak[]
                {
                    new Vak { Naam = "Programming Essentials" },
                    new Vak { Naam = "Programming Advanced" },
                    new Vak { Naam = "Data Essentials" },
                    new Vak { Naam = "Data Advanced" }
                });
            }

            if (!context.Studenten.Any())
            {
                context.Studenten.AddRange(new Student[] {
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
                                Vak = new Vak { Naam = ".NET Essentials" }
                            },
                            new Punt
                            {
                                Score = 20,
                                Vak = new Vak { Naam = ".NET Advanced" }
                            }
                        }
                    }
                });
            }



            context.SaveChanges();
        }
    }
}
