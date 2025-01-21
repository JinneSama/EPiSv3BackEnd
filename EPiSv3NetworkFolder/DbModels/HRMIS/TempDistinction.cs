using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class TempDistinction
{
    public long? FldEmpId { get; set; }

    public string? FldDistinction { get; set; }

    public int FldIndex { get; set; }

    public bool? FldApproved { get; set; }

    public int FldCtrlNo { get; set; }
}
