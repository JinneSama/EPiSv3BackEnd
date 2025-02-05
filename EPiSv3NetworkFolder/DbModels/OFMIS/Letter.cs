﻿using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.OFMIS;

public partial class Letter
{
    public int Id { get; set; }

    public int? RefId { get; set; }

    public string? TableName { get; set; }

    public string? ControlNo { get; set; }

    public string? Template { get; set; }

    public string? Type { get; set; }

    public string? Title { get; set; }

    public DateTime? Date { get; set; }

    public int? OfficeId { get; set; }

    public string? InsideAddress { get; set; }

    public string? Salutation { get; set; }

    public string? Body { get; set; }

    public string? Closing { get; set; }

    public string? Signatories { get; set; }

    public string? SignatoriesPosition { get; set; }

    public string? Cc { get; set; }

    public bool? InTheAbsence { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual Office? Office { get; set; }

    public virtual ICollection<Obligation> Obrs { get; set; } = new List<Obligation>();
}
