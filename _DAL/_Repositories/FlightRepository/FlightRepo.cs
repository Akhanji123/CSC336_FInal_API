using _DAL._Repositories._GenericRepository;
using _DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DAL._Repositories.FlightRepository
{
    using Type = Flight;
    public class FlightRepo : GenericRepo<Flight>, IFlightRepo
    {
        public FlightRepo(AirplaneSystemContext context) : base(context)
        {
        }
    }
}
