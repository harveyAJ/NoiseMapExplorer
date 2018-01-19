using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebUI.DataAccess
{
    using Entities;

    public interface IRepository
    {
        IEnumerable<Airport> GetAllAirports();

        Airport GetAirportById(int id);

        NoiseMap GetContoursByAirportIdAndYear(int id, int year);


    }
}
