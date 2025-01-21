using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class TempServiceRecordsConsolidated
{
    public double? FldSrid { get; set; }

    public long? FldEmpId { get; set; }

    public string? FldLastname { get; set; }

    public string? FldFirstname { get; set; }

    public string? FldMiddlename { get; set; }

    public DateTime? FldFrom { get; set; }

    public DateTime? FldTo { get; set; }

    public string? FldDesignation { get; set; }

    public string? FldStatus { get; set; }

    public double? FldSalary { get; set; }

    public string? FldFrequency { get; set; }

    public string? FldStation { get; set; }

    public string? FldBranch { get; set; }

    public double? FldLeaveWoPay { get; set; }

    public string? FldDateSep { get; set; }

    public string? FldCause { get; set; }

    public string? FldRemarks { get; set; }

    public string? FldSgnSi { get; set; }

    public bool? FldGovernment { get; set; }

    public long FldIndex { get; set; }
}
