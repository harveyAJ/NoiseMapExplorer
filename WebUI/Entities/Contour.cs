
namespace WebUI.Entities
{
    using System.Collections.Generic;

    public class Contour
    {
        public int Id { get; set; }

        public double Level_dB { get; set; }

        public ICollection<GeoPoint> Points { get; set; }

        public virtual NoiseMap NoiseMap {get;set;}
    }
}