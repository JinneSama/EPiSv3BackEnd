using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class Operator
{
    public int? EmpId { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public bool FldAdd { get; set; }

    public bool FldEdit { get; set; }

    public bool FldDelete { get; set; }

    public bool FldAdministrator { get; set; }

    public int FldIndex { get; set; }

    public bool? FldApproveSr { get; set; }

    public bool? FldApproveChanges { get; set; }
}
