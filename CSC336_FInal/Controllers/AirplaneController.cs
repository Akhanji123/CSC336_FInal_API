using _DAL._Repositories.AirplaneRepository;
using BLL._Services._GenericService;
using BLL._Services.AirplaneService;
using BLL.DataTransferObjects;

namespace CSC336_FInal.Controllers
{
    public class AirplaneController : _GenericController<AirplaneDTO>
    {
        public readonly IAirplaneServ _airplaneServ;
        public AirplaneController(IAirplaneServ service) : base(service)
        {
            _airplaneServ = service;
        }
    }
}
