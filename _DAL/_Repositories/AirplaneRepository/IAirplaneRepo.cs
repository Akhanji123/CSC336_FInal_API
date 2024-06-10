using _DAL._Repositories._GenericRepository;
using _DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DAL._Repositories.AirplaneRepository
{
    using Type =Airplane;
    public interface IAirplaneRepo :IGenericRepo<Type>
    {


    }
}
