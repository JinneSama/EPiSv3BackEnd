using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class Srrequest
{
    public double? FldSridno { get; set; }

    public double? FldEmpId { get; set; }

    public DateTime? FldSrdate { get; set; }

    public double? FldOrno { get; set; }

    public bool? FldPrinted { get; set; }

    public string? FldPrintedDate { get; set; }

    public string? FldEnteredBy { get; set; }

    public bool? FldApproved { get; set; }

    public bool? FldToDate { get; set; }

    public int FldIndex { get; set; }

    public double? FldAmount { get; set; }

    public string? FldStatus { get; set; }

    public bool? FldExempted { get; set; }

    public string? FldPrepared { get; set; }

    public string? FldPosition1 { get; set; }

    public string? FldReviewed { get; set; }

    public string? FldPosition2 { get; set; }

    public string? FldNote { get; set; }

    public string? FldAsOf { get; set; }

    public string? FldExemption { get; set; }
}
