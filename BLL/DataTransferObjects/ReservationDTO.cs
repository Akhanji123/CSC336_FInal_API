using _DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DataTransferObjects
{
    public class ReservationDTO
    {
        public int ReservationId { get; set; }

        public int? FlightId { get; set; }

        public int? PassengerId { get; set; }

        public string? SeatNumber { get; set; }

        public DateTime? ReservationDate { get; set; }

        public virtual Flight? Flight { get; set; }

        public virtual Passenger? Passenger { get; set; }
    }
}
