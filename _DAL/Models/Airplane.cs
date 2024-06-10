using System;
using System.Collections.Generic;

namespace _DAL.Models;

public partial class Airplane
{
    public int AirplaneId { get; set; }

    public string? Model { get; set; }

    public string? Manufacturer { get; set; }

    public int? Year { get; set; }

    public int? Capacity { get; set; }

    public virtual ICollection<Flight> Flights { get; set; } = new List<Flight>();
}
