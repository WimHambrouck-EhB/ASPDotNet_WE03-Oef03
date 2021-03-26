using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Werkcollege03.Oef03.Models
{
    public class Punt
    {
        public int ID { get; set; }
        public Vak Vak { get; set; }
        public Student Student { get; set; }

        [Display(Name = "Vak")]
        public int VakID { get; set; }

        [Display(Name = "Student")]
        public int StudentID { get; set; }

        [Range(0, 20)]
        public int Score { get; set; }

        [NotMapped]
        [DisplayFormat(DataFormatString = "{0}%")]
        public int ScoreProcent => Score * 5;
    }
}
