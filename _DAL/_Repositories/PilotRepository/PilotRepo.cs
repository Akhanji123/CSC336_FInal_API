using _DAL._Repositories._GenericRepository;
using _DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DAL._Repositories.PilotRepository
{
    using Type = Pilot;
    public class PilotRepo : GenericRepo<Type>, IPilotRep
    {
        public PilotRepo(AirplaneSystemContext context) : base(context)
        {
        }
    }
}
