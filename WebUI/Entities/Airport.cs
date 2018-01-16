
namespace WebUI.Entities
{
    using System.Collections.Generic;

    public class Airport
    {
        public int Id { get; set; }

        public string IataCode { get; set; }

        public string IcaoCode { get; set; }

        public string Name { get; set; }

        public double ReferencePointLatitude_deg { get; set; }

        public double ReferencePointLongitude_deg { get; set; }

        public ICollection<NoiseMap> NoiseMaps { get; set; }
    }
}