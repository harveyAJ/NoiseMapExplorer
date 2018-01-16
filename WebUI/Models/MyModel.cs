namespace WebUI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    /// <summary>
    /// https://odetocode.com/blogs/scott/archive/2013/03/11/dropdownlistfor-with-asp-net-mvc.aspx
    /// Potential renaming: AirportExplorer / NoiseExplorer
    /// </summary>
    public class MyModel
    {
        private readonly List<Airport> _airports;
        private string _selectedItems = string.Empty;

        public MyModel()
        {
            //TODO Get all the data from database
            _airports = new List<Airport>
            {
                new Airport { Id = 1, Name = "LHR" },
                new Airport { Id = 2, Name = "LGW" },
                new Airport { Id = 3, Name = "STN" }
            };
        }

        [Display(Name = "Airport")]
        public int SelectedAirportId { get; set; }

        public IEnumerable<SelectListItem> AirportItems
        {
            //get { return new SelectList(_airports, "Id", "Name"); }
            get
            {
                var allFlavors = _airports.Select(f => new SelectListItem
                {
                    Value = f.Id.ToString(),
                    Text = f.Name
                });
                return allFlavors;
            }
        }

        public IEnumerable<SelectListItem> DefaultAirportItem
        {
            get
            {
                return Enumerable.Repeat(new SelectListItem
                {
                    Value = "-1",
                    Text = "Select an airport"
                }, count: 1);
            }
        }
    }
    public class Airport
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}