using System;
using System.Collections.Generic;

namespace _DAL.Models;

public partial class Pilot
{
    public int PilotId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? LicenseNumber { get; set; }

    public DateOnly? CertificationDate { get; set; }

    public virtual ICollection<Flight> Flights { get; set; } = new List<Flight>();
}
