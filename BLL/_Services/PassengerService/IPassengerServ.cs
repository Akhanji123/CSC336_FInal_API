using BLL._Services._GenericService;
using BLL.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL._Services.PassengerService
{
    using TypeOfDTO = PassengerDTO;
    public interface IPassengerServ : IGenericServ<TypeOfDTO>
    {
    }
}
