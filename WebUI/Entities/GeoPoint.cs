using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Entities
{
    public class GeoPoint
    {
        public double Latitude_deg { get; set; }

        public double Longitude_deg { get; set; }

        public virtual Contour Contour {get;set;}
    }
}