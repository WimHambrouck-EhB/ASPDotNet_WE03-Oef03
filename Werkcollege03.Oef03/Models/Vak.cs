namespace Werkcollege03.Oef03.Models
{
    public class Vak
    {
        public int ID { get; set; }
        public string Naam { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var vak = (Vak)obj;

            return vak.ID == ID;
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
    }
}