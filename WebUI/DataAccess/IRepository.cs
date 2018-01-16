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
        Airport GetByAirportId(int id);

        NoiseMap GetByAirportIdAndYear(int id, int year);


    }
}
