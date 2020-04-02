using System.ComponentModel.DataAnnotations;

namespace Werkcollege03.Oef03.Models
{
    public class Punt
    {
        public int ID { get; set; }
        public Vak Vak { get; set; }
        [Range(0, 20)]
        public int Score { get; set; }

    }
}