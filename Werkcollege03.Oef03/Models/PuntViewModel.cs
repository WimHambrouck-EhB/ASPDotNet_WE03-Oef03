using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Werkcollege03.Oef03.Models
{
    public class PuntViewModel
    {
        public SelectList Studenten { get; set; }        
        public SelectList Vakken { get; set; }
        public Punt Punt { get; set; }
    }
}
