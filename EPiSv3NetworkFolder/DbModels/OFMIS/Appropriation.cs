﻿using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Appropriation
{
    public int Id { get; set; }

    public int? AppropriationId { get; set; }

    public string? AccountCode { get; set; }

    public string? AccountCodeText { get; set; }

    public string? FundType { get; set; }

    public int? FundTypeId { get; set; }

    public string? AccountName { get; set; }

    public decimal? Appropriation1 { get; set; }

    public int? Year { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? Createdby { get; set; }

    public int? OfficeId { get; set; }

    public string? Ft { get; set; }

    public virtual ICollection<AllotmentLetter> AllotmentLetters { get; set; } = new List<AllotmentLetter>();

    public virtual ICollection<Allotment> Allotments { get; set; } = new List<Allotment>();

    public virtual FundType? FundTypeNavigation { get; set; }

    public virtual ICollection<Ordetail> Ordetails { get; set; } = new List<Ordetail>();

    public virtual ICollection<ReAlignment> ReAlignmentSourceAppropriations { get; set; } = new List<ReAlignment>();

    public virtual ICollection<ReAlignment> ReAlignmentTargetAppropriations { get; set; } = new List<ReAlignment>();
}
