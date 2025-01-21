using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class Prclist
{
    public int FldIndex { get; set; }

    public string? FldEligibility { get; set; }

    public int? FldLevel { get; set; }
}
