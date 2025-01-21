using System;
using System.Collections.Generic;

namespace EPiSv3NetworkFolder.DbModels.HRMIS;

public partial class Company
{
    public double? SetupId { get; set; }

    public string? FldName { get; set; }

    public string? FldPosition { get; set; }

    public int FldIndex { get; set; }
}
