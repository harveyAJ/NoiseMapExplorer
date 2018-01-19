
namespace WebUI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Entities;

    /// <summary>
    /// https://odetocode.com/blogs/scott/archive/2013/03/11/dropdownlistfor-with-asp-net-mvc.aspx
    /// Potential renaming: AirportExplorer / NoiseExplorer
    /// </summary>
    public class MyModel
    {
        private readonly List<Airport> _airports;
        private readonly List<int> _years = null;

        private string _selectedItems = string.Empty;

        public MyModel(IEnumerable<Airport> airports)
        {
            _years = new List<int> { 2015, 2016, 2017 };
            _airports = airports.ToList();
        }

        [Display(Name = "Airport")]
        public int SelectedAirportId { get; set; }

        public IEnumerable<SelectListItem> AirportItems
        {
            get
            {
                var allAirports = _airports.Select(a => new SelectListItem
                {
                    Value = a.Id.ToString(),
                    Text = a.IataCode
                });
                return allAirports;
            }
        }

        [Display(Name = "Year")]
        public int SelectedYear { get; set; }

        public IEnumerable<SelectListItem> YearItems
        {
            get
            {
                return _years.Select(y => new SelectListItem
                {
                    Value = y.ToString(),
                    Text = y.ToString()
                });
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
}