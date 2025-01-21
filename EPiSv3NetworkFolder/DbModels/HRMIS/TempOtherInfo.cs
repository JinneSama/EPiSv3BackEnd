using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class TempOtherInfo
{
    public long? FldEmpId { get; set; }

    public string? FldSkill { get; set; }

    public string? FldDistinction { get; set; }

    public string? FldOrganization { get; set; }

    public int? FldIndex { get; set; }

    public long Index { get; set; }
}
