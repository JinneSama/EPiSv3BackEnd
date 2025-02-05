﻿using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Liquidation
{
    public int Id { get; set; }

    public int? ObRid { get; set; }

    public int? PayeeId { get; set; }

    public string? PayeeName { get; set; }

    public string? PayeeAddress { get; set; }

    public int? Paid { get; set; }

    public string? AccountantName { get; set; }

    public string? AccountantPosition { get; set; }

    public int? HeadOfDep { get; set; }

    public string? HeadName { get; set; }

    public string? HeadPosition { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? Date { get; set; }

    public string? Particulars { get; set; }

    public decimal? Amount { get; set; }

    public int? EmployeeId { get; set; }

    public string? PeriodCovered { get; set; }

    public decimal? AmountPerDv { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual Signatory? HeadOfDepNavigation { get; set; }

    public virtual ICollection<Lrdetail> Lrdetails { get; set; } = new List<Lrdetail>();

    public virtual Obligation? ObR { get; set; }

    public virtual Signatory? Pa { get; set; }

    public virtual Payee? Payee { get; set; }
}
