using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class TempChild
{
    public long FldEmpId { get; set; }

    public string? FldChildName { get; set; }

    public DateTime? FldBirthday { get; set; }

    public int FldIndex { get; set; }

    public bool? FldApproved { get; set; }

    public long FldCtrlNo { get; set; }
}
