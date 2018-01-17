
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

        /// <summary>
        /// National Grid Eastings in meters [m]
        /// </summary>
        /// <remarks>
        /// Only valid for UK airports
        /// </remarks>
        public double? ReferencePointEastings_m { get; set; }

        /// <summary>
        /// National Grid Northings in meters [m]
        /// </summary>
        /// <remarks>
        /// Only valid for UK airports
        /// </remarks>
        public double? ReferencePointNorthings_m { get; set; }

        public ICollection<NoiseMap> NoiseMaps { get; set; }
    }
}