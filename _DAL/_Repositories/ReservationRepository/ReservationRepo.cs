using _DAL._Repositories._GenericRepository;
using _DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DAL._Repositories.ReservationRepository
{
    using Type = Reservation;
    public class ReservationRepo : GenericRepo<Reservation>, IReservationRepo
    {
        public ReservationRepo(AirplaneSystemContext context) : base(context)
        {
        }
    }
}
