using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class Child
{
    public int FldEmpId { get; set; }

    public string? FldChildName { get; set; }

    public DateTime? FldBirthday { get; set; }

    public int FldIndex { get; set; }

    public bool? FldApproved { get; set; }

    public bool? FldApprovedAo { get; set; }
}
