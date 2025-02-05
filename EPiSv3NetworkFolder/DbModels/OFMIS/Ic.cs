﻿using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Ic
{
    public int Id { get; set; }

    public int? Prid { get; set; }

    public string? Office { get; set; }

    public string? Issuer { get; set; }

    public string? IssuerPosition { get; set; }

    public string? Receiver { get; set; }

    public string? ReceiverPos { get; set; }

    public DateTime? Date { get; set; }

    public string? CreatedBy { get; set; }

    public string? Pgso { get; set; }

    public string? Pgsopos { get; set; }

    public virtual ICollection<Icsdetail> Icsdetails { get; set; } = new List<Icsdetail>();

    public virtual PurchaseRequest? Pr { get; set; }
}
