using BLL._Services._GenericService;
using BLL._Services.ReservationService;
using BLL.DataTransferObjects;

namespace CSC336_FInal.Controllers
{
    public class ReservationController : _GenericController<ReservationDTO>
    {
        public readonly IReservationServ _reservationServ;
        public ReservationController(IReservationServ service) : base(service)
        {
            _reservationServ = service;
        }
    }
}
