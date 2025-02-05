﻿using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class PayrollOt
{
    public int Id { get; set; }

    public int? ObRid { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public DateTime? Date { get; set; }

    public int? ApprovedById { get; set; }

    public string? ApprovedPosition { get; set; }

    public int? HeadId { get; set; }

    public string? HeadPosition { get; set; }

    public string? CreatedBy { get; set; }

    public int? Paid { get; set; }

    public string? Paposition { get; set; }

    public int? Ptid { get; set; }

    public string? Ptposition { get; set; }

    public virtual Obligation? ObR { get; set; }

    public virtual ICollection<PayrollOtdetail> PayrollOtdetails { get; set; } = new List<PayrollOtdetail>();
}
