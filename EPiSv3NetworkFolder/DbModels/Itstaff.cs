using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels;

public partial class Itstaff
{
    public int Id { get; set; }

    public string? ImagePath { get; set; }

    public int Section { get; set; }

    public string? UserId { get; set; }

    public virtual ICollection<TicketRequest> TicketRequests { get; set; } = new List<TicketRequest>();

    public virtual AspNetUser? User { get; set; }
}
