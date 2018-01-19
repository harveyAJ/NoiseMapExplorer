
namespace WebUI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Models;
    using DataAccess;

    public class HomeController : Controller
    {
        private readonly IRepository _repository;

        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            return View(new MyModel(_repository.GetAllAirports()));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Description.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public JsonResult GetAirportReferencePoint(int airportId)
        {
            var airport = _repository.GetAirportById(airportId);
            if (airport == null)
                return new JsonResult { Data = new { Error = "Could not find airport in database" } };
            return new JsonResult
                { Data = new {
                    Lat = airport.ReferencePointLatitude_deg,
                    Long = airport.ReferencePointLongitude_deg,
                    East = airport.ReferencePointEastings_m,
                    North = airport.ReferencePointNorthings_m
                } };
        }

        [HttpPost]
        public JsonResult GetNoiseData(int airportId, int year/*, int metricId*/)
        {
            if (airportId == 1 && year == 2016)
            {
                return new JsonResult
                {

                };
            }

            return new JsonResult();
        } 
    }
}