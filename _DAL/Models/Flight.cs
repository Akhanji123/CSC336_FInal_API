using System;
using System.Collections.Generic;

namespace _DAL.Models;

public partial class Flight
{
    public int FlightId { get; set; }

    public string? FlightNumber { get; set; }

    public DateTime? DepartureTime { get; set; }

    public DateTime? ArrivalTime { get; set; }

    public string? DepartureAirport { get; set; }

    public string? ArrivalAirport { get; set; }

    public int? AirplaneId { get; set; }

    public int? PilotId { get; set; }

    public virtual Airplane? Airplane { get; set; }

    public virtual Pilot? Pilot { get; set; }

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
