using BLL._Services._GenericService;
using BLL._Services.ReservationService;
using BLL.DataTransferObjects;
using BLL.Wrapping;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace CSC336_FInal.Controllers
{
    public class ReservationController : _GenericController<ReservationDTO>
    {
        public readonly IReservationServ _reservationServ;
        public ReservationController(IReservationServ service) : base(service)
        {
            _reservationServ = service;
        }
        [HttpPost("AddReservationWithPassAndFlight")]
        public async Task<ApiResponse<AddResWithPassAndFlight>> AddingResWithPassAndFlight(AddResWithPassAndFlight ResWithPassAndFlightDTO)
        {
            return await _reservationServ.AddingResWithPassAndFlight(ResWithPassAndFlightDTO);
        }
    }
}
