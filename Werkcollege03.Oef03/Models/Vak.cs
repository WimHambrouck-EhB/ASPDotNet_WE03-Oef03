using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Werkcollege03.Oef03.Models
{
    public class Vak
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        [ScaffoldColumn(false)]
        public int Semester { get; set; }
    }
}
