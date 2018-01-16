
namespace WebUI.Entities
{
    using System.Collections.Generic;

    public class NoiseMap
    {
        public int Id { get; set; }

        public int Year { get; set; }

        public ICollection<Contour> Contours { get; set; }

        public virtual Airport Airport {get;set;}
    }
}