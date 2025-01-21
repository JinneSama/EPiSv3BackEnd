using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class TripTicketPassenger
{
    public int Id { get; set; }

    public int? TripTicketId { get; set; }

    public string? Passenger { get; set; }

    public string? PassengerPos { get; set; }

    public string? Office { get; set; }

    public string? Address { get; set; }

    public virtual TripTicket? TripTicket { get; set; }
}
