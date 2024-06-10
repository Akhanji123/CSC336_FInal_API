using BLL._Services._GenericService;
using BLL._Services.PilotService;
using BLL.DataTransferObjects;

namespace CSC336_FInal.Controllers
{
    public class PilotController : _GenericController<PilotDTO>
    {
        public readonly IPilotServ _pilotServ;
        public PilotController(IPilotServ service) : base(service)
        {
            _pilotServ = service;
        }
    }
}
