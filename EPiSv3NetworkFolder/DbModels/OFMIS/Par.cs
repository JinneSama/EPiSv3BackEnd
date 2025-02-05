﻿using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Par
{
    public int Id { get; set; }

    public int? Prid { get; set; }

    public string? EntityName { get; set; }

    public string? FundCluster { get; set; }

    public int? Pgsoid { get; set; }

    public string? Pgso { get; set; }

    public string? Pgsoposition { get; set; }

    public int? ReceivedById { get; set; }

    public string? ReceivedBy { get; set; }

    public string? ReceivedByPos { get; set; }

    public int? IssuedById { get; set; }

    public string? IssuedBy { get; set; }

    public string? IssuedByPos { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public string? ModifiedBy { get; set; }

    public string? Remarks { get; set; }

    public virtual ICollection<Pardetail> Pardetails { get; set; } = new List<Pardetail>();

    public virtual PurchaseRequest? Pr { get; set; }
}
