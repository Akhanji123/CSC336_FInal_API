using BLL._Services.FlightService;
using BLL._Services.PassengerService;
using BLL.DataTransferObjects;

namespace CSC336_FInal.Controllers
{
    public class PassengerController : _GenericController<PassengerDTO>
    {
        public readonly IPassengerServ _passengerServServ;
        public PassengerController(IPassengerServ service) : base(service)
        {
            _passengerServServ = service;
        }
    }
}
