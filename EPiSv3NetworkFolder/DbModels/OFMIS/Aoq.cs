﻿using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Aoq
{
    public int Id { get; set; }

    public int? Prid { get; set; }

    public DateTime? Date { get; set; }

    public string? ControlNo { get; set; }

    public string? Description { get; set; }

    public string? Purpose { get; set; }

    public string? NameofProject { get; set; }

    public string? RequisitioningOffice { get; set; }

    public decimal? Abc { get; set; }

    public int? Rfqno { get; set; }

    public string? CreatedBy { get; set; }

    public string? CreatedById { get; set; }

    public int? OfficeId { get; set; }

    public string? Head { get; set; }

    public string? HeadPosition { get; set; }

    public int? Bacchairperson { get; set; }

    public virtual ICollection<Aoqdetail> Aoqdetails { get; set; } = new List<Aoqdetail>();

    public virtual Signatory? BacchairpersonNavigation { get; set; }

    public virtual Office? Office { get; set; }

    public virtual PurchaseRequest? Pr { get; set; }

    public virtual ICollection<Signatory> Bacs { get; set; } = new List<Signatory>();
}
