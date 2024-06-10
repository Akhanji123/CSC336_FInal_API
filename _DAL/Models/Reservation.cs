using System;
using System.Collections.Generic;

namespace _DAL.Models;

public partial class Reservation
{
    public int ReservationId { get; set; }

    public int? FlightId { get; set; }

    public int? PassengerId { get; set; }

    public string? SeatNumber { get; set; }

    public DateTime? ReservationDate { get; set; }

    public virtual Flight? Flight { get; set; }

    public virtual Passenger? Passenger { get; set; }
}
