using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class Skill
{
    public double? FldEmpId { get; set; }

    public string? FldSkill { get; set; }

    public int FldIndex { get; set; }

    public bool? FldApproved { get; set; }

    public bool? FldApprovedAo { get; set; }
}
