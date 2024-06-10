using _DAL._Repositories.AirplaneRepository;
using BLL._Services.AirplaneService;
using BLL._Services.FlightService;
using BLL.DataTransferObjects;

namespace CSC336_FInal.Controllers
{
    public class FlightController :_GenericController<FlightDTO>
    {
        public readonly IFlightServ _FlightServ;
        public FlightController(IFlightServ service) : base(service)
        {
            _FlightServ = service;
        }
    }
}
