using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Werkcollege03.Oef03.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public virtual ICollection<Punt> Punten { get; set; }

    }
}
