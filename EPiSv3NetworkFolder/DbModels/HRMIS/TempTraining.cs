using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class TempTraining
{
    public long? FldEmpId { get; set; }

    public string? FldTraining { get; set; }

    public DateTime? FldFrom { get; set; }

    public DateTime? FldTo { get; set; }

    public double? FldHours { get; set; }

    public string? FldHost { get; set; }

    public int FldIndex { get; set; }

    public string? FldType { get; set; }

    public bool? FldApproved { get; set; }

    public long FldCtrlNo { get; set; }
}
