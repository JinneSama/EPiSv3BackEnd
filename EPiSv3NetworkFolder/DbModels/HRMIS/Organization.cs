using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class Organization
{
    public double? FldEmpId { get; set; }

    public string? FldOrganization { get; set; }

    public int FldIndex { get; set; }

    public bool? FldApproved { get; set; }

    public bool? FldApprovedAo { get; set; }
}
