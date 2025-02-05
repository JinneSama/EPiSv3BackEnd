﻿using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Apr
{
    public int Id { get; set; }

    public int? Prid { get; set; }

    public string? ControlNo { get; set; }

    public DateTime? Date { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public int? Pgsoid { get; set; }

    public int? AccountantId { get; set; }

    public int? GovernorId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public virtual ICollection<Aprdetail> Aprdetails { get; set; } = new List<Aprdetail>();

    public virtual PurchaseRequest? Pr { get; set; }
}
