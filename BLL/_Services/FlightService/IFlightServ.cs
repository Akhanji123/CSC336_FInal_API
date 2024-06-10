using BLL._Services._GenericService;
using BLL.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL._Services.FlightService
{
    using TypeOfDTO = FlightDTO;
    public interface IFlightServ :IGenericServ<TypeOfDTO>
    {
    }
}
