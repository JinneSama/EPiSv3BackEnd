using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class TicketRequestStatus
{
    public int Id { get; set; }

    public int Status { get; set; }

    public DateTime? DateStatusChanged { get; set; }

    public string? ChangedByUserId { get; set; }

    public int TicketRequestId { get; set; }

    public virtual AspNetUser? ChangedByUser { get; set; }

    public virtual TicketRequest TicketRequest { get; set; } = null!;
}
