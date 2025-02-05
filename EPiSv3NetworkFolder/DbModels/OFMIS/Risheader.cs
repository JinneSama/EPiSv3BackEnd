﻿using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Risheader
{
    public int Id { get; set; }

    public int? Prid { get; set; }

    public int? OfficeId { get; set; }

    public string? Risno { get; set; }

    public string? Sai { get; set; }

    public DateTime? Risdate { get; set; }

    public DateTime? Saidate { get; set; }

    public string? CreatedBy { get; set; }

    public string? RequestedBy { get; set; }

    public string? RequestedByPos { get; set; }

    public string? ApprovedBy { get; set; }

    public string? ApprovedByPos { get; set; }

    public string? IssuedBy { get; set; }

    public string? IssuedByPos { get; set; }

    public string? ReceivedBy { get; set; }

    public string? ReceivedByPos { get; set; }

    public DateTime? Date { get; set; }

    public string? Purpose { get; set; }

    public virtual Office? Office { get; set; }

    public virtual PurchaseRequest? Pr { get; set; }

    public virtual ICollection<Risdetail> Risdetails { get; set; } = new List<Risdetail>();
}
