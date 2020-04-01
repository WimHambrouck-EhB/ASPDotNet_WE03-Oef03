using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Werkcollege03.Oef03.Models
{
    public class Student
    {
        public int ID { get; set; }
        public int Naam { get; set; }
        public virtual IDictionary<Vak, int> Punten { get; set; }

    }
}
