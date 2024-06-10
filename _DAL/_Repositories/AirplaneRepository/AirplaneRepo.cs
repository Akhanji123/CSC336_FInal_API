using _DAL._Repositories._GenericRepository;
using _DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DAL._Repositories.AirplaneRepository
{
    using Type = _DAL.Models.Airplane;
    public class AirplaneRepo : GenericRepo<Type>, IAirplaneRepo
    {

        public AirplaneRepo(AirplaneSystemContext context) : base( context)
        {
        }
    }
}
