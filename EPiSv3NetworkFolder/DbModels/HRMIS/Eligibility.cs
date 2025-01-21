using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class Eligibility
{
    public long? FldEmpId { get; set; }

    public string? FldEligibility { get; set; }

    public double? FldRating { get; set; }

    public DateTime? FldExamDate { get; set; }

    public string? FldExamPlace { get; set; }

    public string? FldLicenseNo { get; set; }

    public DateTime? FldDateReleased { get; set; }

    public int FldIndex { get; set; }

    public string? FldLevel { get; set; }

    public bool? FldApproved { get; set; }

    public bool? FldApprovedAo { get; set; }

    public bool? FldExpiry { get; set; }

    public DateTime? FldDateExpire { get; set; }
}
