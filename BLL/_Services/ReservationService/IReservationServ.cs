using BLL._Services._GenericService;
using BLL.DataTransferObjects;
using BLL.Wrapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL._Services.ReservationService
{
    using TypeOfDTO = ReservationDTO;
    public interface IReservationServ : IGenericServ<TypeOfDTO>
    {
        public Task<ApiResponse<AddResWithPassAndFlight>> AddingResWithPassAndFlight(AddResWithPassAndFlight ResWithPassAndFlightDTO);
    }
}
